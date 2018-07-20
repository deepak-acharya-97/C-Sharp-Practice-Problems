using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> FileContents = File.ReadLines(@"D:\C Sharp Assignments\aggregate-gdp-population-csharp-problem-deepakacharyahebri\AggregateGDPPopulation\data\datafile.csv").ToList();
            StreamReader r = new StreamReader(@"C:\Users\Admin\Downloads\country-continent-map.json");
            var json = r.ReadToEnd();
            var jobj = JObject.Parse(json);
            /* https://social.msdn.microsoft.com/Forums/en-US/525ff8f2-13f5-4602-bce3-78b909cadedb/how-to-read-and-write-a-json-file-in-c?forum=csharpgeneral 
             * https://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_Linq_JObject.htm 
             * */
            //Console.WriteLine(FileContents[0]);
            //List<string> FileContentsUpdated = FileContents.Select(i => i.Trim('\"')).ToList();
            string headerText = FileContents[0];
            List<string> headers = headerText.Split(',').ToList();
            foreach (string item in headers)
            {
                Console.WriteLine(item);
            }
            int IndexOfCountry = headers.IndexOf("\"Country Name\"");
            int IndexOfPopulation = headers.IndexOf("\"Population (Millions) 2012\"");
            int IndexOfGDP = headers.IndexOf("\"GDP Billions (USD) 2012\"");
            Console.WriteLine(IndexOfCountry);
            Console.WriteLine(IndexOfPopulation);
            Console.WriteLine(IndexOfGDP);
            //Console.WriteLine(headers.ToString());
            Dictionary<string, float []> JSONObject = new Dictionary<string, float []>();
            for (int i = 1; i < FileContents.Count; i++)
            {
                List<string> RowOfData = FileContents[i].Split(',').ToList();
                string Country = RowOfData[IndexOfCountry].Trim('\"');
                float Population = float.Parse(RowOfData[IndexOfPopulation].Trim('\"'));
                float Gdp = float.Parse(RowOfData[IndexOfGDP].Trim('\"'));
                try
                {
                    string Continent = jobj.GetValue(RowOfData[IndexOfCountry].Trim('\"')).ToString();
                    try
                    {
                        JSONObject[Continent][0] += Gdp;
                        JSONObject[Continent][1] += Population;
                    }
                    catch(Exception e)
                    {
                        float[] info = new float[2];
                        info[0] = Gdp;
                        info[1] = Population;
                        JSONObject.Add(Continent, info);
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(Country);
                }
            }
            foreach (KeyValuePair<string, float[]> item in JSONObject)
            {
                Console.WriteLine(item.Key + " GDP = " + item.Value[0] + " Population = " + item.Value[1]);
            }
            Console.ReadKey();
        }
    }
}
