using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student();

            students[0].Name = "Risto";
            students[0].Age = 21;
            students[0].Hometown = "Rauma";
            students[0].PrintData();

            students[1] = new Student(); 
            students[1].Name = "Ossi";
            students[1].Age = 10;
            students[1].Hometown = "Azerbaizan";
            students[1].PrintData();

            students[2] = new Student();
            students[2].Name = "Peppi";
            students[2].Age = 30;
            students[2].Hometown = "Toijala";
            students[2].PrintData();

            students[3] = new Student();
            students[3].Name = "Niki";
            students[3].Age = 25;
            students[3].Hometown = "Jyväskylä";
            students[3].PrintData();

            students[4] = new Student();
            students[4].Name = "Anna";
            students[4].Age = 18;
            students[4].Hometown = "Oulu";
            students[4].PrintData();

            Console.ReadLine();
        }
    }
}
