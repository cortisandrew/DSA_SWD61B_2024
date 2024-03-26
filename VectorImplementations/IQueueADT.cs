using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{

    /// <summary>
    /// The Queue is an ADT that implements the operations in this interface. The elements are enqueued and later dequeued in a FIFO order.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueueADT<T>
    {
        int Size { get; }

        void Enqueue(T element);

        T Dequeue();

        T Peek();
    }
}
