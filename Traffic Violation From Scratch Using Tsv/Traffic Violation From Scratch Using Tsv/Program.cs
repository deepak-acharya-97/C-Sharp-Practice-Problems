using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Traffic_Violation_From_Scratch_Using_Tsv
{
    class Program
    {
        public async static Task<JArray> ReadFileAsyncBro(string FilePath)
        {
            StreamReader sr = new StreamReader(FilePath);
            JArray a = new JArray();
            Console.WriteLine("Started");
            Stopwatch sw = new Stopwatch();
            int SplitBetweenLines = 0;
            sw.Start();
            string s, prev = null;
            string HeaderData = await sr.ReadLineAsync();
            string[] Headers = HeaderData.Split('\t');
            int ViolationTypeIndex = Array.IndexOf(Headers, "Violation Type");
            int YearIndex = Array.IndexOf(Headers, "Year");
            int DateOfStopIndex = Array.IndexOf(Headers, "Date Of Stop");
            Console.WriteLine(DateOfStopIndex);
            int count = 0;
            while((s = await sr.ReadLineAsync()) != null)
            {
                string ViolationType;
                count += 1;
                try
                {
                    if(prev != null)
                    {
                        s = prev + s;
                        //Console.WriteLine("Previous = " + prev);
                        //Console.WriteLine(count+"handled Successfully");
                        prev = null;
                        //Console.WriteLine(s.Split('\t').Length);
                        //Console.WriteLine(s);
                        //Console.WriteLine("Breaking");
                        //break;
                        //Console.WriteLine(s);
                        //break;
                    }
                    string[] splitted = s.Split('\t');
                    //Console.WriteLine(splitted[DateOfStopIndex]);
                    int Year = int.Parse(splitted[DateOfStopIndex].Split('/')[2]);
                    ViolationType = splitted[ViolationTypeIndex];
                    if (Year >= 2013 && Year <= 2015)
                    {
                        ViolationType = splitted[ViolationTypeIndex];
                    }
                    //Console.WriteLine(splitted[YearIndex] + " " + splitted[DateOfStopIndex]);
                    //Console.WriteLine(splitted[ViolationTypeIndex]);
                }
                catch (Exception)
                {
                    //curr = prev + s;
                    //Console.WriteLine(s);
                    //Console.WriteLine(count);
                    SplitBetweenLines += 1;
                    prev = s;
                }
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Split Between Lines = " + SplitBetweenLines);
            Console.WriteLine("Count = " + count);
            Console.WriteLine("Ended");
            //string s = await sr.ReadToEndAsync();
            //try
            //{
            //     a = JArray.Parse(s);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            return a;
        }
        public async static void Readd(string filePath)
        {
            JArray a = await ReadFileAsyncBro(filePath);
            Console.WriteLine(a.Count);
        }
        static void Main(string[] args)
        {
            Readd(@"C:\Users\Admin\Downloads\Traffic_Violations.tsv");
            Console.ReadLine();
        }
    }
}
