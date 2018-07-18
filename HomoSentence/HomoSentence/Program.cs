using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomoSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabets = "abcdefghijklmnopqrstuvwxys";
            string homo = "The quick brown fox jumps over the lazy dog.".ToLower();
            Dictionary<char, int> mapper = new Dictionary<char, int>();
            for (int i = 0; i < alphabets.Length; i++)
            {
                mapper.Add(alphabets[i], 0);
            }
            for (int i = 0; i < homo.Length; i++)
            {
                try
                {
                    mapper[homo[i]]++;
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
