namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.tB_City = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lab_Condition = new System.Windows.Forms.Label();
            this.lab_Details = new System.Windows.Forms.Label();
            this.lab_Temp = new System.Windows.Forms.Label();
            this.lab_Sunrise = new System.Windows.Forms.Label();
            this.lab_Sunset = new System.Windows.Forms.Label();
            this.lab_WindSpeed = new System.Windows.Forms.Label();
            this.lab_Pressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lab_City = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_City
            // 
            this.tB_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_City.Location = new System.Drawing.Point(103, 31);
            this.tB_City.Name = "tB_City";
            this.tB_City.Size = new System.Drawing.Size(146, 32);
            this.tB_City.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(255, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 38);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lab_Condition
            // 
            this.lab_Condition.AutoSize = true;
            this.lab_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Condition.Location = new System.Drawing.Point(236, 102);
            this.lab_Condition.Name = "lab_Condition";
            this.lab_Condition.Size = new System.Drawing.Size(0, 24);
            this.lab_Condition.TabIndex = 2;
            // 
            // lab_Details
            // 
            this.lab_Details.AutoSize = true;
            this.lab_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Details.Location = new System.Drawing.Point(120, 149);
            this.lab_Details.Name = "lab_Details";
            this.lab_Details.Size = new System.Drawing.Size(0, 24);
            this.lab_Details.TabIndex = 3;
            // 
            // lab_Temp
            // 
            this.lab_Temp.AutoSize = true;
            this.lab_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Temp.Location = new System.Drawing.Point(175, 197);
            this.lab_Temp.Name = "lab_Temp";
            this.lab_Temp.Size = new System.Drawing.Size(0, 24);
            this.lab_Temp.TabIndex = 4;
            // 
            // lab_Sunrise
            // 
            this.lab_Sunrise.AutoSize = true;
            this.lab_Sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunrise.Location = new System.Drawing.Point(130, 240);
            this.lab_Sunrise.Name = "lab_Sunrise";
            this.lab_Sunrise.Size = new System.Drawing.Size(0, 24);
            this.lab_Sunrise.TabIndex = 5;
            // 
            // lab_Sunset
            // 
            this.lab_Sunset.AutoSize = true;
            this.lab_Sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunset.Location = new System.Drawing.Point(120, 287);
            this.lab_Sunset.Name = "lab_Sunset";
            this.lab_Sunset.Size = new System.Drawing.Size(0, 24);
            this.lab_Sunset.TabIndex = 6;
            // 
            // lab_WindSpeed
            // 
            this.lab_WindSpeed.AutoSize = true;
            this.lab_WindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_WindSpeed.Location = new System.Drawing.Point(171, 337);
            this.lab_WindSpeed.Name = "lab_WindSpeed";
            this.lab_WindSpeed.Size = new System.Drawing.Size(0, 24);
            this.lab_WindSpeed.TabIndex = 7;
            // 
            // lab_Pressure
            // 
            this.lab_Pressure.AutoSize = true;
            this.lab_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pressure.Location = new System.Drawing.Point(141, 383);
            this.lab_Pressure.Name = "lab_Pressure";
            this.lab_Pressure.Size = new System.Drawing.Size(0, 24);
            this.lab_Pressure.TabIndex = 8;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(338, 149);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(160, 160);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // lab_City
            // 
            this.lab_City.AutoSize = true;
            this.lab_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_City.Location = new System.Drawing.Point(28, 34);
            this.lab_City.Name = "lab_City";
            this.lab_City.Size = new System.Drawing.Size(61, 26);
            this.lab_City.TabIndex = 10;
            this.lab_City.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weather Condition: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Details: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperature: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sunrise: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sunset: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wind Speed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pressure: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_City);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lab_Pressure);
            this.Controls.Add(this.lab_WindSpeed);
            this.Controls.Add(this.lab_Sunset);
            this.Controls.Add(this.lab_Sunrise);
            this.Controls.Add(this.lab_Temp);
            this.Controls.Add(this.lab_Details);
            this.Controls.Add(this.lab_Condition);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tB_City);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_City;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lab_Condition;
        private System.Windows.Forms.Label lab_Details;
        private System.Windows.Forms.Label lab_Temp;
        private System.Windows.Forms.Label lab_Sunrise;
        private System.Windows.Forms.Label lab_Sunset;
        private System.Windows.Forms.Label lab_WindSpeed;
        private System.Windows.Forms.Label lab_Pressure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lab_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

