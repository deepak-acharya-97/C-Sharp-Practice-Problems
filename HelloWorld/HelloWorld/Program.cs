using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Your First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Your Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello, " + firstName + " " + lastName);
            Console.ReadLine();
            for (int ind = 0; ind < 12; ind++)
            {
                if(ind == 10)
                {
                    Console.Write("Ten Found");
                    break;
                }
            }
            Console.WriteLine("For Loop Exited");*/
            /*char[] charArray = new char[] { "A", "B", "C" };
            Console.WriteLine(String.Concat(charArray));
            Console.ReadLine();*/
            string MyString = "deepak";
            Console.WriteLine(MyString.Remove(0, 2));
        }
    }
}
