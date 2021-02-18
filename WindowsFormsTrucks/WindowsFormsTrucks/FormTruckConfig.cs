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
    public partial class FormTruckConfig : Form
    {
        Vehicle truck = null;
        private event TruckDelegate eventAddTruck;
        public FormTruckConfig()
        {
            InitializeComponent();
            panelWhite.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;

            Cancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void Draw()
        {
            if (truck != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
                Graphics gr = Graphics.FromImage(bmp);
                truck.Position(10, 10, pictureBoxTruck.Width, pictureBoxTruck.Height);
                truck.DrawTruck(gr);
                pictureBoxTruck.Image = bmp;
            }
        }
        public void AddEvent(TruckDelegate ev)
        {
            if (eventAddTruck == null)
            {
                eventAddTruck = new TruckDelegate(ev);
            }
            else
            {
                eventAddTruck += ev;
            }
        }
        private void labelTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelTruck.DoDragDrop(labelTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelDumpTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelDumpTruck.DoDragDrop(labelDumpTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelTruck_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelTruck_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный автомобиль":
                    truck = new Truck((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Orange, Color.Yellow, checkBoxBody.Checked, checkBoxDesign.Checked);
                    break;
                case "гоночный автомобиль":
                    truck = new DumpTruck((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Blue, checkBoxBody.Checked, checkBoxDesign.Checked);
                    break;
            }
            Draw();
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck != null)
            {
                truck.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck != null)
            {
                truck.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }
        private void Add_Truck_Click(object sender, EventArgs e)
        {
            eventAddTruck?.Invoke(truck);
            Close();
        }
    }
}