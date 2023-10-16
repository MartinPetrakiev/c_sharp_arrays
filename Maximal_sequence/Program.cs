using System;

namespace MyProject
{
    class Program
    {
        static int FindMaxEqualSequenceLength(int[] arr)
        {
            int maxSequence = 1;
            int currentSequenceCounter = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequence)
                    {
                        maxSequence = currentSequenceCounter;
                    }
                }
                else
                {
                    currentSequenceCounter = 1;
                }
            }

            return maxSequence;
        }

        static int[] InitializeIntArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);

            Console.WriteLine(FindMaxEqualSequenceLength(myArray));
        }
    }
}

/*
Description
Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the length of the maximal sequence

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/