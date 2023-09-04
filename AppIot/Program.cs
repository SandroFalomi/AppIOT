using IOTDevice;
using System;

namespace AppIot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Device dev = new Device(Utility.ReadConfig());
            dev.Print();
            //dev.Print()
        }
    }
}
