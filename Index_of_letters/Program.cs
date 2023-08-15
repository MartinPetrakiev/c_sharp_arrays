using System;

namespace MyProject
{
    class Program
    {
        static char[] InitializeLowerAZCharArray()
        {
            char[] arr = new char[26];

            for (int i = 0; i < 26; i++)
                arr[i] = (char)(i + 97);

            return arr;
        }

        public static void PrintIndexOfLettersFormAlphabet(string str, char[] array)
        {
            foreach (char c in str)
            {
                Console.WriteLine(Array.IndexOf(array, c));
            }
        }
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            char[] azArray = InitializeLowerAZCharArray();
            PrintIndexOfLettersFormAlphabet(inputWord, azArray);
        }
    }
}

/*
Description
Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.

Input
On the first line you will receive the word

Output
Print the index of each of the word's letters in the array
Each index should be on a new line

Constraints
1 <= word length <= 128
Word is consisted of lowercase english letters
Time limit: 0.1s
Memory limit: 16MB
*/