using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAwaitInMain
{
    class Program
    {
        async static Task<string> ReadFileAsynchronously(string FilePath)
        {
            StreamReader Str = new StreamReader(FilePath);
            string s = await Str.ReadToEndAsync();
            return s;
        }
        static void Main(string[] args)
        {
            Task<string> s = new Task<string>(ReadFileAsynchronously("D:/output.json"));
            Console.WriteLine("Hi");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
