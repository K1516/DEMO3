using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj6
{
    class Stick
    {
        public string Model { get; set; }
        public double Flex { get; set; }
        public int Height { get; set; }
        public string Colour { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Stick Data");
            Console.WriteLine("- Model = " + Model);
            Console.WriteLine("- Flex = " + Flex);
            Console.WriteLine("- Height = " + Height);
            Console.WriteLine("- Grip Colour = " + Colour);
        }
        public override string ToString()
        {
            return "Model : " + Model + " Flex : " + Flex + " Height : " + Height + " Colour : " + Colour;
        }
    }
}
