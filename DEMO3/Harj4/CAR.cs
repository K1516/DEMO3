using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class CAR
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Car Data: ");
            Console.WriteLine("- Name = " + Name);
            Console.WriteLine("- Speed = " + Speed + "km/h");
            Console.WriteLine("- Tyres = " + Tyres + "'");

        }
        public override string ToString()
        {
            return "Name : " + Name + " Speed : " + Speed + " Tyres : " + Tyres;
        }
    }
}
