using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class PrimeNumber
    {
        int lowerlimit, upperlimit;
        bool checkPrime = true;
        public void PrimeNumberInRange()
        {
            Console.WriteLine(" ");
            const int LOWERLIMIT = 0, UPPERLIMIT = 1000;
            Console.WriteLine("Prime number are as listed below :");
            for (int i = LOWERLIMIT; i < UPPERLIMIT; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                if (checkPrime)
                    Console.WriteLine(i);
                checkPrime = true;
            }
        }
    }
}
