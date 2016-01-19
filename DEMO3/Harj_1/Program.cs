using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.Model = "Narvi";
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 95;
            heater.PrintData();
            Console.WriteLine(heater.ToString());

            Console.ReadLine();
        }
    }
}
