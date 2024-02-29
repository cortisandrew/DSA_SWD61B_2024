﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    /// <summary>
    /// The ArrayBasedVector is a data structure
    /// (It is a concrete implementation of the VectorADT, represented by IVectorADT)
    /// To implement the IVectorADT we need to make implementation decisions.
    /// The specific decision here is to store the elements in an Array
    /// (This is why it is called "ArrayBased")
    /// </summary>
    /// <remarks>An alternative way to store the elements is by using a Linked List.</remarks>
    /// <remarks>This is similar to the C# List</remarks>
    public class ArrayBasedVector<T> : IVectorADT<T>
    {
        #region Fields and Constantx
        private int count;

        private T[] V;

        const int DEFAULT_LENGTH = 4;
        #endregion

        public ArrayBasedVector(int arrayLength = DEFAULT_LENGTH)
        {
            count = 0;
            V = new T[arrayLength];
        }

        public void Append(T element)
        {
            InsertAtRank(count, element);
        }

        public int Count()
        {
            return count;
        }

        public T ElementAtRank(int rank)
        {
            // validation step
            if (rank < 0 || rank >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(rank));
            }

            return V[rank];
        }

        public void InsertAtRank(int rank, T element)
        {
            // validation step
            if (rank < 0 || rank > count)
            {
                throw new ArgumentOutOfRangeException(nameof(rank));
            }

            // array is full
            if (V.Length == count) // the number of available spaces in the array is equal to the number of elements
            {
                // the ABV and Vector do not have a limit - we can keep adding elements
                // (in practice up to the memory limit)
                throw new NotImplementedException();
            }

            // starting from i pointing to the LAST element
            // keeping i moving until it arrives at the rank position
            for (int i = count - 1; i >= rank; i--)
            {
                // read V[i]
                // place it in V[i + 1]
                V[i + 1] = V[i];
            }

            // there is an available space at rank
            V[rank] = element;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T RemoveAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public T ReplaceAtRank(int rank, T element)
        {
            throw new NotImplementedException();
        }
    }
}
