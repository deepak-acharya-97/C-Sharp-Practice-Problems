using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\Admin\Downloads\country-continent-map.json");
            var json = r.ReadToEnd();
            var jobj = JObject.Parse(json);
            foreach (var item in jobj.Properties())
            {
                //Console.WriteLine(item.Name);
            }
            Console.WriteLine(jobj.GetValue("India"));
            string jsonString = @"
                Asia: {
                GDP_2012: 0, 
                POPULATION_2012: 0,
                }";
            JObject oo = JObject.Parse(jsonString);
            Console.WriteLine(oo.GetValue("Asia"));
            JObject o = JObject.Parse(json);
            Console.ReadLine();
        }
    }
}
