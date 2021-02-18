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
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.Take = new System.Windows.Forms.Button();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.labelParking = new System.Windows.Forms.Label();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.Set_Truck = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Sort = new System.Windows.Forms.Button();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.Take);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
            this.groupBoxParking.Controls.Add(this.labelParking);
            this.groupBoxParking.Location = new System.Drawing.Point(1025, 427);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(132, 100);
            this.groupBoxParking.TabIndex = 2;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать машину";
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
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(64, 23);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxParking.TabIndex = 1;
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
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 27);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1000, 560);
            this.pictureBoxParking.TabIndex = 3;
            this.pictureBoxParking.TabStop = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1025, 71);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 40);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить парковку";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1025, 270);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 40);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "удалить парковку";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1007, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1040, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "парковки :";
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.Location = new System.Drawing.Point(1007, 117);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(159, 147);
            this.listBoxParking.TabIndex = 9;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // Set_Truck
            // 
            this.Set_Truck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set_Truck.Location = new System.Drawing.Point(1025, 371);
            this.Set_Truck.Name = "Set_Truck";
            this.Set_Truck.Size = new System.Drawing.Size(117, 50);
            this.Set_Truck.TabIndex = 10;
            this.Set_Truck.Text = "добавить автомобиль";
            this.Set_Truck.UseVisualStyleBackColor = true;
            this.Set_Truck.Click += new System.EventHandler(this.Set_Truck_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1184, 24);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.lodeToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // lodeToolStripMenuItem
            // 
            this.lodeToolStripMenuItem.Name = "lodeToolStripMenuItem";
            this.lodeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.lodeToolStripMenuItem.Text = "Load";
            this.lodeToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(1025, 315);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(117, 50);
            this.Sort.TabIndex = 12;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 591);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Set_Truck);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParking";
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.Button Set_Truck;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lodeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Sort;
    }
}