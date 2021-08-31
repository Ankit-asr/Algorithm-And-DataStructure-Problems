using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class Permutation
    {
        public void PrintPermutation(string str, string ans)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(ans + " ");
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                string ros = str.Substring(0, i) + str.Substring(i + 1);
                PrintPermutation(ros, ans + ch);
            }
        }
    }
}
