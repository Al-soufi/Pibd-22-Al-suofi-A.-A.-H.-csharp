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
        private Truck truck;
        public FormTruck()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck.DrawTruck(gr);
            pictureBoxTruck.Image = bmp;
        }
        private void Create_Truck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new Truck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Orange, Color.Yellow, true, true);
            truck.Position(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTruck.Width,
           pictureBoxTruck.Height);
            Draw();
        }
        private void Move_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    truck.MoveTruck(Direction.Up);
                    break;
                case "Down":
                    truck.MoveTruck(Direction.Down);
                    break;
                case "Left":
                    truck.MoveTruck(Direction.Left);
                    break;
                case "Right":
                    truck.MoveTruck(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
