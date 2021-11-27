using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class WeatherForm : Form
    {
 
        public WeatherForm()
        {
            InitializeComponent();
            try
            {
                APIHelper.InitializeClient(); // Inizializzazione client HTTP appena parte l'applicazione
            }
            catch
            {
                MessageBox.Show("Non è stato possibile inizializzare il client HTTP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            // All'avvio sono nascosti i contenuti di tutte le pagine
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private static async Task<Image> RetrieveIcon(string base64Icon) // Metodo per recuperare icona da stringa base64
        {
            Image icon = null;
            MemoryStream ms = null;
            await Task.Run(() =>
            {
                try
                {
                    byte[] pic = Convert.FromBase64String(base64Icon); // Conversione da stringa base64 a array di byte
                    ms = new MemoryStream(pic);
                    icon = Image.FromStream(ms); // Ricostruzione immagine
                }
                catch
                {
                    // Apertura finestra di errore con apposita descrizoine
                    MessageBox.Show("Non è stato possibile recuperare l'immagine del meteo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ms != null)
                        ms.Dispose();
                }
            });
            return icon;
        }

        private static async Task<Image> RetrieveIcon(byte[] pic) // Overload (polimorfismo compile time) metodo RetrieveIcon
        {
            Image icon = null;
            MemoryStream ms = null;
            await Task.Run(() =>
            {
                try
                {
                    ms = new MemoryStream(pic);
                    icon = Image.FromStream(ms);
                }
                catch
                {
                    MessageBox.Show("Non è stato possibile recuperare l'immagine del meteo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ms != null)
                        ms.Dispose();
                }
            });
            return icon;
        }

        public async Task<Image> RetrievePlot() // Metodo per recuperare immagine plot
        {
            Image plot = null;
            Stream stream = null;
            await Task.Run(() =>
            {
                try
                {
                    stream = File.OpenRead("C:\\Users\\remo9\\Desktop\\ProgettoMeteo\\plot.png");
                    plot = Image.FromStream(stream);
                }
                catch
                {
                    MessageBox.Show("Non è stato possibile recuperare il grafico.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }
            });
            return plot;
        }

        public async Task<string> ExecuteScriptR(string mode) // Metodo per eseguire script R, con modalità selezionata per ottenere il rispettivo grafico
        {
            var scriptPath = @"C:\Users\remo9\Desktop\ProgettoMeteo\statistics.R"; // Indicazione path dello script R da eseguire
            string args = $"{textBoxLocation.Text},{textBoxCountry.Text}"; // Recupero location e country, separate da virgola
            string result = "";
            await Task.Run(() =>
            {
                try
                {
                    ProcessStartInfo pInfo = new ProcessStartInfo();
                    pInfo.FileName = @"C:\Program Files\R\R-4.1.1\bin\Rscript.exe"; // Path dell'eseguibile R script
                    pInfo.WorkingDirectory = Path.GetDirectoryName(pInfo.FileName);
                    pInfo.Arguments = scriptPath + " " + args + $",{mode}"; // Argomenti della riga di comando da usare all'avvio dell'applicazione
                    pInfo.RedirectStandardInput = false; // Nessuna lettura dal flusso StandardInput
                    pInfo.RedirectStandardOutput = true; // Scrittura nel flusso StandardOutput
                    pInfo.UseShellExecute = false; // Uso della shell del sistema operativo per avviare il processo
                    pInfo.CreateNoWindow = true; // Avvio del processo non in una nuova finestra
                    Process proc = new Process();
                    proc.StartInfo = pInfo;
                    proc.Start();
                    proc.WaitForExit();
                    result = proc.StandardOutput.ReadToEnd();
                    if (proc.HasExited == false) // Se ancora il processo non ha finito
                        if (proc.Responding)
                            proc.CloseMainWindow(); // Se non risponde allora è chiusa la main window
                        else
                            proc.Kill(); // Se non risponde allora è forzata la sua chiusura
                }
                catch
                {
                    MessageBox.Show("Errore script R.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            return result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting; // Cambio cursore per evidenziare inizio caricamento processamento richiesta
            // Impostazione elementi visualizzati
            userControl21.Hide();
            userControl31.Hide();
            userControl11.ResetView();
            userControl11.Show();
            userControl11.BringToFront();

            // Recupero location e country da rispettiva textBox 
            string location = textBoxLocation.Text;
            string country = textBoxCountry.Text;
            var url = $"http://localhost:54000/currentweather?location={location}&country={country}"; // Creazione url con parametri per richiesta GET
            HttpResponseMessage response = null;
            try
            {
                response = await APIHelper.ApiClient.GetAsync(url); // Attesa response e dopo le } dell'using avviene chiusura di tutto ciò che è relativo a questa richiesta; così migliore gestione risorse
                if (response.IsSuccessStatusCode) // Se la risposta ha avuto codice di successo (200)
                {
                    WeatherCurrentModel data = await response.Content.ReadAsAsync<WeatherCurrentModel>(); // Conversione, tramite Json.NET, del dato nel modello indicato
                    userControl11.LabelCurrentTemperature.Text = data.Temperature; // Riempimento label temperatura tramite risposta server
                    userControl11.LabelCurrentDescription.Text = data.Description;
                    byte[] pic = Convert.FromBase64String(data.Base64_Icon);
                    userControl11.PictureBoxCurrentIcon.Image = await RetrieveIcon(pic); // Impostazione immagine pictureBox tramite icona recuperata

                    userControl11.LabelCurrentTemperature.Show();
                    userControl11.LabelCurrentDescription.Show();
                    userControl11.PictureBoxCurrentIcon.Show();
                    userControl11.Button1.Show();
                    this.Cursor = Cursors.Default; // Cambio cursore a normale per evidenziare fine processamento richiesta
                }
                else
                {
                    ExceptionResponseModel error = await response.Content.ReadAsAsync<ExceptionResponseModel>(); // Recupero descrizione errore se risposta server ha dato esito negativo
                    throw new Exception(error.Description);
                }
            }
            catch (Exception ex)
            {
                userControl11.Hide();
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Dispose();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            userControl11.Hide();
            userControl31.Hide();
            userControl21.ResetView();
            userControl21.Show();
            userControl21.BringToFront();

            string location = textBoxLocation.Text;
            string country = textBoxCountry.Text;
            var url = $"http://localhost:54000/weekforecast?location={location}&country={country}";
            HttpResponseMessage response = null;
            try
            {
                response = await APIHelper.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    WeatherDayModel data = await response.Content.ReadAsAsync<WeatherDayModel>();
                    userControl21.Label1Temperature.Text = data.Day1.Temperature;
                    userControl21.Label2Temperature.Text = data.Day2.Temperature;
                    userControl21.Label3Temperature.Text = data.Day3.Temperature;
                    userControl21.Label4Temperature.Text = data.Day4.Temperature;
                    userControl21.Label5Temperature.Text = data.Day5.Temperature;
                    userControl21.Label6Temperature.Text = data.Day6.Temperature;
                    userControl21.Label7Temperature.Text = data.Day7.Temperature;
                    userControl21.Label1Description.Text = data.Day1.Description;
                    userControl21.Label2Description.Text = data.Day2.Description;
                    userControl21.Label3Description.Text = data.Day3.Description;
                    userControl21.Label4Description.Text = data.Day4.Description;
                    userControl21.Label5Description.Text = data.Day5.Description;
                    userControl21.Label6Description.Text = data.Day6.Description;
                    userControl21.Label7Description.Text = data.Day7.Description;
                    userControl21.PictureBox1Icon.Image = await RetrieveIcon(data.Day1.Base64_Icon);
                    userControl21.PictureBox2Icon.Image = await RetrieveIcon(data.Day2.Base64_Icon);
                    userControl21.PictureBox3Icon.Image = await RetrieveIcon(data.Day3.Base64_Icon);
                    userControl21.PictureBox4Icon.Image = await RetrieveIcon(data.Day4.Base64_Icon);
                    userControl21.PictureBox5Icon.Image = await RetrieveIcon(data.Day5.Base64_Icon);
                    userControl21.PictureBox6Icon.Image = await RetrieveIcon(data.Day6.Base64_Icon);
                    userControl21.PictureBox7Icon.Image = await RetrieveIcon(data.Day7.Base64_Icon);
                    userControl21.ShowView();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    ExceptionResponseModel error = await response.Content.ReadAsAsync<ExceptionResponseModel>();
                    throw new Exception(error.Description);
                }
            }
            catch (Exception ex)
            {
                userControl21.Hide();
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            userControl11.Hide();
            userControl21.Hide();
            userControl31.ResetView();
            userControl31.Show();
            userControl31.ShowView();
            this.Cursor = Cursors.Default;
        }
    }
}
