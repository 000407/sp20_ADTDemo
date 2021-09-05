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
            int[] arr1 = { 10, 4, 9, 3, 2, 1, 5 };
            BubbleSortDemo(arr1);

            int[] arr2 = { 6, 4, 9, 3, 2, 1, 5, 10, 9 };
            BubbleSortDemo(arr2);

            arr1 = new int[] { 10, 4, 9, 3, 2, 1, 5 };
            SelectionSortDemo(arr1);

            arr2 = new int[] { 6, 4, 9, 3, 2, 1, 5, 10, 9 };
            SelectionSortDemo(arr2);
        }

        private static void BubbleSortDemo(int[] arr)
        {
            PrintArray("BUBBLE SORT BEFORE:  ", arr);
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

            PrintArray("BUBBLE SORT AFTER:   ", arr);
        }

        private static void SelectionSortDemo(int[] arr)
        {
            PrintArray("SELECTION SORT BEFORE:  ", arr);
            // Sorting with selection sort, in the ascending order
            for (int i = 0; i < arr.Length; i++)
            {
                int leastIndex = i; // The index that has the smallest element of the unsorted array
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[leastIndex])
                    {
                        leastIndex = j;
                    }
                }

                // Swap the item at the least index with the beginning of the unsorted array
                int tmp = arr[i];
                arr[i] = arr[leastIndex];
                arr[leastIndex] = tmp;
            }
            PrintArray("SELECTION SORT AFTER:   ", arr);
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
