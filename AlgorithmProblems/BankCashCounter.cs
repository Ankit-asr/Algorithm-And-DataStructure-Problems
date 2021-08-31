using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BankCashCounter
    {
        Queue<string> queue = new Queue<string>();
        int bankTotalAmount = 50000;
        public void Bank()
        {
            Console.WriteLine("Number of People");
            int peopleCount = Convert.ToInt16(Console.ReadLine());
            string[] peopleName = new string[peopleCount];
            for (int i = 0; i < peopleCount; i++)
            {
                Console.WriteLine("Enter Person Name");
                string people = Console.ReadLine();
                queue.Enqueue(people);
                peopleName[i] = people;
            }
            while (true)
            {
                if (queue.Size() == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                Console.WriteLine("***********************");
                Console.WriteLine("1 : Deposite Money");
                Console.WriteLine("2 : Withdraw Money");
                Console.WriteLine("3 : Exit");
                Console.WriteLine("***********************");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt16(Console.ReadLine());
                if (choice == 3)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Deposite Amount");
                        int depositeAmount = Convert.ToInt16(Console.ReadLine());
                        bankTotalAmount += depositeAmount;
                        Console.WriteLine("After deposite Amount is :" + bankTotalAmount);
                        queue.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter Withdraw Amount");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > bankTotalAmount)
                        {
                            Console.WriteLine("Balance is not eficient.....");
                        }
                        else
                        {
                            bankTotalAmount -= withdrawAmount;
                            Console.WriteLine("After Withdraw ATM Amount is :" + bankTotalAmount);
                            queue.Dequeue();
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a right choice");
                        break;
                }
            }
        }
    }
}
