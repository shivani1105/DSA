using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class QSAlgo
    {
        // Function that implements QuickSort
        public void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partitioning index
                int pi = Partition(array, low, high);

                // Recursively sort elements before and after partition
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        // Function to partition the array
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high]; // Pivot element
            int i = (low - 1); // Index of smaller element

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (array[j] <= pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    Swap(ref array[i], ref array[j]);
                }
            }

            // Swap array[i + 1] and array[high] (or pivot)
            Swap(ref array[i + 1], ref array[high]);

            return i + 1;
        }

        // Function to swap two elements
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Function to print an array
        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
