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
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int place_Width = 210;
        private readonly int place_Height = 85;
        public Parking(int pic_Width, int pic_Height)
        {
            int width = pic_Width / place_Width;
            int height = pic_Height / place_Height;
            MaxCount = width * height;
            pictureWidth = pic_Width;
            pictureHeight = pic_Height;
            Depot = new List<T>();
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
            T truck = parking.Depot[index];
            parking.Depot.RemoveAt(index);
            return truck;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < Depot.Count; i++)
            {
                Depot[i].Position(i / 6 * place_Width, i % 6 * place_Height, pictureWidth, pictureHeight);
                Depot[i].DrawTruck(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / place_Width; i++)
            {
                for (int j = 0; j < pictureHeight / place_Height + 1; ++j)
                {
                    g.DrawLine(pen, i * place_Width, j * place_Height, i * place_Width + 170, j * place_Height);
                }
                g.DrawLine(pen, i * place_Width, 0, i * place_Width, (pictureHeight / place_Height) * place_Height);
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= Depot.Count)
            {
                return null;
            }
            return Depot[index];
        }
    }
}
