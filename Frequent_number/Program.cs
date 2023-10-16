using System;

namespace MyProject
{
    class Program
    {
        static string FindMostFrequentNumber(int[] arr)
        {
            Dictionary<int, int> numberOccurances = new Dictionary<int, int>();

            foreach (int element in arr)
            {
                if (numberOccurances.ContainsKey(element))
                {
                    numberOccurances[element]++;
                }
                else
                {
                    numberOccurances[element] = 1;
                }
            }
            
            int mostOccurence = 0;
            int mostFrequentNum = 0;

            foreach (int key in numberOccurances.Keys)
            {
                if (mostOccurence < numberOccurances[key])
                {
                    mostFrequentNum = key;
                    mostOccurence = numberOccurances[key];
                }
            }
            return $"{mostFrequentNum} ({mostOccurence} times)";
        }
        static int[] InitializeIntArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            return arr;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);

            Console.WriteLine(FindMostFrequentNumber(myArray));
        }
    }
}

/*
Description
Write a program that finds the most frequent number in an array of N elements.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the most frequent number and how many time it is repeated
Output should be REPEATING_NUMBER (REPEATED_TIMES times)

Constraints
1 <= N <= 1024
0 <= each number in the array <= 10000
There will be only one most frequent number
Time limit: 0.1s
Memory limit: 16MB
*/