using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class QueueUsingSinglyLinkedList<T> : IQueueADT<T>
    {
        private SinglyLinkedList<T> singlyLinkedList = new SinglyLinkedList<T>();

        public int Size => singlyLinkedList.Size;

        public T Dequeue()
        {
            return singlyLinkedList.RemoveFirst();
        }

        public void Enqueue(T element)
        {
            singlyLinkedList.Append(element);
        }

        public T Peek()
        {
            if (singlyLinkedList.Head== null)
            {
                // linked list is empty. No elements to peek at
                throw new InvalidOperationException("No elements in the Queue");
            }
            return singlyLinkedList.Head.Element;
        }
    }
}
