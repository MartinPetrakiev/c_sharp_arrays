using System;

namespace MyProject
{
    class Program
    {
        static int[] PopulateArrayFromInput(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }

        static void FindMinimalRemovalsToSort(int[] array)
        {
            int n = array.Length;
            int maxIncreasingSequence = FindMaxIncreasingSequenceLength(array, n);
            int minimalRemovals = n - maxIncreasingSequence;

            Console.WriteLine(minimalRemovals);
        }

        static int FindMaxIncreasingSequenceLength(int[] array, int n)
        {
            int[] sequencesCount = new int[n];

            for (int i = 0; i < n; i++)
            {
                sequencesCount[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] >= array[j] && sequencesCount[i] < sequencesCount[j])
                    {
                        sequencesCount[i] = sequencesCount[j] + 1;
                    }
                }
            }

            int maxLength = 0;
            for (int i = 0; i < n; i++)
            {
                if (sequencesCount[i] > maxLength)
                {
                    maxLength = sequencesCount[i];
                }
            }
            
            return maxLength;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] myArray = PopulateArrayFromInput(n);

            FindMinimalRemovalsToSort(myArray);
        }
    }
}

/*
Description
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order. Print the minimal number of elements that need to be removed in order for the array to become sorted.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the minimal number of elements that need to be removed

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/