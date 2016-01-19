using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Student info");
            Console.WriteLine("- Name = " + Name);
            Console.WriteLine("- Age = " + Age);
            Console.WriteLine("- Hometown = " + Hometown);

        }
    }
}
