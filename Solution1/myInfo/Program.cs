using System;
using System.Collections.Generic;
using UserName;

namespace myInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            getUsername usr = new getUsername();
            Console.WriteLine(usr.getMyUserName());
            List<School> schools = new List<School>() { new School { Name = "NITK", Rank = 1 }, new School { Name = "Expert", Rank = 2 }};
            School school3 = new School() { Name = "Amratha Bharathi", Rank = 5 };
            schools.Add(school3);
            foreach (School school in schools)
            {
                Console.WriteLine(school.Name);
            }
            Console.ReadLine();
        }
    }
    class School
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        /*public School(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }
        public School (string name)
        {
            Name = name;
        }
        public School (int rank)
        {
            Rank = rank;
        }
        public School()
        {

        }*/

    }
}
