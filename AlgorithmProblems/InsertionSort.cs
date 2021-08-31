using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProblems
{
    class InsertionSort
    {
        string words;
        const string FILEPATH = @"C:\Users\ASR\Desktop\ALGORITHM-PROBLEMS\AlgorithmProblems\WordList.txt";
        public void InsertionSortString()
        {
            Console.WriteLine("");
            words = File.ReadAllText(FILEPATH);
            string[] wordList = words.Split(",");
            for (int i = 1; i < wordList.Length; i++)
            {
                string temp = wordList[i];
                int j = i - 1;
                while (j >= 0 && temp.CompareTo(wordList[j]) == -1)
                {
                    wordList[j + 1] = wordList[j];
                    j = j - 1;
                }
                wordList[j + 1] = temp;
            }
            Console.WriteLine("After insertion sort wordList is :");
            foreach (string word in wordList)
            {
                Console.Write(word + " ");
            }
        }
    }
}
