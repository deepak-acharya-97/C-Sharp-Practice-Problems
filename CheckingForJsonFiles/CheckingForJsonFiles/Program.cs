using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckingForJsonFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader x = new StreamReader("D:/PYTHON/data.json");
            string s = x.ReadToEnd();
            //Console.WriteLine(s);
            //var result = Regex.Replace(s, @"\\u[\d\w]{4}", String.Empty);
            JArray a = JArray.Parse(s);
            Console.WriteLine(a.Count);
            Console.ReadLine();
        }
    }
}
