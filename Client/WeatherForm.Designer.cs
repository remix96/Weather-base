
namespace Client
{
    partial class WeatherForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.pictureBoxDetail2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl31 = new Client.UserControl3();
            this.userControl21 = new Client.UserControl2();
            this.userControl11 = new Client.UserControl1();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 45);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "PREVISIONI 7 GIORNI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "CORRENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(540, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "STATISTICHE ANNO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl31);
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 370);
            this.panel1.TabIndex = 0;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.White;
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLocation.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(252, 50);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(235, 24);
            this.textBoxLocation.TabIndex = 3;
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountry.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(493, 50);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCountry.Multiline = true;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(65, 24);
            this.textBoxCountry.TabIndex = 4;
            this.textBoxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLocation
            // 
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(101, 50);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(125, 24);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Città  -  location";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountry
            // 
            this.labelCountry.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(592, 50);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(200, 24);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Codice nazione  -  country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDetail2
            // 
            this.pictureBoxDetail2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail2.Image")));
            this.pictureBoxDetail2.Location = new System.Drawing.Point(226, 49);
            this.pictureBoxDetail2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail2.Name = "pictureBoxDetail2";
            this.pictureBoxDetail2.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail2.TabIndex = 17;
            this.pictureBoxDetail2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(810, 370);
            this.userControl31.TabIndex = 2;
            this.userControl31.TabStop = false;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(810, 370);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(810, 370);
            this.userControl11.TabIndex = 0;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxDetail2);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meteo";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.PictureBox pictureBoxDetail2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

