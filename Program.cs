using DSA;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given array:");
        PrintArray(array);

        //Time Complexity: O(n log n) in all cases (best, average, and worst).
        //Space Complexity: O(n) due to the additional arrays used for merging.
        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);

        int[] array1 = { 10, 7, 8, 9, 1, 5 };

        // Create a new instance of Sorter
        QSAlgo sorter = new QSAlgo();

        Console.WriteLine("Given Array:");
        sorter.PrintArray(array1);

        //Average case:O(n log n)
        //Worst case: O(n²)(when the pivot ends up as the smallest or largest element, resulting in unbalanced partitions)

        // Apply QuickSort
        sorter.QuickSort(array1, 0, array1.Length - 1);

        Console.WriteLine("\nSorted Array:");
        sorter.PrintArray(array1);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if(left < right)
        {
            int middle = (left + right) / 2;

            //sort first half
            MergeSort(array, left, middle);

            //sort second half
            MergeSort(array, middle + 1, right);

            //Merge the sorted halves
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        //lengths of two halves
        int n1 = middle - left + 1;
        int n2 = right - middle;

        //Create temporary arrays
        int[] LeftArray = new int[n1];
        int[] RightArray = new int[n2];

        //Copy data to temporary arrays
        Array.Copy(array, left, LeftArray, 0, n1);
        Array.Copy(array, middle + 1, RightArray, 0, n2);

        //Merge the temporary arrays back into the original array
        int i = 0, j = 0;
        int k = left;
        while(i < n1 && j < n2)
        {
            if(LeftArray[i] <= RightArray[j])
            {
                array[k] = LeftArray[i];
                i++;
            }
            else
            {
                array[k] = RightArray[j];
                j++;
            }
            k++;
        }
        //Copy any remaining elements of LeftArray
        while( i < n1 )
        {
            array[k] = LeftArray[i];
            i++;
            k++;
        }
        //Copy any remaining elements of RightArray
        while( j < n2 )
        {
            array[k] = RightArray[j];
            j++;
            k++;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach(var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}