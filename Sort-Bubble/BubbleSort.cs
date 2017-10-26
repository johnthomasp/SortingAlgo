using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Time Complexity - Worst Case O(n2) Best Case O(n) Avergae Case O(n2)
//Space Complexity - O(1)
namespace BubbleSort
{
    class BubbleSort
    {
        public static void Sort(int[] list)
        {
            int i, j, temp;

            for (i = 0; i < list.Length; i++)
            {
                for (j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
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
