using System.IO;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            ResetView();
            pictureBoxTemperature.MouseClick += new MouseEventHandler(ZoomPlot1);
            pictureBoxHumidity.MouseClick += new MouseEventHandler(ZoomPlot2);
            pictureBoxPrecipitation.MouseClick += new MouseEventHandler(ZoomPlot3);
        }

        internal void ResetView()
        {
            labelPlot.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            pictureBoxTemperature.Hide();
            pictureBoxHumidity.Hide();
            pictureBoxPrecipitation.Hide();
            pictureBoxIcon1.Hide();
            pictureBoxIcon2.Hide();
            pictureBoxIcon3.Hide();
        }

        internal void ShowView()
        {
            labelPlot.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            pictureBoxIcon1.Show();
            pictureBoxIcon2.Show();
            pictureBoxIcon3.Show();
        }

        private void PlotVisualizer(PictureBox pb, string title)
        {
            RealZoom rz = new RealZoom();
            rz.Text = title; // Impostazione titolo form RealZoom
            rz.PictureBoxPlot.Image = pb.Image;
            rz.Show();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            pictureBoxTemperature.Hide();
            WeatherForm wf = (WeatherForm)this.FindForm();
            await wf.ExecuteScriptR("2");
            pictureBoxTemperature.Image = await wf.RetrievePlot();
            File.Delete("C:\\Users\\remo9\\Desktop\\ProgettoMeteo\\plot.png");
            if (pictureBoxTemperature.Image != null)
                pictureBoxTemperature.Show();
            this.Cursor = Cursors.Default;
        }

        private async void button2_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            pictureBoxHumidity.Hide();
            WeatherForm wf = (WeatherForm)this.FindForm();
            await wf.ExecuteScriptR("3");
            pictureBoxHumidity.Image = await wf.RetrievePlot();
            File.Delete("C:\\Users\\remo9\\Desktop\\ProgettoMeteo\\plot.png");
            if (pictureBoxHumidity.Image != null)
                pictureBoxHumidity.Show();
            this.Cursor = Cursors.Default;
        }

        private async void button3_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            pictureBoxPrecipitation.Hide();
            WeatherForm wf = (WeatherForm)this.FindForm();
            await wf.ExecuteScriptR("4");
            pictureBoxPrecipitation.Image = await wf.RetrievePlot();
            File.Delete("C:\\Users\\remo9\\Desktop\\ProgettoMeteo\\plot.png");
            if (pictureBoxPrecipitation.Image != null)
                pictureBoxPrecipitation.Show();
            this.Cursor = Cursors.Default;
        }

        private void ZoomPlot1(object sender, System.EventArgs e)
        {
            PlotVisualizer(pictureBoxTemperature, "Grafico temperatura anno"); // Passato anche titolo da dare alla form RealZoom per riconoscere grafico selezionato
        }

        private void ZoomPlot2(object sender, System.EventArgs e)
        {
            PlotVisualizer(pictureBoxHumidity, "Grafico umidità anno");
        }

        private void ZoomPlot3(object sender, System.EventArgs e)
        {
            PlotVisualizer(pictureBoxPrecipitation, "Grafico precipitazione anno");
        }
    }
}
