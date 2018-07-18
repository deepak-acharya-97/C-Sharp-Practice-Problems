using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProblem
{
    class Program
    {
        static string EncryptText(string message)
        {
            string output = "";
            for (int i = 0; i < message.Length; i++)
            {
                int AsciiValue = (int)message[i];
                if (AsciiValue >= 65 && AsciiValue <= 90)
                {
                    output += (char)(((int)message[i] + 13 - 65) % 26 + 65);
                }
                else if (AsciiValue >= 97 && AsciiValue <= 122) 
                {
                    output += (char) (((int) message[i] + 13 - 97) % 26 + 97);
                }
                else output += message[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            string encrypt = "The quick brown fox jumps over the lazy dog.";
            string decrypt = EncryptText(encrypt);
            Console.WriteLine(decrypt);
            Console.ReadLine();
        }
    }
}
