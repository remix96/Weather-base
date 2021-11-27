namespace Client
{
    partial class UserControl1
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelCloudiness = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelFeelsLikeTemperature = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.labelCloudinessValue = new System.Windows.Forms.Label();
            this.labelPressureValue = new System.Windows.Forms.Label();
            this.labelWindSpeedValue = new System.Windows.Forms.Label();
            this.labelFeelsLikeTemperatureValue = new System.Windows.Forms.Label();
            this.pictureBoxCurrentIcon = new System.Windows.Forms.PictureBox();
            this.labelCurrentTemperature = new System.Windows.Forms.Label();
            this.labelCurrentDescription = new System.Windows.Forms.Label();
            this.pictureBoxDetail1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetail2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetail3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetail4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetail5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dettagli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHumidity
            // 
            this.labelHumidity.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(546, 25);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(79, 23);
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Umidità";
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCloudiness
            // 
            this.labelCloudiness.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloudiness.Location = new System.Drawing.Point(495, 90);
            this.labelCloudiness.Margin = new System.Windows.Forms.Padding(0);
            this.labelCloudiness.Name = "labelCloudiness";
            this.labelCloudiness.Size = new System.Drawing.Size(180, 23);
            this.labelCloudiness.TabIndex = 5;
            this.labelCloudiness.Text = "Nuvolosità";
            this.labelCloudiness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPressure
            // 
            this.labelPressure.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(495, 154);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(180, 23);
            this.labelPressure.TabIndex = 6;
            this.labelPressure.Text = "Pressione";
            this.labelPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.Location = new System.Drawing.Point(495, 223);
            this.labelWindSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(180, 23);
            this.labelWindSpeed.TabIndex = 7;
            this.labelWindSpeed.Text = "Velocità del vento";
            this.labelWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFeelsLikeTemperature
            // 
            this.labelFeelsLikeTemperature.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLikeTemperature.Location = new System.Drawing.Point(483, 288);
            this.labelFeelsLikeTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.labelFeelsLikeTemperature.Name = "labelFeelsLikeTemperature";
            this.labelFeelsLikeTemperature.Size = new System.Drawing.Size(205, 23);
            this.labelFeelsLikeTemperature.TabIndex = 8;
            this.labelFeelsLikeTemperature.Text = "Temperatura percepita";
            this.labelFeelsLikeTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityValue.Location = new System.Drawing.Point(495, 53);
            this.labelHumidityValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.Size = new System.Drawing.Size(180, 23);
            this.labelHumidityValue.TabIndex = 9;
            this.labelHumidityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCloudinessValue
            // 
            this.labelCloudinessValue.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloudinessValue.Location = new System.Drawing.Point(495, 117);
            this.labelCloudinessValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelCloudinessValue.Name = "labelCloudinessValue";
            this.labelCloudinessValue.Size = new System.Drawing.Size(180, 23);
            this.labelCloudinessValue.TabIndex = 10;
            this.labelCloudinessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPressureValue
            // 
            this.labelPressureValue.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureValue.Location = new System.Drawing.Point(495, 182);
            this.labelPressureValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelPressureValue.Name = "labelPressureValue";
            this.labelPressureValue.Size = new System.Drawing.Size(180, 23);
            this.labelPressureValue.TabIndex = 11;
            this.labelPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWindSpeedValue
            // 
            this.labelWindSpeedValue.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedValue.Location = new System.Drawing.Point(495, 251);
            this.labelWindSpeedValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindSpeedValue.Name = "labelWindSpeedValue";
            this.labelWindSpeedValue.Size = new System.Drawing.Size(180, 23);
            this.labelWindSpeedValue.TabIndex = 12;
            this.labelWindSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFeelsLikeTemperatureValue
            // 
            this.labelFeelsLikeTemperatureValue.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLikeTemperatureValue.Location = new System.Drawing.Point(495, 316);
            this.labelFeelsLikeTemperatureValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelFeelsLikeTemperatureValue.Name = "labelFeelsLikeTemperatureValue";
            this.labelFeelsLikeTemperatureValue.Size = new System.Drawing.Size(180, 23);
            this.labelFeelsLikeTemperatureValue.TabIndex = 13;
            this.labelFeelsLikeTemperatureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCurrentIcon
            // 
            this.pictureBoxCurrentIcon.Location = new System.Drawing.Point(113, 60);
            this.pictureBoxCurrentIcon.Name = "pictureBoxCurrentIcon";
            this.pictureBoxCurrentIcon.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxCurrentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentIcon.TabIndex = 0;
            this.pictureBoxCurrentIcon.TabStop = false;
            // 
            // labelCurrentTemperature
            // 
            this.labelCurrentTemperature.Font = new System.Drawing.Font("Lato", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTemperature.Location = new System.Drawing.Point(153, 63);
            this.labelCurrentTemperature.Name = "labelCurrentTemperature";
            this.labelCurrentTemperature.Size = new System.Drawing.Size(100, 23);
            this.labelCurrentTemperature.TabIndex = 1;
            this.labelCurrentTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentDescription
            // 
            this.labelCurrentDescription.Font = new System.Drawing.Font("Lato", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDescription.Location = new System.Drawing.Point(75, 214);
            this.labelCurrentDescription.Name = "labelCurrentDescription";
            this.labelCurrentDescription.Size = new System.Drawing.Size(257, 27);
            this.labelCurrentDescription.TabIndex = 2;
            this.labelCurrentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDetail1
            // 
            this.pictureBoxDetail1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail1.Image")));
            this.pictureBoxDetail1.Location = new System.Drawing.Point(525, 25);
            this.pictureBoxDetail1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail1.Name = "pictureBoxDetail1";
            this.pictureBoxDetail1.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail1.TabIndex = 14;
            this.pictureBoxDetail1.TabStop = false;
            // 
            // pictureBoxDetail2
            // 
            this.pictureBoxDetail2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail2.Image")));
            this.pictureBoxDetail2.Location = new System.Drawing.Point(511, 89);
            this.pictureBoxDetail2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail2.Name = "pictureBoxDetail2";
            this.pictureBoxDetail2.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail2.TabIndex = 16;
            this.pictureBoxDetail2.TabStop = false;
            // 
            // pictureBoxDetail3
            // 
            this.pictureBoxDetail3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail3.Image")));
            this.pictureBoxDetail3.Location = new System.Drawing.Point(515, 150);
            this.pictureBoxDetail3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail3.Name = "pictureBoxDetail3";
            this.pictureBoxDetail3.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail3.TabIndex = 17;
            this.pictureBoxDetail3.TabStop = false;
            // 
            // pictureBoxDetail4
            // 
            this.pictureBoxDetail4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail4.Image")));
            this.pictureBoxDetail4.Location = new System.Drawing.Point(481, 222);
            this.pictureBoxDetail4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail4.Name = "pictureBoxDetail4";
            this.pictureBoxDetail4.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail4.TabIndex = 18;
            this.pictureBoxDetail4.TabStop = false;
            // 
            // pictureBoxDetail5
            // 
            this.pictureBoxDetail5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetail5.Image")));
            this.pictureBoxDetail5.Location = new System.Drawing.Point(465, 285);
            this.pictureBoxDetail5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDetail5.Name = "pictureBoxDetail5";
            this.pictureBoxDetail5.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxDetail5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetail5.TabIndex = 19;
            this.pictureBoxDetail5.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDetail5);
            this.Controls.Add(this.pictureBoxDetail4);
            this.Controls.Add(this.pictureBoxDetail3);
            this.Controls.Add(this.pictureBoxDetail2);
            this.Controls.Add(this.pictureBoxDetail1);
            this.Controls.Add(this.labelFeelsLikeTemperatureValue);
            this.Controls.Add(this.labelWindSpeedValue);
            this.Controls.Add(this.labelPressureValue);
            this.Controls.Add(this.labelCloudinessValue);
            this.Controls.Add(this.labelHumidityValue);
            this.Controls.Add(this.labelFeelsLikeTemperature);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelCloudiness);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCurrentDescription);
            this.Controls.Add(this.labelCurrentTemperature);
            this.Controls.Add(this.pictureBoxCurrentIcon);
            this.Location = new System.Drawing.Point(0, 45);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(810, 405);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelCloudiness;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelFeelsLikeTemperature;
        private System.Windows.Forms.Label labelHumidityValue;
        private System.Windows.Forms.Label labelCloudinessValue;
        private System.Windows.Forms.Label labelPressureValue;
        private System.Windows.Forms.Label labelWindSpeedValue;
        private System.Windows.Forms.Label labelFeelsLikeTemperatureValue;
        private System.Windows.Forms.PictureBox pictureBoxCurrentIcon;
        private System.Windows.Forms.Label labelCurrentTemperature;
        private System.Windows.Forms.Label labelCurrentDescription;
        private System.Windows.Forms.PictureBox pictureBoxDetail1;
        private System.Windows.Forms.PictureBox pictureBoxDetail2;
        private System.Windows.Forms.PictureBox pictureBoxDetail3;
        private System.Windows.Forms.PictureBox pictureBoxDetail4;
        private System.Windows.Forms.PictureBox pictureBoxDetail5;

        public System.Windows.Forms.Button Button1
        {
            get { return button1; }
        }

        public System.Windows.Forms.Label LabelCurrentTemperature
        {
            get { return labelCurrentTemperature; }
        }

        public System.Windows.Forms.Label LabelCurrentDescription
        {
            get { return labelCurrentDescription; }
        }

        public System.Windows.Forms.PictureBox PictureBoxCurrentIcon
        {
            get { return pictureBoxCurrentIcon; }
        }
    }
}
