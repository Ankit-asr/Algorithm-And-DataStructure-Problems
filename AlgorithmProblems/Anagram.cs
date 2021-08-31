using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class Anagram
    {
        string stringValue1, stringValue2;
        public void AnagramDetection()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter first string");
            stringValue1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            stringValue2 = Console.ReadLine();
            if (stringValue1.Length != stringValue2.Length)
            {
                Console.WriteLine(stringValue1 + " And " + stringValue2 + " are not anagram");
            }
            else
            {
                char[] stringCharArray1 = stringValue1.ToCharArray();
                char[] stringCharArray2 = stringValue2.ToCharArray();
                Array.Sort(stringCharArray1);
                Array.Sort(stringCharArray2);
                string tempStringValue1 = stringCharArray1.ToString();
                string tempStringValue2 = stringCharArray2.ToString();
                if (tempStringValue1.Equals(tempStringValue2))
                {
                    Console.WriteLine(stringValue1 + " And " + stringValue2 + " are anagram");
                }
                else
                {
                    Console.WriteLine(stringValue1 + " And " + stringValue2 + " are not anagram");
                }
            }

        }
    }
}
