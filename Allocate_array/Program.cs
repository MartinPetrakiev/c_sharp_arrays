using System;

namespace MyProject
{
    class Program
    {
        static int[] AllocateArrayOfN(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i * 5;
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] myArray = AllocateArrayOfN(n);

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}

/*
Description
Write a program that allocates an array of N integers, initializes each element by its index multiplied by 5 and then prints the obtained array on the console.

Input
On the only line you will receive the number N

Output
Print the obtained array on the console.
Each number should be on a new line

Constraints
1 <= N <= 20
N will always be a valid integer number
Time limit: 0.1s
Memory limit: 16MB
*/