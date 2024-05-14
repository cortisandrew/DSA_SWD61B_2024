using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples
{
    public class Algorithms
    {
        /// <summary>
        /// The length of the input array is the problem size
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <remarks>
        /// T(n) = 2xT(n/2) + Theta(n)</remarks>
        public int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            // stopping condition
            if (n == 0 || n == 1) { return arr; }

            int halfSize = arr.Length / 2;

            int[] arr1_unsorted = arr.Take(halfSize).ToArray(); // about n/2 length
            int[] arr2_unsorted = arr.Skip(halfSize).Take(n - halfSize).ToArray(); // about n/2 length

            // recursive step
            int[] arr1_sorted = MergeSort(arr1_unsorted);
            int[] arr2_sorted = MergeSort(arr2_unsorted);

            // Theta(n) time
            int[] array_sorted = Merge(arr1_sorted, arr2_sorted);

            return array_sorted;
        }

        /// <summary>
        /// Takes two SORTED arrays, and merges them into one larger SORTED array
        /// </summary>
        /// <param name="arr1_sorted"></param>
        /// <param name="arr2_sorted"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int[] Merge(int[] arr1_sorted, int[] arr2_sorted)
        {
            int n = arr1_sorted.Length + arr2_sorted.Length;

            int[] output = new int[n];

            int i = 0; // the index of the smallest item from arr1 that has not been copied
            int j = 0; // the index of the smallest item from arr2 that has not been copied
            int k = 0; // the next available index to copy to in the output array

            while (i < arr1_sorted.Length && j < arr2_sorted.Length)
            {
                // we still have elements in BOTH arrays
                if (arr1_sorted[i] <= arr2_sorted[j])
                {
                    output[k] = arr1_sorted[i];
                    i++;
                }
                else
                {
                    output[k] = arr2_sorted[j];
                    j++;
                }

                k++;
            }

            // one of the arrays has been copied completely
            // copy all of the remaining elements

            while (i < arr1_sorted.Length)
            {
                // there are still elements from array 1 to be copied
                output[k] = arr1_sorted[i];
                i++;
                k++;
            }

            while (j < arr2_sorted.Length)
            {
                // there are still elements from array 2 to be copied
                output[k] = arr2_sorted[j];
                j++;
                k++;
            }

            return output;
        }

        public void QuickSort(int[] arr)
        {
            // Quicksort the entire array (i.e. from index 0 to index arr.Length - 1
            QuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Quicksort the sub-array between lo and hi
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        private void QuickSort(int[] arr, int lo, int hi)
        {
            // stopping condition
            if (lo >= hi)
            {
                // the range to sort is 1 or less
                return;
            }

            // select a pivot
            int pivotIndex = SelectPivot(lo, hi, arr);
            int newPivotIndex = Partition(arr, pivotIndex);

            // The pivot has now been placed at newPivotIndex. It is now in place
            QuickSort(arr, lo, newPivotIndex - 1); // quicksort the left part, i.e. everything between lo and newPivotIndex - 1
            QuickSort(arr, newPivotIndex + 1, hi); // quicksort the right part, i.e. everything between lo and newPivotIndex - 1
        }

        private int Partition(int[] arr, int pivotIndex)
        {
            // WARNING!
            // 1. you will be using a reference
            // 2. some references tend to be problematic (i.e. in the past Wikipedia code had issues that are hard to debug)
            // 3. Some references use different setups. For example, arrays that start from 1. Some references use different inputs.
            throw new NotImplementedException();
        }

        private int SelectPivot(int lo, int hi, int[] arr)
        {
            return lo;
        }
    }
}
