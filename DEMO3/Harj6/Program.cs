using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stick stick = new Stick();
            stick.Model = "Exel";
            stick.Flex = 2.5;
            stick.Height = 110;
            stick.Colour = "Red";
            stick.PrintData();
            Console.WriteLine(stick.ToString());

            Stick stick2 = new Stick();
            stick2.Model = "FatPipe";
            stick2.Flex = 3.0;
            stick2.Height = 95;
            stick2.Colour = "Black";
            stick2.PrintData();
            Console.WriteLine(stick2.ToString());

            Console.ReadLine();
        }
    }
}
