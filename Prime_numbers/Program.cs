using System;

namespace MyProject
{
    class Program
    {
        static bool[] InitializeBoolArray(int n)
        {
            bool[] arr = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                arr[i] = true;

            return arr;
        }
        static void GetBiggestPrimeUpToN(int n)
        {
            bool[] arr = InitializeBoolArray(n); 
            for (int i = 2; i * i <= n; i++) //i = 2, 3, 4, ..., not exceeding √n
            {
                if (arr[i] == true) 
                {
                    for (int j = i * i; j <= n; j += i) //j = i^2, i^2+i, i^2+2i, i^2+3i, ..., not exceeding n
                    {
                        arr[j] = false;
                    }
                }
            }
            for (int i = n; i > 0; i--)
            {
                if (arr[i] == true)
                {
                    Console.Write(i);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            GetBiggestPrimeUpToN(n);
        }
    }
}
/*
Description
Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

Input
On the first line you will receive the number N

Output
Print the biggest prime number which is <= N

Constraints
2 <= N <= 10 000 000
Time limit: 0.3s
Memory limit: 64MB
*/