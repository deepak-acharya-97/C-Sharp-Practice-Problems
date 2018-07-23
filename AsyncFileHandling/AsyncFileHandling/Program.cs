using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AsyncFileHandling
{
    class Program
    {
        static async Task<List<string>> ReadFileContents(string path)
        {
            try
            {
                StreamReader FileContents = new StreamReader(path);
                List<string> ContentsByLine = new List<string>();
                string s;
                while ((s = await FileContents.ReadLineAsync()) != null)
                {
                    ContentsByLine.Add(s);
                }
                return ContentsByLine;
            }
            catch (Exception e) { return new List<string>(); }
        }
        static async Task<string> ReadMapFile(string path)
        {
            StreamReader FileContents = new StreamReader(path);
            string s = await FileContents.ReadToEndAsync();
            return s;
        }
        static async void Hello()
        {
            Task<List<string>> output1 = ReadFileContents("../../" + "big.txt");
            Console.WriteLine(Environment.CurrentDirectory);
            Task<string> output2 = ReadMapFile("../../" + "sample.txt");
            //Console.WriteLine(ReadingDone1.ToArray());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            List<string> ReadingDone1 = await output1;
            Console.WriteLine(ReadingDone1.Count);
            /*foreach (string item in ReadingDone1)
            {
                Console.WriteLine(item);
            }*/
            Console.WriteLine("Done Reading Big File");
            string ReadingDone2 = await output2;
            Console.WriteLine(ReadingDone2.Length);
            //Console.ReadLine();
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Hello();
            Console.ReadLine();
        }
    }
}
