using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB5
{
    public static class InsertionSortingArray
    {
        public static void Swap(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        public static void Sort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    Swap(arr, j, j - 1);
                }
            }
        }

        public static void Display(int[] arr, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
