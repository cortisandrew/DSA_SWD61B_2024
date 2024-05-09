using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject2
{
    public class PriorityQueue<T>
    {
        BinaryMaxHeap<T> heap = new BinaryMaxHeap<T>();
        public PriorityQueue() { }


        public void Enqueue(int priority, T item)
        {
            heap.Add(priority, item);
        }

        public T DequeueHighestPriority()
        {
            return heap.RemoveMax();
        }

        public int Count()
        {
            return heap.Count();
        }

    }
}
