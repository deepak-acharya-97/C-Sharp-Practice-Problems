using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader s = new StreamReader("D:/output.json1")) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Not Found");
            }
            
            Console.ReadLine();
        }
    }
}
