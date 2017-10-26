using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class HeapSort
    {
        private static void Sort(int[] arr)
        {
            int n = arr.Length;
            //Builds Heap
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
            
            //Remove an element(Top) from heap
            for (int i = n - 1; i >= 0; i--)
            {
                //Move current node to end 
                Swap(arr, i , 0);
                //Call to reduce the heap
                Heapify(arr, i, 0);
            }
        }
        
        //Arr = Input, n = size of heap, i = index
        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = (2 * i) + 1;
            int right = (2 * i) + 2;

            if (left < n && arr[left] > arr[largest])
               largest = left;
            
            if (right < n && arr[right] > arr[largest])
                largest = right;

            //if largest is not in the root 
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        private static void Swap(int[] arr, int j, int k)
        {
            int temp = arr[j];
            arr[j] = arr[k];
            arr[k] = temp;
        }

        private static void printList(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 89, 54, 99, 21, 45, 11, 32 };
            Console.WriteLine("unsortedlist");
            printList(arr);
            Console.WriteLine("sortedlist");
            Sort(arr);
            printList(arr);
            Console.ReadLine();
        }
    }
}