using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProblems
{
    class BinarySearchWordFromWordList
    {
        //variables
        string searchWord, wordList;
        bool checkWorldFound = false;
        //constants
        const string FILEPATH = @"C:\Users\ASR\Desktop\ALGORITHM-PROBLEMS\AlgorithmProblems\WordList.txt";
        /// <summary>
        /// Search specific word found in list or not
        /// </summary>
        public void SearchWorld()
        {
            Console.WriteLine("****************************************");
            wordList = File.ReadAllText(FILEPATH);
            string[] words = wordList.Split(",");
            Console.WriteLine("Enter the word which you want to search ?");
            searchWord = Console.ReadLine();
            foreach (string word in words)
            {
                if (word.Equals(searchWord))
                {
                    Console.WriteLine(searchWord + " : found in list");
                    checkWorldFound = true;
                    break;
                }
            }
            if (checkWorldFound == false)
                Console.WriteLine(searchWord + " : not found in list");
        }
    }
}
