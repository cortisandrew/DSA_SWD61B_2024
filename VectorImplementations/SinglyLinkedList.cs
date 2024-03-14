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

        public Node<T>? Tail { get; internal set; }

        public int Size { get; internal set; } = 0;

        public void InsertFirst(T element)
        {
            // Step 1: Always start with building new items
            // Will work even when Size == 0 (a.k.a. Head is NULL)
            Node<T> newNode = new Node<T>(element, Head);

            // Sometimes you also need to update the Tail
            if (Size == 0) // equivalent to Head == null
            {
                // the new node is being added to an empty linked list
                Tail = newNode;
            }

            // Step 2: Update
            // Careful this can destroy information
            Head = newNode;

            // Step 3: Do not forget to
            Size++;
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

            // Size is not 0, we have at least 1 node
            // this means (unless we have a bug), that the Tail is not null
            if (Tail == null)
            {
                throw new ApplicationException("This exception should never be thrown! You might have a bug in your implementation!");
            }

            // Step 1: Always start with building new items
            Node<T> newNode = new Node<T>(element, null);

            // Step 2: Update
            // 2.a - find the last node in the linked list
            Node<T> tail = Tail; // Get the previous Tail... //  GetLastNode();
            // 2.b - update the reference of the last node
            tail.Next = newNode; // add the new node AFTER the previous tail

            // The new node has been added to the very end of the linked list
            // This new node is the last node of the linked list
            Tail = newNode; // this new node is the new tail

            // Step 3
            Size++;
        }

        /// <summary>
        /// Prefer to use the Tail rather than go through all the elements
        /// I will leave this code here so that you can recall how we traveresed the linked list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
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

        public T RemoveFirst()
        {
            // Goes to the head of linked list,
            // Removes the head of linked list,
            // Returns the element that has been removed

            if (Size == 0) // || (Head == null) 
            {
                // there are no elements to remove!
                throw new InvalidOperationException("There are no elements to remove!");
            }

            T elementToReturn = Head!.Element;  // Head cannot be null (because of above check). Therefore we added the ! to stop the warning

            // To remove the Head,
            // Change the Head to point to the 2nd item (if any) in the linked list
            Head = Head.Next;
            // Note if Size was 1 at the beginning, now Head should be equal to NULL


            // When do we need to also update the tail?
            // If the new Head is null
            // This means that I have removed ALL of the elements in the list
            // Inlcuding the Tail of list
            Tail = null;

            Size--;
            return elementToReturn;
        }
    }
}
