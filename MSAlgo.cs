using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class MSAlgo
    {
        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
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

        public void Merge(int[] array, int left, int middle, int right)
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
            while (i < n1 && j < n2)
            {
                if (LeftArray[i] <= RightArray[j])
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
            while (i < n1)
            {
                array[k] = LeftArray[i];
                i++;
                k++;
            }
            //Copy any remaining elements of RightArray
            while (j < n2)
            {
                array[k] = RightArray[j];
                j++;
                k++;
            }
        }

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
