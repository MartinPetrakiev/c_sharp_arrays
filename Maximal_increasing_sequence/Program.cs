using System;

namespace MyProject
{
    class Program
    {
        static int FindMaxIncreasingSequenceLength(int[] arr, int n)
        {
            int[] sequencesCount = new int[n];

            for (int i = 0; i < n; i++)
            {
                sequencesCount[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] >= array[j])
                    {
                        sequencesCount[i] = Math.Max(sequencesCount[i], sequencesCount[j] + 1);
                    }
                }
            }

            int maxLength = sequencesCount.Max();
            return maxLength;
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

            Console.WriteLine(FindMaxIncreasingSequenceLength(myArray, n));
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