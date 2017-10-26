using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Time Complexity - Worst Case O(n2) Best Case O(n2) Avergae Case O(n2)
//Space Complexity - O(1)
namespace SelectionSort
{

    static class SelectionSort
    {
        public static void Sort(int[] list)
        {
            int i, j, minIndex, temp;

            for (i = 0; i < list.Length - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }

                temp = list[minIndex];
                list[minIndex] = list[i];
                list[i] = temp;
            }
        }

        private static void printList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] list = { 6, 4, 9, 0, 5, 1 };
            Sort(list);
            printList(list);
            Console.ReadLine();
        }
    }
}