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
        static int GetMaxSumOfConsecutiveNumbers(int[] arr)
        {
            int size = arr.Length;
            int previousElement = arr[0];
            int currentSum = 0;
            int maxSum = currentSum;

            for (int i = 1; i < size; i++)
            {
                if (arr[i] < previousElement || i == size - 1)
                {
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                    previousElement = arr[i];
                    continue;
                }
                currentSum += arr[i];
                previousElement = arr[i];
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);

            Console.WriteLine(GetMaxSumOfConsecutiveNumbers(myArray));
        }
    }
}

/*
Description
Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
Can you do it with only one loop (with single scan through the elements of the array)?

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the maximal sum of consecutive numbers

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/