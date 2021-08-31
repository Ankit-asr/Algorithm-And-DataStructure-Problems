using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProblems
{
    class BubbleSort
    {
        int length;
        const string FILEPATH = @"C:\Users\ASR\Desktop\ALGORITHM-PROBLEMS\AlgorithmProblems\IntegerList.txt";
        public void BubbleSortInteger()
        {
            Console.WriteLine("");
            string fileData = File.ReadAllText(FILEPATH);
            string[] stringList = fileData.Split(",");
            int[] numberList = new int[stringList.Length];
            for (int i = 0; i < numberList.Length; i++)
            {
                numberList[i] = Convert.ToInt32(stringList[i]);
            }
            length = numberList.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numberList[j] > numberList[j + 1])
                    {
                        int temp = numberList[j];
                        numberList[j] = numberList[j + 1];
                        numberList[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After bubble sorting list is :");
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
