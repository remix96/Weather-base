using System.IO;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            ResetView();
            pictureBoxForecastPlot.MouseClick += new MouseEventHandler(ZoomPlot); // Aggiunto metodo ZoomPlot da eseguire al click col mouse su pictureBox
        }

        internal void ResetView()
        {
            pictureBox1Icon.Hide();
            pictureBox2Icon.Hide();
            pictureBox3Icon.Hide();
            pictureBox4Icon.Hide();
            pictureBox5Icon.Hide();
            pictureBox6Icon.Hide();
            pictureBox7Icon.Hide();
            label1Temperature.Hide();
            label2Temperature.Hide();
            label3Temperature.Hide();
            label4Temperature.Hide();
            label5Temperature.Hide();
            label6Temperature.Hide();
            label7Temperature.Hide();
            label1Description.Hide();
            label2Description.Hide();
            label3Description.Hide();
            label4Description.Hide();
            label5Description.Hide();
            label6Description.Hide();
            label7Description.Hide();
            button1.Hide();
            pictureBoxForecastPlot.Hide();
        }

        internal void ShowView()
        {
            pictureBox1Icon.Show();
            pictureBox2Icon.Show();
            pictureBox3Icon.Show();
            pictureBox4Icon.Show();
            pictureBox5Icon.Show();
            pictureBox6Icon.Show();
            pictureBox7Icon.Show();
            label1Temperature.Show();
            label2Temperature.Show();
            label3Temperature.Show();
            label4Temperature.Show();
            label5Temperature.Show();
            label6Temperature.Show();
            label7Temperature.Show();
            label1Temperature.BringToFront();
            label2Temperature.BringToFront();
            label3Temperature.BringToFront();
            label4Temperature.BringToFront();
            label5Temperature.BringToFront();
            label6Temperature.BringToFront();
            label7Temperature.BringToFront();
            label1Description.Show();
            label2Description.Show();
            label3Description.Show();
            label4Description.Show();
            label5Description.Show();
            label6Description.Show();
            label7Description.Show();
            button1.Show();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            WeatherForm wf = (WeatherForm)this.FindForm(); // Indicazione form principale WeatherForm
            await wf.ExecuteScriptR("1"); // Richiamo metodo ExecuteScriptR di WeatherForm
            pictureBoxForecastPlot.Image = await wf.RetrievePlot(); // Impostazione immagine di pictureBox per grafico
            File.Delete("C:\\Users\\remo9\\Desktop\\ProgettoMeteo\\plot.png"); // Rimozione file plot locale
            pictureBoxForecastPlot.Show();
            this.Cursor = Cursors.Default;
        }

        private void ZoomPlot(object sender, System.EventArgs e)
        {
            RealZoom rz = new RealZoom(); // Creazione form RealZoom
            rz.Show();
            rz.PictureBoxPlot.Image = pictureBoxForecastPlot.Image; // Impostazione grafico ottenuto, da pagina corrente a pictureBox di RealZoom
        }
    }
}
