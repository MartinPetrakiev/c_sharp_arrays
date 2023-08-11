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

        public static int[] GetSelectionSortedArray(int[] numbersArray)
        {
            int arrayLength = numbersArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int minNumber = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numbersArray[j] < numbersArray[minNumber])
                    {
                        minNumber = j;
                    }
                }
                var tempVar = numbersArray[minNumber];
                numbersArray[minNumber] = numbersArray[i];
                numbersArray[i] = tempVar;
            }
            return numbersArray;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] myArray = InitializeIntArray(n);
            int[] mySortedArray = GetSelectionSortedArray(myArray);

            foreach (int element in mySortedArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}

/*
Description
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the sorted array
Each number should be on a new line

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
*/