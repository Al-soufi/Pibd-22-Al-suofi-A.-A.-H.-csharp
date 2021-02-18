using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrucks
{
    public abstract class Vehicle : ITransport
    {
        protected float start_X;
        protected float start_Y;
        protected int pic_Width;
        protected int pic_Height;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public Color DopColor { protected set; get; }
        public bool Design { protected set; get; }

        public void Position(int x, int y, int width, int height)
        {
            start_X = x;
            start_Y = y;
            pic_Width = width;
            pic_Height = height;
        }
        public abstract void DrawTruck(Graphics g);
        public abstract void MoveTruck(Direction direction);
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
