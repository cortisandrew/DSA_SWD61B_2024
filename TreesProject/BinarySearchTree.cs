﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesProject
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
            //Root.Search(key)
            throw new NotImplementedException();}

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
