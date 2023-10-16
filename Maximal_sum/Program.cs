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
            int maxSumToCurrentPosition = arr[0];
            int maxSumConsecutive = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxSumToCurrentPosition + arr[i])
                {
                    maxSumToCurrentPosition = arr[i];
                }
                else
                {
                    maxSumToCurrentPosition = maxSumToCurrentPosition + arr[i];
                }

                if (maxSumToCurrentPosition > maxSumConsecutive)
                {
                    maxSumConsecutive = maxSumToCurrentPosition;
                }
            }
            return maxSumConsecutive;
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