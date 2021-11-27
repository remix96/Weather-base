using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControl1 : UserControl
    {
        TextBox weatherFormTextBoxLocation;
        TextBox weatherFormTextBoxCountry;
        public UserControl1()
        {
            InitializeComponent();
            ResetView();
        }

        internal void ResetView()
        {
            labelCurrentTemperature.Hide();
            pictureBoxCurrentIcon.Hide();
            labelCurrentDescription.Hide();
            button1.Hide();
            ResetDetailView();
        }

        private void ResetDetailView()
        {
            labelHumidity.Hide();
            labelCloudiness.Hide();
            labelPressure.Hide();
            labelWindSpeed.Hide();
            labelFeelsLikeTemperature.Hide();
            labelHumidityValue.Hide();
            labelCloudinessValue.Hide();
            labelPressureValue.Hide();
            labelWindSpeedValue.Hide();
            labelFeelsLikeTemperatureValue.Hide();
            pictureBoxDetail1.Hide();
            pictureBoxDetail2.Hide();
            pictureBoxDetail3.Hide();
            pictureBoxDetail4.Hide();
            pictureBoxDetail5.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            ResetDetailView();

            weatherFormTextBoxLocation = (ParentForm.Controls["textBoxLocation"] as TextBox); // Recupero textBox location da form principale WeatherForm
            weatherFormTextBoxCountry = (ParentForm.Controls["textBoxCountry"] as TextBox);
            string location = weatherFormTextBoxLocation.Text; // Impostazione stringa location contenente valore Text di textBox location recuperata
            string country = weatherFormTextBoxCountry.Text;
            var url = $"http://localhost:54000/morecurrentdetails?location={location}&country={country}";
            HttpResponseMessage response = null;
            try
            {
                response = await APIHelper.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    WeatherDetailModel data = await response.Content.ReadAsAsync<WeatherDetailModel>();
                    labelHumidityValue.Text = data.Humidity;
                    labelCloudinessValue.Text = data.Cloudiness;
                    labelPressureValue.Text = data.Pressure;
                    labelWindSpeedValue.Text = data.Wind_Speed;
                    labelFeelsLikeTemperatureValue.Text = data.Feels_Like_Temperature;

                    labelHumidity.Show();
                    labelCloudiness.Show();
                    labelPressure.Show();
                    labelWindSpeed.Show();
                    labelFeelsLikeTemperature.Show();
                    labelHumidityValue.Show();
                    labelCloudinessValue.Show();
                    labelPressureValue.Show();
                    labelWindSpeedValue.Show();
                    labelFeelsLikeTemperatureValue.Show();
                    pictureBoxDetail1.Show();
                    pictureBoxDetail1.BringToFront();
                    pictureBoxDetail2.Show();
                    pictureBoxDetail2.BringToFront();
                    pictureBoxDetail3.Show();
                    pictureBoxDetail3.BringToFront();
                    pictureBoxDetail4.Show();
                    pictureBoxDetail4.BringToFront();
                    pictureBoxDetail5.Show();
                    pictureBoxDetail5.BringToFront();
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
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Dispose();
            }
        }
    }
}
