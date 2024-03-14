using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class QueueUsingArrayBasedVector<T> : IQueueADT<T>
    {
        private ArrayBasedVector<T> arrayBasedVector;

        public QueueUsingArrayBasedVector(int initialLength = 1000) { 
            arrayBasedVector = new ArrayBasedVector<T>(initialLength);
        }
        public int Size => arrayBasedVector.Count();

        public T Dequeue()
        {
            return arrayBasedVector.RemoveAtRank(arrayBasedVector.Count() - 1);
        }

        public void Enqueue(T element)
        {
            arrayBasedVector.InsertAtRank(0, element); //.Append(element);
        }

        public T Peek()
        {
            return arrayBasedVector.ElementAtRank(0);
        }
    }
}
