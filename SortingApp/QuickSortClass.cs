using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    public class QuickSortClass
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length);
        }

        private static void QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (maxIndex <= minIndex)
            {
                // if max is smaller or equal to min
                // there is only 1 element (or no elements) left to sort
                // we are ready
                return;
            }
            // select a pivot
            // e.g leftmost pivot
            int pivotIndex = minIndex;
            // int pivotValue = array[pivotIndex];

            int pivotIndexAfterPartitioning= Partition(array, pivotIndex, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndexAfterPartitioning - 1);
            QuickSort(array, pivotIndexAfterPartitioning + 1, maxIndex);
        }

        private static int Partition(int[] array, int pivotIndex, int minIndex, int maxIndex)
        {
            throw new NotImplementedException();
        }
    }
}
