using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CgpaCalulator cgpa = new Cgpa();
            int[] arr = new int[] { 10, 10, 9, 9, 10 };
            Console.WriteLine(cgpa.getCGPA(arr));
            Console.ReadLine();
        }
    }
    interface CgpaCalulator
    {
        double getCGPA(int []arr);
        string GetPointerCutOffs(string SubjectCode);
    }
    class Cgpa : CgpaCalulator
    {
        public double getCGPA(int []arr)
        {
            float sums = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sums += arr[i];
            }
            Console.WriteLine(sums);
            double cgpa = (sums) / arr.Length;
            Console.WriteLine(arr.Length);
            return cgpa;
        }

        public string GetPointerCutOffs(string SubjectCode)
        {
            Dictionary<int, int> CutOff = new Dictionary<int, int>();
            CutOff.Add(10, 89);
            CutOff.Add(9, 84);
            CutOff.Add(8, 74);
            CutOff.Add(7, 64);
            CutOff.Add(6, 54);
            CutOff.Add(5, 37);
            CutOff.Add(4, 20);
            CutOff.Add(0, 19);
            return CutOff.ToString();
        }
    }
}
