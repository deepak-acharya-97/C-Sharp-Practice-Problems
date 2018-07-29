using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_Splitting
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Deepak Acharya ### abc,bbc";
            string[] st = s.Split(new[] { "###", "," }, StringSplitOptions.RemoveEmptyEntries);
            string DoubleQuoteIrudu = "Deepak Acharya,97,89,94,100,100,100,\"Hebri, Karnataka, India\"";
            string[] SplitString = Regex.Split(DoubleQuoteIrudu,"\"[a-zA-Z, ]+\"");
            foreach (var i in SplitString)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
