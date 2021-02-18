using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrucks
{
    public interface ITransport
    {
        void Position(int x, int y, int width, int height);
        void MoveTruck(Direction direction);
        void DrawTruck(Graphics g);
    }
}
