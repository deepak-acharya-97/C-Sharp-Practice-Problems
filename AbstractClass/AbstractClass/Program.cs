using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeClass rect = new Rectangle(12, 13);
            Console.WriteLine(rect.getArea());
            ShapeClass square = new Square(4);
            Console.WriteLine(square.getArea());
            rect.GetVolume();
            Console.ReadLine();
        }
    }
    abstract class ShapeClass
    {
        public ShapeClass()
        {
            Console.WriteLine("Calling Base Class");
        }
        abstract public double getArea();
        public virtual void GetVolume()
        {
            Console.Write("Printing From Base Class");
        }
    }
    abstract class Rectangle : ShapeClass
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        //public override double getArea()
        //{
        //    return Length * Breadth;
        //}
        public override void GetVolume()
        {
            Console.WriteLine("Calling From Derived Class");
            base.GetVolume();
        }
    }
    class Square : ShapeClass
    {
        public int LengthOfSide { get; set; }

        public Square(int n)
        {
            LengthOfSide = n;
        }
        public override double getArea()
        {
            return LengthOfSide * LengthOfSide;
        }
    }
}
