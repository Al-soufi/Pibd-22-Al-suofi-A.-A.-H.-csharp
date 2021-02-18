using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrucks
{
    public class TruckComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is DumpTruck && y is Truck)
            {
                return -1;
            }
            if (x is Truck && y is DumpTruck)
            {
                return 1;
            }
            if (x is DumpTruck && y is DumpTruck)
            {
                return ComparerDumpTruck((DumpTruck)x, (DumpTruck)y);
            }
            if (x is Truck && y is Truck)
            {
                return ComparerTruck((Truck)x, (Truck)y);
            }
            return 0;
        }
        private int ComparerTruck(Truck x, Truck y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Design != y.Design)
            {
                return x.Design.CompareTo(y.Design);
            }
            if (x.Body != y.Body)
            {
                return x.Body.CompareTo(y.Body);
            }
            return 0;
        }
        private int ComparerDumpTruck(DumpTruck x, DumpTruck y)
        {
            var res = ComparerTruck(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.Back != y.Back)
            {
                return x.Back.CompareTo(y.Back);
            }
            return 0;
        }
    }
}
