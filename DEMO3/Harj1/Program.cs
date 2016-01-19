using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one Car instance
            Car car = new Car();
            // Console.WriteLine("FuzzyDices = " + car.FuzzyDices);
            // Console.WriteLine("Model = " + car.Model);
            car.Speed = 100;
            car.Color = "Grey";
            car.Engine = 1.0;
            car.FuzzyDices = true;
            car.Model = "Toyota";
            car.PrintData();

            Car nascar = new Car("Mercedes");
           // Console.WriteLine("FuzzyDices = " + nascar.FuzzyDices);
           // Console.WriteLine("Model = " + nascar.Model);
            nascar.Speed = 200;
            nascar.Color = "Matte Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = false;
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();

            Console.ReadLine();
        }
    }
}
