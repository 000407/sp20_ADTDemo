using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    
    class SortingDemo
    {
        public static void SortingDemoMain(string[] args)
        {
            int[] arr = { 10, 4, 9, 3, 2, 1, 5 };
            BubbleSortDemo(arr);

            int[] arr2 = { 6, 4, 9, 3, 2, 1, 5, 10, 9 };
            BubbleSortDemo(arr2);
        }

        private static void BubbleSortDemo(int[] arr)
        {
            PrintArray("BEFORE:  ", arr);
            // Sorting with bubble sort, in the ascending order
            for (int i = 0; i < arr.Length; i++) {
                bool swapped = false;
                for (int j = 1; j < arr.Length - i; j++) {
                    if (arr[j - 1] > arr[j]) {
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;

                        swapped = true;
                    }               
                }

                if (!swapped) {
                    break;
                }
            }

            PrintArray("AFTER:   ", arr);
        }

        private static void PrintArray(string prefix, int[] arr)
        {
            Console.Write(prefix);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
