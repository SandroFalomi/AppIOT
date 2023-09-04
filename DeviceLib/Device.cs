using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace IOTDevice
{
    public class Device
    {
        public string Name { get; set; } 
        public Sensor[] Sensors { get ; set ; }
        public bool Temperature = true;
        public bool Humidity { get; set ; } = false;
        public bool Co2 { get; set; } = false;


        public Device(string[] data)
        {
            this.Name = data[0];
            this.Sensors = new Sensor[int.Parse(data[1])];
            if (data.Length == 4)
            {
                this.Humidity = true;
            }
            if (data.Length == 8)
            {
                this.Humidity = true;
                this.Co2 = true;
            }
            for (int i = 0; i < this.Sensors.Length; i += 1)
            {
                this.Sensors[i] = new Sensor(this); 
            }
            
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "Device Type: " + this.Name + "\nNumber of sensors: " + this.Sensors.Length + "\n" + this.sensorsStamp();
        }

        private string sensorsStamp()
        {
            string tmp = "\n";
            foreach (var sensor in this.Sensors)
            {
                tmp = tmp + sensor.ToString();
            }
            return tmp;
        }
    }
}
