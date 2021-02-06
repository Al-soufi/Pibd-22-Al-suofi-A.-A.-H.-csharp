namespace WindowsFormsTrucks
{
    partial class FormTruck
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
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTruck.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(994, 561);
            this.pictureBoxTruck.TabIndex = 0;
            this.pictureBoxTruck.TabStop = false;
            // 
            // Up
            // 
            this.Up.BackgroundImage = global::WindowsFormsTrucks.Properties.Resources.up;
            this.Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Up.Location = new System.Drawing.Point(906, 473);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(35, 35);
            this.Up.TabIndex = 2;
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Move_Click);
            // 
            // Right
            // 
            this.Right.BackgroundImage = global::WindowsFormsTrucks.Properties.Resources.right;
            this.Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Right.Location = new System.Drawing.Point(947, 514);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(35, 35);
            this.Right.TabIndex = 2;
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Move_Click);
            // 
            // Down
            // 
            this.Down.BackgroundImage = global::WindowsFormsTrucks.Properties.Resources.down;
            this.Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Down.Location = new System.Drawing.Point(906, 514);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(35, 35);
            this.Down.TabIndex = 2;
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Move_Click);
            // 
            // Left
            // 
            this.Left.BackgroundImage = global::WindowsFormsTrucks.Properties.Resources.left;
            this.Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Left.Location = new System.Drawing.Point(865, 514);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(35, 35);
            this.Left.TabIndex = 2;
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Move_Click);
            // 
            // FormTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 561);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.pictureBoxTruck);
            this.Name = "FormTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTruck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.ResumeLayout(false);

        }
      
        #endregion
          
        private System.Windows.Forms.PictureBox pictureBoxTruck;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
    }
}

