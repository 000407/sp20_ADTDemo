using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    namespace SeachingDemo {
        class SearchingDemo
        {
            public static void SearchingDemoMain(string[] args)
            {
                BinarySearchDemo();
            }

            private static void LinearSearchDemo() {
                int[] arr = { 10, 4, 9, 3, 2, 1, 5 };

                // Find item 9 in this array
                int key = 9;

                int i = 0;
                for (; i < arr.Length; i++)
                { // Linear search
                    if (arr[i] == key)
                    {
                        Console.WriteLine($"Found: {key} at index {i} after {i + 1} iterations");
                        return;
                    }
                }

                // When the item that's being looked for is at the first of the structure, we have the best performance
                // When the item was not found even after searching up to the last item, we have the worst performance
                // Linear search performance is indicated by O(n) where n is the number of items (Big Oh notation)

                Console.WriteLine($"Not found: {key} after {i} iterations");
            }

            private static void BinarySearchDemo() {
                //int[] arr = { 10, 4, 9, 3, 2, 1, 5 }; 
                int[] arr = { 1, 2, 3, 4, 5, 9, 10 }; // Now it is sorted

                int key = 1;

                int i = 0;
                int upper = arr.Length - 1, lower = 0;
                bool found = false;
                // { 1, 2, 3, 4, 5, 9, 10 }
                while (!found) {
                    i++;
                    int mid = (upper + lower) / 2;

                    if (arr[mid] == key)
                    {
                        Console.WriteLine($"Found: {key} at index {mid} after {i} iterations");
                        return;
                    }
                    else if (upper == lower) 
                    {
                        break;
                    }
                    else if (arr[mid] > key)
                    {
                        upper = mid - 1;
                    }
                    else
                    {
                        lower = mid + 1;
                    }
                }

                // Binary search performance is indicated by O(log n) where n is the number of items (Big Oh notation)

                Console.WriteLine($"Not found: {key} after {i} iterations");
            }
        }
    }
    
}
