using System;
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

        private int[] Merge(int[] arr1_sorted, int[] arr2_sorted)
        {
            throw new NotImplementedException();
        }
    }
}
