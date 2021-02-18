using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrucks
{
    public class Truck : Vehicle
    {
        protected readonly int truckWidth = 210;
        protected readonly int truckHeight = 75;
        public bool Body { private set; get; }
        public Truck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool body, bool design)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Body = body;
            Design = design;
        }
        protected Truck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool design, int truckWidth, int truckHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Design = design;
            this.truckWidth = truckWidth;
            this.truckHeight = truckHeight;
        }
        public override void MoveTruck(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (start_X + step < pic_Width - truckWidth)
                    {
                        start_X += step;
                    }
                    break;
                case Direction.Left:
                    if (start_X - step > 0)
                    {
                        start_X -= step;
                    }
                    break;
                case Direction.Up:
                    if (start_Y - step > 0)
                    {
                        start_Y -= step;
                    }
                    break;
                case Direction.Down:
                    if (start_Y + step < pic_Height - truckHeight)
                    {
                        start_Y += step;
                    }
                    break;
            }
        }
        public override void DrawTruck(Graphics g)
        {
            Brush wil = new SolidBrush(Color.Black);
            g.FillRectangle(wil, start_X + 10, start_Y + 55, 170, 15);
            Brush body = new SolidBrush(DopColor);
            Brush design = new SolidBrush(Color.Gray);
            Brush win = new SolidBrush(Color.White);
            Brush Orang = new SolidBrush(MainColor);
            if (Body)
            {
                //الهيكل
                g.FillRectangle(Orang, start_X + 5, start_Y + 5, 140, 50);
                //هيكل الحاويه
                g.FillRectangle(body, start_X + 5, start_Y + 5, 140, 5);
                g.FillRectangle(body, start_X + 5, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 20, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 35, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 50, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 65, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 80, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 95, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 110, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 125, start_Y + 5, 5, 50);
                g.FillRectangle(body, start_X + 140, start_Y + 5, 5, 50);
            }
            //راس الشاحنه
            g.FillRectangle(body, start_X + 155, start_Y + 10, 50, 50);
            //التوائر
            g.FillEllipse(wil, start_X + 172, start_Y + 55, 19, 20);
            //حدود التوائر
            g.FillEllipse(win, start_X + 14, start_Y + 59, 22, 22);
            g.FillEllipse(win, start_X + 34, start_Y + 59, 22, 22);
            g.FillEllipse(win, start_X + 67, start_Y + 59, 22, 22);
            g.FillEllipse(win, start_X + 89, start_Y + 59, 22, 22);
            g.FillEllipse(win, start_X + 171, start_Y + 59, 22, 22);
            //التوائر
            g.FillEllipse(wil, start_X + 15, start_Y + 60, 20, 20);
            g.FillEllipse(wil, start_X + 35, start_Y + 60, 20, 20);
            g.FillEllipse(wil, start_X + 68, start_Y + 60, 20, 20);
            g.FillEllipse(wil, start_X + 90, start_Y + 60, 20, 20);
            g.FillEllipse(wil, start_X + 172, start_Y + 60, 20, 20);
            if (Design)
            {
                //حدود الطاقات 
                g.FillRectangle(design, start_X + 175, start_Y + 19, 5, 22);
                g.FillRectangle(design, start_X + 164, start_Y + 19, 11, 22);
                g.FillRectangle(design, start_X + 179, start_Y + 19, 22, 27);
                //المدخنه
                g.FillRectangle(design, start_X + 152, start_Y + 10, 2, 37);
                g.FillRectangle(design, start_X + 150, start_Y + 20, 5, 15);
                g.FillRectangle(design, start_X + 148, start_Y + 45, 7, 10);
                //الخزان والثربه
                g.FillRectangle(design, start_X + 117, start_Y + 60, 25, 13);
                //حلقات التوائر الوسط
                g.FillEllipse(design, start_X + 18, start_Y + 63, 14, 14);
                g.FillEllipse(design, start_X + 38, start_Y + 63, 14, 14);
                g.FillEllipse(design, start_X + 71, start_Y + 63, 14, 14);
                g.FillEllipse(design, start_X + 93, start_Y + 63, 14, 14);
                g.FillEllipse(design, start_X + 175, start_Y + 63, 14, 14);
            }
            //الطاقات
            g.FillRectangle(win, start_X + 165, start_Y + 20, 10, 20);
            g.FillRectangle(win, start_X + 180, start_Y + 20, 20, 25);
        }
    }
}
