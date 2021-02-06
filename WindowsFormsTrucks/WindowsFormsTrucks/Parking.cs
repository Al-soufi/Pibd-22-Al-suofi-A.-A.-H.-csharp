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
        private readonly List<T> Depot;

        private readonly int MaxCount;

        private readonly int Pic_Width;

        private readonly int Pic_Height;

        private const int place_Width = 255;

        private const int place_Height = 90;
        public Parking(int pic_Width, int pic_Height)
        {
            MaxCount = 20;
            Pic_Width = pic_Width;
            Pic_Height = pic_Height;
            Depot = new List<T>();
            for (int i = 0; i < Depot.Count; i++)
            {
                Depot[i] = null;
            }
        }
        public static bool operator +(Parking<T> parking, T truck)
        {
            if (parking.Depot.Count >= parking.MaxCount)
            {
                return false;
            }
            parking.Depot.Add(truck);
            return true;

        }
        public static T operator -(Parking<T> parking, int index)
        {
            if (index < -1 || index > parking.Depot.Count)
            {
                return null;
            }
            T train = parking.Depot[index];
            parking.Depot.RemoveAt(index);
            return train;
        }
        private bool CheckFreeDepot(int index)
        {
            return Depot[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < Depot.Count; i++)
            {
                if (!CheckFreeDepot(i))
                {
                    Depot[i].Position(5 + i / 5 * place_Width + 5, i % 5 * place_Height + 5, Pic_Width, Pic_Height);
                    Depot[i].DrawTruck(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * place_Width, j * place_Height, i * place_Width + 150, j * place_Height);
                }
                g.DrawLine(pen, i * place_Width, 0, i * place_Width, 450);
            }
        }
    }
}
