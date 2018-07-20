using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomoAlphabetic
{
    class Program
    {
        static void pass(string s)
        {
            Console.WriteLine(s.ToLower());
        }
        static void Main(string[] args)
        {
            string S = "\"Five quacking Zephyrs jolt my wax bed.\"";
            pass(S);
            int previous=97;
            char []CharacterArray = S.ToCharArray();
            List<char> SortedList = S.OrderBy(x => x).ToList();
            foreach(char a in SortedList)
            {
                int AsciiValue = a;
                if (AsciiValue < 97) continue;
                if (AsciiValue > 122) break;
                if(AsciiValue!=previous && AsciiValue != previous + 1)
                {
                    Console.WriteLine(AsciiValue+previous);
                    Console.WriteLine("Condition Failed");
                    break;
                }
                previous = AsciiValue;
            }
            Console.WriteLine("Yay");
            Console.ReadLine();
        }
    }
}
