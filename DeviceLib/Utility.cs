using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTDevice
{
    public static class Utility
    {
        public static string separator = " ";
        public static string pathConfig = @"C:\Users\sandr\OneDrive\Desktop\IOTdevice\config.txt";
        public static string pathData = @"C:\Users\sandr\OneDrive\Desktop\IOTdevice\data.txt";
        //public static string[] config; 

        //public static void ReadFile()
        //{
        //    config = File.ReadAllText(pathData).Split(separator);        
        //}

        public static string[] ReadConfig()
        {
            return File.ReadAllText(pathConfig).Split("\n");
        }




    }
}
