using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj_1
{
    class Heater
    {
        public string Model { get; set; }
        public int Temperature { get; set; }
        public bool IsOn { get; set; }
        public int Humidity { get; set; }


        public void PrintData()
        {
            Console.WriteLine(" Heater data: ");
            Console.WriteLine("- IsOn : "+ IsOn);
            Console.WriteLine("- Temperature :{0} ", Temperature);
            Console.WriteLine("- Humidity :{0} ", Humidity);


            Console.ReadLine();
        }

        // method returns heater data
        public override string ToString()
        {
            return "Temperature : " + Temperature + "Humidity : " + Humidity;
        }
    }
}
