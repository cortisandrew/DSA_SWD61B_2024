using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject2
{
    public class HeapSort // descending order!
    {
        public List<int> SortDescending(List<int> unsortedList)
        {
            BinaryMaxHeap<int> heap = new BinaryMaxHeap<int>();

            // n x log(n)
            for (int i = 0; i < unsortedList.Count; i++)
            {
                // repeated n times (one for each item)
                heap.Add(unsortedList[i], unsortedList[i]); // log(n) time
            }

            List<int> output = new List<int>(unsortedList.Count);

            // n x log(n)
            while (heap.Count() > 0)
            {
                // repeated n times
                output.Add(heap.RemoveMax()); // log(n) time
            }

            // total time is O(nxlog(n))
            return output;
        }
    }
}
