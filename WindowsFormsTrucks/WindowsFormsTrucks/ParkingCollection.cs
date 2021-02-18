using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separator = ':';

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
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                    ITransport truck = null;
                    for (int i = 0; (truck = level.Value.GetNext(i)) != null; i++)
                    {
                        if (truck != null)
                        {
                            if (truck.GetType().Name == "Truck")
                            {
                                WriteToFile($"Truck{separator}", fs);
                            }
                            if (truck.GetType().Name == "DumpTruck")
                            {
                                WriteToFile($"DumpTruck{separator}", fs);
                            }
                            WriteToFile(truck + Environment.NewLine, fs);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                parkingStages.Clear();
            }
            else
            {
                return false;
            }
            Vehicle truck = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i].Contains("Parking"))
                {
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(Pic_Width, Pic_Height));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Truck")
                {
                    truck = new Truck(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "DumpTruck")
                {
                    truck = new DumpTruck(strs[i].Split(separator)[1]);
                }
                var result = parkingStages[key] + truck;
                if (!result)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
