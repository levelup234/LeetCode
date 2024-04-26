using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC242E_Anagram
{
    public class AnagramChecker
    {
        public bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            char[] charArrayStr1 = str1.ToCharArray();
            char[] charArrayStr2 = str2.ToCharArray();
            Array.Sort(charArrayStr1);
            Array.Sort(charArrayStr2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (charArrayStr1[i] != charArrayStr2[i]) 
                    return false;
            }

            return true;
        }
    }
}
