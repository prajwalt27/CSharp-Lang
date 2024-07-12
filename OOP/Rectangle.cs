using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rectangle: Shape
    {
        public double Length { get; set;}

        public double Breadth { get; set;}

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override double Area()
        {
            return Length * Breadth;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The dimensions are length:{Length} and breadth:{Breadth}");
        }
    }
}
