using System;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            const int PERMUTATION_OF_STRING = 1, BINARY_SEARCH_WORD = 2, INSERTION_SORT = 3, BUBBLE_SORT = 4, ANAGRAM = 5, PRIME_NUMBER = 6, PRIME_ANAGRAM_PALINDROME = 7, UNORDERED_LIST = 8, ORDERED_LIST = 9, BALANCED_PARENTHESES = 10, BANKCASH = 11, PALINDROME_CHECKER = 12;
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("Press 1 for Permutation");
                Console.WriteLine("Press 2 for Binary Search");
                Console.WriteLine("Press 3 for Insertion Sort");
                Console.WriteLine("Press 4 for Bubble Sort");
                Console.WriteLine("Press 5 for Anagram Detection Example");
                Console.WriteLine("Press 6 for Prime Number");
                Console.WriteLine("Press 7 for Prime Number that are Palindrome and Anagram");
                Console.WriteLine("Press 8 for Unordered List");
                Console.WriteLine("Press 9 for Ordered List");
                Console.WriteLine("Press 10 for Balanced Parentheses");
                Console.WriteLine("Press 11 for Banking Cash Counter");
                Console.WriteLine("Press 12 for Palindrome checker");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case PERMUTATION_OF_STRING:
                        Permutation permutation = new Permutation();
                        Console.WriteLine("Enter a string");
                        string stringPermutation = Console.ReadLine();
                        permutation.PrintPermutation(stringPermutation, "");
                        break;
                    case BINARY_SEARCH_WORD:
                        BinarySearchWordFromWordList searchWorldFromWorldList = new BinarySearchWordFromWordList();
                        searchWorldFromWorldList.SearchWorld();
                        break;
                    case INSERTION_SORT:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.InsertionSortString();
                        break;
                    case BUBBLE_SORT:
                        BubbleSort bubble = new BubbleSort();
                        bubble.BubbleSortInteger();
                        break;
                    case ANAGRAM:
                        Anagram anagram = new Anagram();
                        anagram.AnagramDetection();
                        break;
                    case PRIME_NUMBER:
                        PrimeNumber primenumber = new PrimeNumber();
                        primenumber.PrimeNumberInRange();
                        break;
                    case PRIME_ANAGRAM_PALINDROME:
                        PrimeAnagramPalindrome pap = new PrimeAnagramPalindrome();
                        pap.PrimePalindromeAnagram();
                        break;
                    case UNORDERED_LIST:
                        UnorderedList unorderedlist = new UnorderedList();
                        unorderedlist.Unordered();
                        break;
                    case ORDERED_LIST:
                        OrderedList orderlist = new OrderedList();
                        orderlist.Ordered();
                        break;
                    case BALANCED_PARENTHESES:
                        BalancedParentheses balancedparentheses = new BalancedParentheses();
                        balancedparentheses.CheckBalancedParentheses();
                        break;
                    case BANKCASH:
                        BankCashCounter bankingcashcounter = new BankCashCounter();
                        bankingcashcounter.Bank();
                        break;
                    case PALINDROME_CHECKER:
                        PalindromeChecker palindromechecker = new PalindromeChecker();
                        palindromechecker.CheckPalindrome();
                        break;
                    default:
                        Console.WriteLine("Enter a right choice");
                        break;
                }
                Console.WriteLine("Press Y or y to continue");
                char choiceContinue = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (choiceContinue != 'y')
                    break;
            }
        }
    }
}
