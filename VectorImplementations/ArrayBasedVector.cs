using System;
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
        private int count;

        private T[] V;

        const int DEFAULT_LENGTH = 128;
        public ArrayBasedVector(int arrayLength = DEFAULT_LENGTH)
        {
            count = 0;
            V = new T[arrayLength];
        }

        public void Append(T element)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public T ElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public void InsertAtRank(int rank, T element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
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
