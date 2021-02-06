using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrucks
{
    public class Parking<T> where T : class, ITransport
    {
        private T[] Depot;
        private int Pic_Width { get; set; }
        private int Pic_Height { get; set; }

        private const int place_Width = 220;
        private const int place_Height = 90;
        public Parking(int sizes, int pic_Width, int pic_Height)
        {
            Depot = new T[sizes];
            Pic_Width = pic_Width;
            Pic_Height = pic_Height;
            for (int i = 0; i < Depot.Length; i++)
            {
                Depot[i] = null;
            }
        }

        public static int operator +(Parking<T> parking, T truck)
        {
            for (int i = 0; i < parking.Depot.Length; i++)
            {
                if (parking.CheckFreePlace(i))
                {
                    parking.Depot[i] = truck;
                    parking.Depot[i].Position(5 + i / 5 * place_Width + 5,
                        i % 5 * place_Height + 5,
                        parking.Pic_Width, parking.Pic_Height);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Parking<T> parking, int index)
        {
            if (index < 0 || index > parking.Depot.Length)
            {
                return null;
            }
            if (!parking.CheckFreePlace(index))
            {
                T truck = parking.Depot[index];
                parking.Depot[index] = null;
                return truck;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return Depot[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < Depot.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    Depot[i].DrawTruck(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < Depot.Length / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * place_Width, j * place_Height,
                    i * place_Width + 150, j * place_Height);
                }
                g.DrawLine(pen, i * place_Width, 0, i * place_Width, 450);
            }
        }
    }
}
