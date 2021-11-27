using System.Windows.Forms;

namespace Client
{
    public partial class RealZoom : Form
    {
        public RealZoom()
        {
            InitializeComponent();
            Controls.Add(PictureBoxPlot);
            PictureBoxPlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Impostazione per rendere evitare che il grafico non si ingrandisca quando aumentata dimensione finestra RealZoom
        }
    }
}
