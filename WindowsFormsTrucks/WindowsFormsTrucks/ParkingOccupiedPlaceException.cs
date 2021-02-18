using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrucks
{
    class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException() : base("Не удалось загрузить поезд в депо")
        {}
    }
    //class ParkingOccupiedPlaceException
    //{
    //}
}
