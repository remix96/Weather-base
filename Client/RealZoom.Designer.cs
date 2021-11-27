namespace Client
{
    partial class RealZoom
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealZoom));
            this.pictureBoxPlot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlot
            // 
            this.pictureBoxPlot.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxPlot.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlot.Name = "pictureBoxPlot";
            this.pictureBoxPlot.Size = new System.Drawing.Size(720, 720);
            this.pictureBoxPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlot.TabIndex = 0;
            this.pictureBoxPlot.TabStop = false;
            // 
            // RealZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.pictureBoxPlot);
            this.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RealZoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlot;

        public System.Windows.Forms.PictureBox PictureBoxPlot
        {
            get { return pictureBoxPlot; }
        }
    }
}