using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesProject
{
    public class Node<T>
    {
        public int Key { get; private set; }

        public T Element { get; private set; }

        // compare the below references to the linked list's:
        // Node<T> Next 
        Node<T>? Left { get; set; }
        Node<T>? Right { get; set; }

        // You could also include a reference to the parent if required
        // Node<T> Parent { get; set; }

        public Node(int key, T Element)
        {
            this.Key = key;
            this.Element = Element;
        }

        internal void Add(int key, T element)
        {
            // if the key received is SMALLER THAN OR EQUAL TO the Key of this instance
            // Place it in the left subtree (to maintain sort-order)
            if (key <= Key)
            {
                if (Left == null)
                {
                    // Found a good space for the new element
                    Left = new Node<T>(key, Element);
                }
                else
                {
                    // Recursive Call
                    Left.Add(key, element);
                }
            }
            else // key > Key
            {
                // the key received is LARGER THAN the key of this instance
                // Place it in the right subtree
                if (Right == null)
                {
                    // Found a good space for the new element
                    Right = new Node<T>(key, element);
                }
                else
                {
                    // Recursive Call
                    Right.Add(key, element);
                }
            }
        }

        internal bool Contains(int key)
        {
            // Key = 40
            // key = 23

            if (key == Key)
            {
                // the key that we are searching for is equal to the Key that this instance has
                return true;
            }

            if (key < Key)
            {
                // we are looking for a key that is SMALLER than the one that this instance has
                // because of the sort-order property, the key (if it exists) has to be in the left subtree

                if (Left == null)
                {
                    // there are no more places to search!
                    return false;
                }
                else
                {
                    // continue your search
                    return Left.Contains(key);
                }
            }
            else // key > Key
            {
                // we are looking for a key that is LARGER than the one that this instance has
                // because of the sort-order property, the key (if it exists) has to be in the right subtree

                if (Right == null)
                {
                    return false;
                }

                // remember to always return the result of your search!
                bool result = Right.Contains(key);
                return result;
            }
        }
    }
}
