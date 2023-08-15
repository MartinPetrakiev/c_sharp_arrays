using System;

namespace MyProject
{
    class Program
    {
        static int[] InitializeIntArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            return arr;
        }

        public static void BinarySearch(int[] array, int n, int x)
        {
            int leftElementIndex = 0;
            int rightElementIndex = n - 1;
            int middleElementIndex;
            bool indexFound = false;
            while (leftElementIndex <= rightElementIndex)
            {
                middleElementIndex = (leftElementIndex + rightElementIndex) / 2;
                if (array[middleElementIndex] < x)
                {
                    leftElementIndex = middleElementIndex + 1;
                }
                else if (array[middleElementIndex] > x)
                {
                    rightElementIndex = middleElementIndex - 1;
                }
                else
                {
                    indexFound = true;
                    Console.WriteLine(middleElementIndex);
                    break;
                }
            }
            if (!indexFound)
            {
                Console.WriteLine(-1);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = InitializeIntArray(n);
            int x = Convert.ToInt32(Console.ReadLine());
            BinarySearch(myArray, n, x);
        }
    }
}

/*
Description
Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
On the last line you will receive the number X

Output
Print the index where X is in the array
If there is more than one occurence print the first one
If there are no occurrences print -1

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/