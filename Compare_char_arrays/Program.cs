using System;

namespace MyProject
{
    class Program
    {
        static char[] InitializeCharArray(string str)
        {
            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
                arr[i] = str[i];

            return arr;
        }
        static string LexicographicCharArrayComparer(char[] arrayOne, char[] arrayTwo)
        {
            string output = "=";
            int size = Math.Min(arrayOne.Length, arrayTwo.Length);

            if (arrayOne.Length > arrayTwo.Length)
            {
                output = ">";
            }
            if (arrayOne.Length < arrayTwo.Length)
            {
                output = "<";
            }
            if (arrayOne.Length == arrayTwo.Length)
            {
                bool resolved = false;
                for (int i = 0; i < size; i++)
                {
                    if (arrayOne[i] < arrayTwo[i])
                    {
                        output = "<";
                        resolved = true;
                        break;
                    }
                    if (arrayOne[i] > arrayTwo[i])
                    {
                        output = ">";
                        resolved = true;
                        break;
                    }
                }
                if (!resolved)
                {
                    output = "=";
                }
            }

            return output;
        }
        static void Main(string[] args)
        {
            string inputString1 = Console.ReadLine()!;
            string inputString2 = Console.ReadLine()!;

            char[] arrayOne = InitializeCharArray(inputString1);
            char[] arrayTwo = InitializeCharArray(inputString2);

            Console.WriteLine(LexicographicCharArrayComparer(arrayOne, arrayTwo));
        }
    }
}

/*
Description
Write a program that compares two char arrays lexicographically (letter by letter).

Input
On the first line you will receive the first char array as a string
On the second line you will receive the second char array as a string

Output
Print < if the first array is lexicographically smaller
Print > if the second array is lexicographically smaller
Print = if the arrays are equal

Constraints
1 <= size of arrays <= 128
Time limit: 0.1s
Memory limit: 16MB
*/