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
        // Create a new instance of Sorter
        MergeSortAlgo mergesorter = new MergeSortAlgo();

        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given array:");
        mergesorter.PrintArray(array);

        //Time Complexity: O(n log n) in all cases (best, average, and worst).
        //Space Complexity: O(n) due to the additional arrays used for merging.
        mergesorter.MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("\nAfter Merge sort array:");
        mergesorter.PrintArray(array);



        int[] array1 = { 10, 7, 8, 9, 1, 5 };

        // Create a new instance of Sorter
        QuickSortAlgo quicksorter = new QuickSortAlgo();

        Console.WriteLine("Given Array:");
        quicksorter.PrintArray(array1);

        //Average case:O(n log n)
        //Worst case: O(n²)(when the pivot ends up as the smallest or largest element, resulting in unbalanced partitions)

        // Apply QuickSort
        quicksorter.QuickSort(array1, 0, array1.Length - 1);

        Console.WriteLine("\nAfter Quick sort Array:");
        quicksorter.PrintArray(array1);


        int[] array2 = { 2, 3, 4, 10, 40 };
        int target = 10;

        // Create an instance of Searcher
        BinarySearchAlgo binarySearcher = new BinarySearchAlgo();

        Console.WriteLine("Array:");
        foreach (int num in array2)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Perform Binary Search
        int result = binarySearcher.BinarySearch(array2, 0, array2.Length - 1, target);

        // Print the result
        binarySearcher.PrintResult(result, target);
    }

}