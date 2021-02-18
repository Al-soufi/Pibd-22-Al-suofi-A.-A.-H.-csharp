namespace WindowsFormsTrucks
{
    partial class FormTruckConfig
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
            this.groupBoxType_truck = new System.Windows.Forms.GroupBox();
            this.labelDumpTruck = new System.Windows.Forms.Label();
            this.labelTruck = new System.Windows.Forms.Label();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.checkBoxDesign = new System.Windows.Forms.CheckBox();
            this.checkBoxBody = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.All_truck = new System.Windows.Forms.Label();
            this.Max_speed = new System.Windows.Forms.Label();
            this.Add_Truck = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panelTruck = new System.Windows.Forms.Panel();
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.groupBoxType_truck.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType_truck
            // 
            this.groupBoxType_truck.Controls.Add(this.labelDumpTruck);
            this.groupBoxType_truck.Controls.Add(this.labelTruck);
            this.groupBoxType_truck.Location = new System.Drawing.Point(10, 10);
            this.groupBoxType_truck.Name = "groupBoxType_truck";
            this.groupBoxType_truck.Size = new System.Drawing.Size(140, 155);
            this.groupBoxType_truck.TabIndex = 0;
            this.groupBoxType_truck.TabStop = false;
            this.groupBoxType_truck.Text = "Type truck";
            // 
            // labelDumpTruck
            // 
            this.labelDumpTruck.AllowDrop = true;
            this.labelDumpTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDumpTruck.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelDumpTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDumpTruck.Location = new System.Drawing.Point(24, 89);
            this.labelDumpTruck.Name = "labelDumpTruck";
            this.labelDumpTruck.Size = new System.Drawing.Size(107, 51);
            this.labelDumpTruck.TabIndex = 1;
            this.labelDumpTruck.Text = "гоночный автомобиль";
            this.labelDumpTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDumpTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDumpTruck_MouseDown);
            // 
            // labelTruck
            // 
            this.labelTruck.AllowDrop = true;
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTruck.Location = new System.Drawing.Point(24, 16);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(107, 51);
            this.labelTruck.TabIndex = 0;
            this.labelTruck.Text = "Обычный автомобиль";
            this.labelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.checkBoxDesign);
            this.groupBoxMaterial.Controls.Add(this.checkBoxBody);
            this.groupBoxMaterial.Controls.Add(this.numericUpDownWeight);
            this.groupBoxMaterial.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxMaterial.Controls.Add(this.All_truck);
            this.groupBoxMaterial.Controls.Add(this.Max_speed);
            this.groupBoxMaterial.Location = new System.Drawing.Point(10, 170);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(410, 81);
            this.groupBoxMaterial.TabIndex = 1;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // checkBoxDesign
            // 
            this.checkBoxDesign.AutoSize = true;
            this.checkBoxDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesign.Location = new System.Drawing.Point(305, 36);
            this.checkBoxDesign.Name = "checkBoxDesign";
            this.checkBoxDesign.Size = new System.Drawing.Size(73, 22);
            this.checkBoxDesign.TabIndex = 5;
            this.checkBoxDesign.Text = "Design";
            this.checkBoxDesign.UseVisualStyleBackColor = true;
            // 
            // checkBoxBody
            // 
            this.checkBoxBody.AutoSize = true;
            this.checkBoxBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBody.Location = new System.Drawing.Point(305, 15);
            this.checkBoxBody.Name = "checkBoxBody";
            this.checkBoxBody.Size = new System.Drawing.Size(61, 22);
            this.checkBoxBody.TabIndex = 4;
            this.checkBoxBody.Text = "Body";
            this.checkBoxBody.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(225, 20);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(90, 20);
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // All_truck
            // 
            this.All_truck.AutoSize = true;
            this.All_truck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_truck.Location = new System.Drawing.Point(155, 20);
            this.All_truck.Name = "All_truck";
            this.All_truck.Size = new System.Drawing.Size(68, 18);
            this.All_truck.TabIndex = 1;
            this.All_truck.Text = "All truck :";
            // 
            // Max_speed
            // 
            this.Max_speed.AutoSize = true;
            this.Max_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_speed.Location = new System.Drawing.Point(0, 20);
            this.Max_speed.Name = "Max_speed";
            this.Max_speed.Size = new System.Drawing.Size(88, 18);
            this.Max_speed.TabIndex = 0;
            this.Max_speed.Text = "Max speed :";
            // 
            // Add_Truck
            // 
            this.Add_Truck.Location = new System.Drawing.Point(426, 171);
            this.Add_Truck.Name = "Add_Truck";
            this.Add_Truck.Size = new System.Drawing.Size(100, 30);
            this.Add_Truck.TabIndex = 2;
            this.Add_Truck.Text = "Добавить";
            this.Add_Truck.UseVisualStyleBackColor = true;
            this.Add_Truck.Click += new System.EventHandler(this.Add_Truck_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(532, 171);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 30);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // panelTruck
            // 
            this.panelTruck.AllowDrop = true;
            this.panelTruck.Controls.Add(this.pictureBoxTruck);
            this.panelTruck.Location = new System.Drawing.Point(170, 10);
            this.panelTruck.Name = "panelTruck";
            this.panelTruck.Size = new System.Drawing.Size(250, 155);
            this.panelTruck.TabIndex = 4;
            this.panelTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.panelTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTruck.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(230, 130);
            this.pictureBoxTruck.TabIndex = 0;
            this.pictureBoxTruck.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelPink);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(440, 10);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(236, 155);
            this.groupBoxColor.TabIndex = 5;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDopColor.Location = new System.Drawing.Point(144, 20);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(86, 23);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Dop Color";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelMainColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainColor.Location = new System.Drawing.Point(7, 20);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(86, 23);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Main Color";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(190, 101);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 0;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.Location = new System.Drawing.Point(144, 101);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(40, 40);
            this.panelPink.TabIndex = 0;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(98, 101);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(40, 40);
            this.panelPurple.TabIndex = 0;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(52, 101);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(40, 40);
            this.panelGray.TabIndex = 0;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(190, 55);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 0;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(144, 55);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 0;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(98, 55);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 0;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(52, 54);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(6, 55);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 0;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 101);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTruck);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add_Truck);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxType_truck);
            this.Name = "FormTruckConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "выбор машины";
            this.groupBoxType_truck.ResumeLayout(false);
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelTruck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType_truck;
        private System.Windows.Forms.Label labelDumpTruck;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.CheckBox checkBoxDesign;
        private System.Windows.Forms.CheckBox checkBoxBody;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label All_truck;
        private System.Windows.Forms.Label Max_speed;
        private System.Windows.Forms.Button Add_Truck;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panelTruck;
        private System.Windows.Forms.PictureBox pictureBoxTruck;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
    }
}