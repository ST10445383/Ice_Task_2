using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_2
{
    class Circle : Shape, IShape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }
}

