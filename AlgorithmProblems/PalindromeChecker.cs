using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class PalindromeChecker
    {
        bool tempCheck = true;
        string name;
        Dequeue<char> deque = new Dequeue<char>();
        public void CheckPalindrome()
        {
            Console.WriteLine("Enter a name");
            name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                deque.AddRare(name[i]);
            }
            for (int i = 0; i < name.Length; i++)
            {
                char dequeChar = deque.RemoveRear();
                if (name[i] != dequeChar)
                {
                    tempCheck = false;
                    break;
                }
            }
            if (tempCheck)
                Console.WriteLine(name + " : is palindrome");
            else
                Console.WriteLine(name + " : is not palindrome");
        }
    }
}
