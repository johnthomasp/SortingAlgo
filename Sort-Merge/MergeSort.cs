using System;


// Time Complexity - Worst Case O(n log n) Best Case O(n log n) Avergae Case O(n log n)
// Space Complexity - Worst Case O(n) Avergae Case O(n)
namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 89, 54, 99, 21, 45, 11, 32 };
            Console.WriteLine("unsortedlist");
            printList(arr);
            Console.WriteLine("sortedlist");
            Sort(arr, 0, arr.Length - 1);
            printList(arr);
            Console.ReadLine();
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Sort(arr, start, mid);
                Sort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int[] tmpArr = new int[(end - start) + 1];
            int index = 0;

            while ((left <= mid) && (right <= end))
            {
                if (arr[left] < arr[right])
                {
                    tmpArr[index] = arr[left];
                    left++;
                }
                else
                {
                    tmpArr[index] = arr[right];
                    right++;
                }
                index++;
            }

            if (left <= mid)
            {
                while (left <= mid)
                {
                    tmpArr[index] = arr[left];
                    left++;
                    index++;
                }
            }

            if (right <= end)
            {
                while (right <= end)
                {
                    tmpArr[index] = arr[right];
                    right++;
                    index++;
                }
            }

            for (int i = 0; i < tmpArr.Length; i++)
            {
                arr[start + i] = tmpArr[i];
            }
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
    }
}
