using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace IOTDevice
{
    public class Sensor
    {
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public int Co2 { get; set; }

        public Sensor(Device x)
        { 
            Random rand = new Random();
            this.Temperature = rand.Next(-20, 50);
            if (x.Humidity == true)
                this.Humidity = rand.Next(100);
            else
                this.Humidity = 0;
            if(x.Co2 == true)
                this.Co2 = rand.Next(100);
            else
                this.Co2 = 0;
        }

        public override string ToString()
        {
            return "Temperature: " + this.Temperature + "\nHumidity: " + this.Humidity + "\nCo2: " + this.Co2 + "\n";
        }
    }
}
