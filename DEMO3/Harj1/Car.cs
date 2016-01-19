using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj1
{
    class Car
    {
        // fied member

        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }

        // constructor
        public Car()
        {
            FuzzyDices = true;
        }

        // parametric consturctor
        public Car(string model)
        {
            Model = model;
        }
        
        // method displays car data
        public void PrintData()
        {
            Console.WriteLine("Car Data: ");
            Console.WriteLine("- Model : " + Model);
            Console.WriteLine("- Color : " + Color);
            Console.WriteLine("- Engine : " + Engine);
            Console.WriteLine("- Speed : " + Speed);
            Console.WriteLine("- FuzzyDices : " + FuzzyDices);

        }

        // method gives more speed
        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }

    }
}
/* int [] luvut = new int[5];
Student[] students = new Student[5];
students[0] = new Student();
Student student = new Student();
student.Name = "Pekka";
.....
students[0] = student;*/
