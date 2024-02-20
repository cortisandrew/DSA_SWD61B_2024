using System;
using System.Collections.Generic;

namespace VectorImplementations {
    /// <summary>
    /// IVectorADT represents and ordered sequence of elements
    /// </summary>
    public interface IVectorADT<T>
    {
        /// <summary>
        /// The number of elements stored in the Vector
        /// </summary>
        /// <returns>The number of elements</returns>
        int Count();

        bool IsEmpty();

        T ElementAtRank(int rank);

        /// <summary>
        /// Add a new element (obtained from the element parameter) to add to the Vector. The new element should be placed with a rank as given by the rank parameter.
        /// </summary>
        /// <param name="rank">The rank (position) of the new element</param>
        /// <param name="element">The element to add</param>
        void InsertAtRank(int rank, T element);

        void Append(T element);

        T ReplaceAtRank(int rank, T element);

        T RemoveAtRank(int rank);
    }
}

