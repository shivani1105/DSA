using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class TwoSumSolution
    {
        // Method to find two indices that add up to the target
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> store = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int remainder = target - num;

                // If the remainder exists in the dictionary, return the indices
                if (store.ContainsKey(remainder))
                {
                    return new int[] { store[remainder], i };
                }

                // If remainder doesn't exist, store the current number with its index
                if (!store.ContainsKey(remainder))
                {
                    store[num] = i;
                }
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
