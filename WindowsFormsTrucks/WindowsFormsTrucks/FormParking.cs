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
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxParking.SelectedIndex;
            listBoxParking.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParking.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParking.Items.Count > 0 && (index == -1 || index >= listBoxParking.Items.Count))
            {
                listBoxParking.SelectedIndex = 0;
            }
            else if (listBoxParking.Items.Count > 0 && index > -1 && index < listBoxParking.Items.Count)
            {
                listBoxParking.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
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
                    if (parkingCollection[listBoxParking.SelectedItem.ToString()] + truck)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    if (parkingCollection[listBoxParking.SelectedItem.ToString()] + truck)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Take_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1 && maskedTextBoxParking.Text != "")
            {
                var truck = parkingCollection[listBoxParking.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxParking.Text);
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
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxName.Text);
            ReloadLevels();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(textBoxName.Text);
                    ReloadLevels();
                }
            }
        }
        private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
