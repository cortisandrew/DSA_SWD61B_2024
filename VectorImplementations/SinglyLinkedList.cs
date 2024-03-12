using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class SinglyLinkedList<T>
    {
        public Node<T>? Head { get; internal set; }

        // public Node<T>? Tail { get; internal set; }

        public int Size { get; internal set; } = 0;

        public void InsertFirst(T element)
        {
            // Step 1: Always start with building new items
            // Will work even when Size == 0 (a.k.a. Head is NULL)
            Node<T> newNode = new Node<T>(element, Head);

            // Step 2: Update
            // Careful this can destroy information
            Head = newNode;

            // Step 3: Do not forget to
            Size++;

            // Sometimes you also need to update the Tail
        }

        /// <summary>
        /// Insert Last
        /// </summary>
        /// <param name="element"></param>
        public void Append(T element)
        {
            // In the special case where the linked list is empty
            // Append is the same thing as InsertFirst
            if (Size == 0) // || equivalently Head == null
            {
                InsertFirst(element);
                return;
            }

            // Step 1: Always start with building new items
            Node<T> newNode = new Node<T>(element, null);

            // Step 2: Update
            // 2.a - find the last node in the linked list
            Node<T> tail = GetLastNode();
            // 2.b - update the reference of the last node
            tail.Next = newNode;

            // Step 3
            Size++;
        }

        internal Node<T> GetLastNode()
        {
            Node<T>? cursor = Head;

            if (cursor == null)
            {
                throw new InvalidOperationException("The linked list is empty, so there is no Last Node to retrieve");
            }

            // cursor.Next is equal to NULL Only when the cursor is the last node
            while (cursor.Next != null)
            {
                // the cursor has a Next
                // move forward until you find the last node
                cursor = cursor.Next;
            }

            // cursor.Next == null
            return cursor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // Cursor will be used to go through each and every node in order
            Node<T>? cursor = Head;

            while (cursor != null)
            {
                sb.Append(cursor.Element);
                sb.Append(" -> ");

                // Move the cursor forward by one step
                cursor = cursor.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}
