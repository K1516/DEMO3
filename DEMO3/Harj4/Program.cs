using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            CAR car1 = new CAR();
            car1.Name = "Lada";
            car1.Speed = 90;
            car1.Tyres = 13;
            car1.PrintData();
            Console.WriteLine(car1.ToString());

            CAR car2 = new CAR();
            car2.Name = "Mercedes";
            car2.Speed = 250;
            car2.Tyres = 19;
            car2.PrintData();
            Console.WriteLine(car2.ToString());
            Console.ReadLine();
        }
    }
}
