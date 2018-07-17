using System;

namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string MyString = "deepak";
            //Console.WriteLine(MyString.Remove(0, 1));
            DateTime myBirthday = DateTime.Parse("23/10/1996");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            College clg = new College("NITK Surathkal", "A+", 4, "Karnataka");
            clg.print();
            Console.WriteLine(College.WhyIsThisFor());
            Console.ReadLine();
        }
    }
    class College
    {
        public string CollegeName;
        public string Grade;
        public int Rank;
        public string State;

        public College(string collegeName, string grade, int rank, string state)
        {
            CollegeName = collegeName;
            Grade = grade;
            Rank = rank;
            State = state;
        }
        public void print()
        {
            Console.WriteLine("College Name : " + CollegeName +
                "Grade :"+Grade+
                "Rank : )"+Rank.ToString()+
                "State : "+State);
        }
        public static string WhyIsThisFor()
        {
            return "College Class";
        }
    }
}
