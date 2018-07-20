using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram
{
    public class IsogramChecker
    {
            public bool CheckForIsogram(string StringForIsogramCheck)
            {
                Dictionary<char, int> IsogramChecker = new Dictionary<char, int>();
                foreach (char x in StringForIsogramCheck)
                {
                    if (IsogramChecker.ContainsKey(x)) return false;
                    else IsogramChecker.Add(x, 1);
                }
                return true;
            }
        }
}
