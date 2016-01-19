using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj2
{
    class Pesukone
    {
        public string Model { get; set; }
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Speed { get; set; }
        public string Programm { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Pesukone data:");
            Console.WriteLine("- Model = " + Model);
            Console.WriteLine("- IsOn = " + IsOn);
            Console.WriteLine("- Program = " + Programm);
            Console.WriteLine("- Temperature = " + Temperature);
            Console.WriteLine("- Speed = " + Speed);

            Console.ReadLine();
        }
        public override string ToString()
        {
            return "Temperature: " + Temperature + "Program: " + Programm + "Speed: " + Speed + "Model:" + Model;
        }
    }
}
