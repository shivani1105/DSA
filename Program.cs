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



        // Create an instance of Hasher
        Hasher hasher = new Hasher();

        // Add some data to the hash table (dictionary)
        hasher.AddData(101, "Alice");
        hasher.AddData(102, "Bob");
        hasher.AddData(103, "Charlie");
        hasher.AddData(104, "David");

        Console.WriteLine("All Data in the Dictionary:");
        hasher.DisplayAllData();

        Console.WriteLine("\nSearching for key 102:");
        hasher.SearchByKey(102);

        Console.WriteLine("\nSearching for key 105:");
        hasher.SearchByKey(105);


        TwoSumSolution solution = new TwoSumSolution();

        // Example 1: nums = [2,7,11,15], target = 9
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine($"Indices: [{result1[0]}, {result1[1]}]");

        // Example 2: nums = [3,2,4], target = 6
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        Console.WriteLine($"Indices: [{result2[0]}, {result2[1]}]");

        // Example 3: nums = [3,3], target = 6
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        int[] result3 = solution.TwoSum(nums3, target3);
        Console.WriteLine($"Indices: [{result3[0]}, {result3[1]}]");
    }

}