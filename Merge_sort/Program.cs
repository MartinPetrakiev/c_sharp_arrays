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
        static void MergeSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                MergeSort(array, leftIndex, midIndex);
                MergeSort(array, midIndex + 1, rightIndex);

                MergeArrays(array, leftIndex, midIndex, rightIndex);
            }
        }

        static void MergeArrays(int[] array, int leftIndex, int midIndex, int rightIndex)
        {
            int leftSize = midIndex - leftIndex + 1;
            int rigthSize = rightIndex - midIndex;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rigthSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = array[leftIndex + i];
            }
            for (int j = 0; j < rigthSize; j++)
            {
                rightArray[j] = array[midIndex + 1 + j];
            }

            int m = leftIndex, r = 0, l = 0; //indecies main array, right and left

            while (l < leftSize && r < rigthSize)
            {
                if (leftArray[l] <= rightArray[r])
                {
                    array[m] = leftArray[l];
                    m++;
                    l++;
                }
                else
                {
                    array[m] = rightArray[r];
                    m++;
                    r++;
                }
            }

            while (l < leftSize)
            {
                array[m] = leftArray[l];
                m++;
                l++;
            }

            while (r < rigthSize)
            {
                array[m] = rightArray[r];
                m++;
                r++;
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = InitializeIntArray(n);
            MergeSort(myArray, 0, n - 1);

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
Write a program that sorts an array of integers using the Merge sort algorithm.

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