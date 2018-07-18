using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallonExample
{
    class Ballon
    {
        public string Color;
        public Ballon(string color)
        {
            color = Color;
        }
    }
    
    class Program
    {
        static void Swap(Object o1, Object o2)
        {
            Object temp = o1;
            o1 = o2;
            o2 = temp;
        }
        static void Main(string[] args)
        {
            Ballon red = new Ballon("red");
            Ballon blue = new Ballon("blue");
            Swap(red, blue);
            Console.WriteLine(red.Color + " " + blue.Color);
            Console.ReadLine();
        }
    }
}
