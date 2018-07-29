using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TrafficViolationJsonAnalysis
{
    class Program
    {
        static async Task ReadFFile(string path)
        {
            Console.WriteLine("Started Reading");
            StreamReader sr = new StreamReader(path);
            string s = null;
            int count = 0;
            int total = 0;
            JObject a = new JObject();
            int year = 0;
            while((s = await sr.ReadLineAsync())!= null)
            {
                string k = s.Substring(1);
                a= JObject.Parse(k);
                total++;
                try
                {
                    year = int.Parse(a.GetValue("year").ToString());
                    if (year >= 2013 && year <= 2015)
                    {
                        count++;
                    }
                    if (count > 57000)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //break;
                }
                //try
                //{
                //    year = int.Parse(a.GetValue("year").ToString());
                //}
                //catch (Exception) { }
                //try
                //{
                //    if( year >= 2013 && year <= 2015)
                //    {
                //        count++;
                //    }
                //}
                //catch (Exception) { }
            }
            Console.WriteLine(count);
            Console.WriteLine(total);
            Console.WriteLine("Ended Reading");
            //return s;
        }
        static async void RRead()
        {
            Console.WriteLine("Started");
            Task ReadFile1 = ReadFFile(@"D:\PYTHON\DATASET\1.json");
            Task ReadFile2 = ReadFFile(@"D:\PYTHON\DATASET\2.json");
            Task ReadFile3 = ReadFFile(@"D:\PYTHON\DATASET\3.json");
            await ReadFile1;
            await ReadFile2;
            await ReadFile3;
            //Console.WriteLine("Done");
            //JArray a = JArray.Parse(s);
            //foreach (JObject item in a)
            //{
            //    Console.WriteLine(item.GetValue("color"));
            //}
        }
        static void Main(string[] args)
        {
            RRead();
            Console.ReadLine();
        }
    }
}
