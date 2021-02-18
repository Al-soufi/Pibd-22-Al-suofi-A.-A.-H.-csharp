using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrucks
{
    public partial class FormTruck : Form
    {
        private ITransport truck;
        public FormTruck()
        {
            InitializeComponent();
        }
        public void SetTruck(ITransport truck)
        {
            this.truck = truck;
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck?.DrawTruck(gr);
            pictureBoxTruck.Image = bmp;
        }
        private void Move_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    truck?.MoveTruck(Direction.Up);
                    break;
                case "Down":
                    truck?.MoveTruck(Direction.Down);
                    break;
                case "Left":
                    truck?.MoveTruck(Direction.Left);
                    break;
                case "Right":
                    truck?.MoveTruck(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
