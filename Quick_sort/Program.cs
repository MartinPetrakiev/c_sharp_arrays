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

        static void QuickSort(int[] array, int startPosition, int endPosition)
        {
            if (endPosition <= startPosition)
            {
                return;
            }

            int pivotPosition = GetPivotPosition(array, startPosition, endPosition);
            QuickSort(array, startPosition, pivotPosition - 1); //left partition sort
            QuickSort(array, pivotPosition + 1, endPosition); //right partition sort
        }

        static int GetPivotPosition(int[] array, int startPosition, int endPosition)
        {
            int pivot = array[endPosition];
            int pivotPosition = startPosition - 1;
            int temp = 0;

            for (int i = startPosition; i <= endPosition - 1; i++)
            {
                if (array[i] < pivot)
                {
                    pivotPosition++;
                    temp = array[pivotPosition];
                    array[pivotPosition] = array[i];
                    array[i] = temp;
                }
            }

            pivotPosition++;
            temp = array[pivotPosition];
            array[pivotPosition] = array[endPosition];
            array[endPosition] = temp;

            return pivotPosition;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = InitializeIntArray(n);
            QuickSort(myArray, 0, n - 1);

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
/*
Description
Write a program that sorts an array of integers using the Quick sort algorithm.

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