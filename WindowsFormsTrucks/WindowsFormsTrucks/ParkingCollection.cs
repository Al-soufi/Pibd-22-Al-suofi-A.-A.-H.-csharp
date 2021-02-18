using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrucks
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int Pic_Width;
        private readonly int Pic_Height;

        public ParkingCollection(int pic_Width, int Pic_Height)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.Pic_Width = pic_Width;
            this.Pic_Height = Pic_Height;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }

            parkingStages.Add(name, new Parking<Vehicle>(Pic_Width, Pic_Height));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
