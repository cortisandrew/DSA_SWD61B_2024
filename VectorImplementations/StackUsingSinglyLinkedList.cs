using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class StackUsingSinglyLinkedList<T> : IStackADT<T>
    {
        SinglyLinkedList<T> singlyLinkedList = new SinglyLinkedList<T>();

        public int Size => singlyLinkedList.Size;

        public T Peek()
        {
            if (singlyLinkedList.Head == null)
            {
                // linked list is empty. No elements to peek at
                throw new InvalidOperationException("No elements in the Queue");
            }
            return singlyLinkedList.Head.Element;
        }

        public T Pop()
        {
            return singlyLinkedList.RemoveFirst();
        }

        public void Push(T element)
        {
            singlyLinkedList.InsertFirst(element);
        }
    }
}
