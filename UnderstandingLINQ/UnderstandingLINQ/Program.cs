using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        class SchoolProgram
        {
            public SortedDictionary<int, List<string>> _roster;
            public SchoolProgram()
            {
                _roster = new SortedDictionary<int, List<string>>();
            }
            public void AddStudent(string cadet,int wave)
            {
                try
                {
                    _roster[wave].Add(cadet);
                }
                catch(Exception e)
                {
                    List<string> temp = new List<string>();
                    temp.Add(cadet);
                    _roster.Add(wave, temp);
                }
            }
            public List<string> Grade(int wave)
            {
                var output = (from KeyValuePair<int, List<string>> obj in _roster where obj.Key == wave orderby obj.Value select obj.Value.ToString()).ToList();
                foreach (var item in output)
                {
                    Console.WriteLine(item.ToString().ToString());
                }
                return output;
            }
            public void Roster()
            {

            }
        }
        
        static void Main(string[] args)
        {
            SchoolProgram sp = new SchoolProgram();
            sp.AddStudent("Deepak Acharya", 1);
            sp.AddStudent("H Sharath Achar", 1);
            sp.AddStudent("Akash Deep", 2);
            sp.AddStudent("Preetham D Bangera", 1);
            foreach (var item in sp._roster)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine(item1);
                }
            }
            Console.ReadLine();
        }
    }
}
