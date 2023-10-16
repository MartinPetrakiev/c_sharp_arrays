using System;

namespace MyProject
{
    class Program
    {
        static int[] InitializeIntArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }

        static string CompareArraysOfSizeN(int[] arrayOne, int[] arrayTwo)
        {
            int size = arrayOne.Length;
            string output = "Equal";

            for (int i = 0; i < size; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    output = "Not equal";
                    break;
                }
            }

            return output;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()!);

            int[] arrayOne = InitializeArray(n);
            int[] arrayTwo = InitializeArray(n);

            Console.WriteLine(CompareArraysOfSizeN(arrayOne, arrayTwo));
        }
    }
}

/*
Description
Write a program that reads two integer arrays of size N from the console and compares them element by element.

Input
On the first line you will receive the number N
On the next N lines the numbers of the first array will be given
On the next N lines the numbers of the second array will be given

Output
Print Equal if the two arrays are the same and Not equal if they are not

Constraints
1 <= N <= 20
N will always be a valid integer number
Time limit: 0.1s
Memory limit: 16MB
*/