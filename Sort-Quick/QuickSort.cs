using System;

// Time Complexity - Worst Case O(n2) Best Case O(n log n) Avergae Case O(n log n)
// Space Complexity - Worst Case O(n) Avergae Case O(log n)

namespace QuickSort
{
    class QuickSort
    {
        public static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int q = partition(arr, start, end);
                Sort(arr, start, q - 1);
                Sort(arr, q + 1, end);
            }
        }

        private static int partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, end);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static void printList(int[] arr)
        {
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Empty Array");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = {89, 54, 99, 21, 45, 11, 32};
            Console.WriteLine("Unsorted List");
            printList(arr);
            Sort(arr, 0, arr.Length-1);
            Console.WriteLine("\nSorted List");
            printList(arr);
            Console.ReadLine();
        }
    }
}