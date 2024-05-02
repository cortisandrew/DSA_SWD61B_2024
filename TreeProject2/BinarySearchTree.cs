using System;


namespace TreesProject2
{
    internal class BinarySearchTree<T>
    {
        Node<T>? Root { get; set; }

        public void Add(int key, T element)
        {
            if (Root == null)
            {
                Root = new Node<T>(key, element);
            }
            else
            {
                Root.Add(key, element);
            }
        }

        public T Search(int key) { 

            if (Root == null)
            {
                // The tree is empty!
                throw new KeyNotFoundException();
            }

            return Root.Search(key);
        }

        public bool Contains(int key) {
            if (Root == null)
            {
                // the tree is empty
                // it does not contain the key you are looking for!
                return false;
            }

            return Root.Contains(key);    
        }
    }
}
