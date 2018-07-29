using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Traffic_Violation
{
    class Program
    {
        public static async Task<string> ReadFileAsynchronously(string FilePath)
        {
            StreamReader SRObject = new StreamReader(FilePath);
            string Row;
            int count = 0;
            string[] headers = null;
            JArray arr = new JArray();
            bool Flag = true;
            while((Row = await SRObject.ReadLineAsync()) != null)
            {
                if (Flag)
                {
                    Console.WriteLine(Row);
                    headers = Row.Split(',');
                    Flag = false;
                }
                else
                {
                    string[] RowOfData = Row.Split(',');
                    JObject jObject = new JObject();
                    /*for (int i = 0; i < RowOfData.Length; i++)
                    {
                        jObject[headers[i]] = RowOfData[i];
                    }
                    arr.Add(jObject);*/
                    string[] DoubleQuotedSplit = Row.Split('\"');
                    //Console.WriteLine(Row);
                    //Console.WriteLine("Headers Length = " + headers.Length);
                    //Console.WriteLine("RowOfData Entry = " + RowOfData.Length);
                    //Console.WriteLine("Double Quote = " + DoubleQuotedSplit.Length);
                    //if (count > 10)
                    //{
                    //    break;
                    //}
                    count++;
                    int Length = DoubleQuotedSplit.Length;
                    if (Length != 3 && Length != 5)
                    {
                        Console.WriteLine(Length);
                    }
                    if (Length == 7)
                    {
                        Console.WriteLine(Row);
                        break;
                    }
                    if (Length == 15)
                    {
                        Console.WriteLine(Row);
                        string RowChanged = Row.Replace("\"\"", String.Empty);
                        string[] splitted = RowChanged.Split('\"');
                        Console.WriteLine("Changed" + RowChanged);
                        Console.WriteLine();
                        Console.WriteLine(splitted.Length);
                        break;
                    }
                }
                count++;
            }
            //foreach (JObject item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(count);
            return Row;
        }
        public static async void CallMethod(string FilePath)
        {
            string s = await ReadFileAsynchronously(FilePath);
            //Console.WriteLine(s);
        }
        public static void Main(string[] args)
        {
            CallMethod("C:/Users/Admin/Downloads/Traffic_Violations.csv");
            Console.ReadLine();
        }
    }
}
