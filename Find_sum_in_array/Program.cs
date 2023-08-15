using System;
using System.Collections.Generic;

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
        static void FindSubsetInArrayAddingToGivenSum(int[] array, int n, int sum)
        {
            int currentSum = 0;
            int iterator = 0;
            bool sumFound = false;
            List<int> subset = new List<int>();
            for (int i = 0; i < n; i++)
            {
                currentSum = 0;
                subset.Clear();
                for (int j = iterator; j < n; j++)
                {
                    currentSum += array[j];
                    subset.Add(array[j]);
                    if (currentSum == sum)
                    {
                        sumFound = true;
                        foreach (int num in subset)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    }
                }
                if (sumFound)
                {
                    break;
                }
                iterator++;
            }

            if (!sumFound)
            {
                Console.WriteLine("No Subset Adds To Sum");
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);

            FindGivenSumSequenceOfIntsInArray(myArray, n, s);
        }
    }
}

/*
Description
Write a program that finds in a given array of integers with length N a sequence of given
sum S (if present).

Input
● On the first line you will receive the number N
● On the second line you will receive the number S
● On the next N lines the numbers of the array will be given

Output
● Print the sequence. Each element on a new line
● Print “No Subset Adds To Sum” if there is no subset that adds up to the
requested sum

Constraints
● 1 <= N <= 1024
● 0 <= each number in the array <= 10000
● Only 1 sequence in the array should add up to the required sum
● Time limit: 0.1s
● Memory limit: 16MB
*/