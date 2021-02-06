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
    public partial class FormParking : Form
    {
        private readonly Parking <ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking <ITransport> (20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void ParkingTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var truck = new Truck(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + truck;
                    Draw();

                }
            }
        }
        private void ParkingDumpTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var truck = new DumpTruck(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + truck;
                    Draw();
                }
            }
        }
        private void Take_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParking.Text != "")
            {
                var truck = parking - Convert.ToInt32(maskedTextBoxParking.Text);
                if (truck != null)
                {
                    {
                        FormTruck form = new FormTruck();
                        form.SetTruck(truck);
                        form.ShowDialog();
                    }
                    Draw();
                }
            }
        }
    }
}
