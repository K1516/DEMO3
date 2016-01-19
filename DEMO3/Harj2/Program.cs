using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.Model = "Rosenlew";
            pesukone.IsOn = true;
            pesukone.Temperature = 60;
            pesukone.Speed = 1000;
            pesukone.Programm = "Valkopesu";
            pesukone.PrintData();

            Console.ReadLine();
        }
    }
}
