using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinarySearchAlgo
    {
        // Recursive Binary Search
        public int BinarySearch(int[] array, int left, int right, int target)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                // If the element is present at the middle
                if (array[mid] == target)
                    return mid;

                // If the element is smaller than mid, it must be in the left half
                if (array[mid] > target)
                    return BinarySearch(array, left, mid - 1, target);

                // Otherwise, it must be in the right half
                return BinarySearch(array, mid + 1, right, target);
            }

            // If the element is not present in the array
            return -1;
        }

        // Function to print the result of the search
        public void PrintResult(int result, int target)
        {
            if (result == -1)
            {
                Console.WriteLine($"Element {target} is not present in the array.");
            }
            else
            {
                Console.WriteLine($"Element {target} is present at index {result}.");
            }
        }
    }
}
