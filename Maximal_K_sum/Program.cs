using System;

namespace MyProject
{
    class Program
    {
        static int GetMaxSumOfKElements(int[] arr, int k)
        {
            int[] sortedArray = GetSelectionSortedArrayDescending(arr);
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += sortedArray[i];
            }
            
            return sum;
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

        public static int[] GetSelectionSortedArrayDescending(int[] numbersArray)
        {
            int arrayLength = numbersArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int maxNumber = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numbersArray[j] > numbersArray[maxNumber])
                    {
                        maxNumber = j;
                    }
                }

                var swapNum = numbersArray[maxNumber];
                numbersArray[maxNumber] = numbersArray[i];
                numbersArray[i] = swapNum;
            }

            return numbersArray;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);

            Console.WriteLine(GetMaxSumOfKElements(myArray, k));
        }
    }
}

/*
Description
Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.

Input
On the first line you will receive the number N
On the second line you will receive the number K
On the next N lines the numbers of the array will be given

Output
Print the maximal sum of K elements in the array

Constraints
1 <= N <= 1024
1 <= K <= N
Time limit: 0.1s
Memory limit: 16MB
*/