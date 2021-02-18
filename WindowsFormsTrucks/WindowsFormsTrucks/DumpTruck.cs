using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrucks
{
    public class DumpTruck : Truck
    {
        public bool Back { private set; get; }
        public DumpTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool back, bool design)
            : base(maxSpeed, weight, mainColor, dopColor,design, 210, 75)
        {
            Back = back;
        }
        public DumpTruck(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Design = Convert.ToBoolean(strs[5]);    
                Back = Convert.ToBoolean(strs[6]);
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{Back}";
        }
        public override void DrawTruck(Graphics g)
        {
            Brush black = new SolidBrush(Color.Black);
            Brush mianc = new SolidBrush(MainColor);
            Brush line = new SolidBrush(Color.Red);
            if (Back)
            {
                g.FillRectangle(black, start_X + 29, start_Y + 5, 95, 5);
                g.FillEllipse(black, start_X + 83, start_Y + 5, 62, 50);
                g.FillEllipse(black, start_X + 5, start_Y + 5, 62, 50);
                g.FillRectangle(black, start_X + 6, start_Y + 35, 138, 35);

                g.FillEllipse(mianc, start_X + 82, start_Y + 5, 62, 50);
                g.FillRectangle(mianc, start_X + 45, start_Y + 6, 80, 49);
                g.FillEllipse(mianc, start_X + 6, start_Y + 5, 62, 50);

                g.FillRectangle(line, start_X + 7, start_Y + 27, 137, 9);
            }
            base.DrawTruck(g);
        }
    }
}