using System;

namespace MyProject
{
    class Program
    {
        static int FindMaxIncreasingSequenceLength(int[] arr)
        {
            int size = arr.Length;
            int previousElement = arr[0];
            int sequenceCounter = 1;
            int maxSequence = 0;
            for (int i = 1; i < size; i++)
            {
                if (arr[i] <= previousElement || i == size - 1)
                {
                    if (sequenceCounter > maxSequence )
                    {
                        maxSequence = sequenceCounter;
                    }
                    previousElement = arr[i];
                    sequenceCounter = 1;
                    continue;
                }
                previousElement = arr[i];
                sequenceCounter++;
                maxSequence = sequenceCounter;
            }
            return maxSequence;
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

            Console.WriteLine(FindMaxIncreasingSequenceLength(myArray));
        }
    }
}

/*
Description
Write a program that finds the length of the maximal increasing sequence in an array of N integers.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the length of the maximal increasing sequence

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/