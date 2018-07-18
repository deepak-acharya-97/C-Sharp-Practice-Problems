using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            ICheckOut icheckOut = new CheckOutProcess();
            icheckOut.ServeHotDrink();
            p.ServeCoolDrink();
            Console.ReadLine();
        }
    }
    interface ICheckIn
    {
        void ServeCoolDrink();
    }
    interface ICheckOut
    {
        void ServeHotDrink();
    }
    class CheckInProcess : ICheckIn
    {
        public void ServeCoolDrink()
        {
            Console.WriteLine("Serving Apple Juice");
        }
    }
    class CheckOutProcess : ICheckOut
    {
        public void ServeHotDrink()
        {
            Console.WriteLine("Serving Pineapple Juice");
        }
    }
    class Process : ICheckIn, ICheckOut
    {
        public void ServeCoolDrink()
        {
            Console.WriteLine("Serving Juice");
        }
        public void ServeHotDrink()
        {

        }
    }
}
