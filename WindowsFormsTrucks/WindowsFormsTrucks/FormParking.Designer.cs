namespace WindowsFormsTrucks
{
    partial class FormParking
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
            this.ParkingTruck = new System.Windows.Forms.Button();
            this.ParkingDumpTruck = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.labelParking = new System.Windows.Forms.Label();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.Take = new System.Windows.Forms.Button();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // ParkingTruck
            // 
            this.ParkingTruck.Location = new System.Drawing.Point(1079, 12);
            this.ParkingTruck.Name = "ParkingTruck";
            this.ParkingTruck.Size = new System.Drawing.Size(93, 45);
            this.ParkingTruck.TabIndex = 0;
            this.ParkingTruck.Text = "припарковать автомобиль";
            this.ParkingTruck.UseVisualStyleBackColor = true;
            this.ParkingTruck.Click += new System.EventHandler(this.ParkingTruck_Click);
            // 
            // ParkingDumpTruck
            // 
            this.ParkingDumpTruck.Location = new System.Drawing.Point(1079, 75);
            this.ParkingDumpTruck.Name = "ParkingDumpTruck";
            this.ParkingDumpTruck.Size = new System.Drawing.Size(93, 59);
            this.ParkingDumpTruck.TabIndex = 1;
            this.ParkingDumpTruck.Text = "припарковать гоночный автомобиль";
            this.ParkingDumpTruck.UseVisualStyleBackColor = true;
            this.ParkingDumpTruck.Click += new System.EventHandler(this.ParkingDumpTruck_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.Take);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
            this.groupBoxParking.Controls.Add(this.labelParking);
            this.groupBoxParking.Location = new System.Drawing.Point(1040, 154);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(132, 100);
            this.groupBoxParking.TabIndex = 2;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать машину";
            // 
            // labelParking
            // 
            this.labelParking.AutoSize = true;
            this.labelParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParking.Location = new System.Drawing.Point(6, 23);
            this.labelParking.Name = "labelParking";
            this.labelParking.Size = new System.Drawing.Size(52, 16);
            this.labelParking.TabIndex = 0;
            this.labelParking.Text = "Место:";
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(64, 23);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxParking.TabIndex = 1;
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(27, 59);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(75, 23);
            this.Take.TabIndex = 2;
            this.Take.Text = "Забрать";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1000, 560);
            this.pictureBoxParking.TabIndex = 3;
            this.pictureBoxParking.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.ParkingDumpTruck);
            this.Controls.Add(this.ParkingTruck);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParking";
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParkingTruck;
        private System.Windows.Forms.Button ParkingDumpTruck;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.PictureBox pictureBoxParking;
    }
}