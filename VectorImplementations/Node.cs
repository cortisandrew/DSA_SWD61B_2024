using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class Node<T>
    {
        public T Element { get; internal set; }

        /// <summary>
        /// The last node in the linked list will point to null
        /// (Alternative implementations exist, but they are usually more complex. e.g. Intro to Algorithms uses a special node called a Sentinel)
        /// </summary>
        public Node<T>? Next { get; internal set; }

        public Node(T element, Node<T>? next = null)
        {
            this.Element = element;
            this.Next = next;
        }
    }

}
