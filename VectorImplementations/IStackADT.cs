using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    /// <summary>
    /// A collection of elements. These elements are added and removed in a LIFO order
    /// </summary>
    public interface IStackADT<T>
    {
        /// <summary>
        /// Return the number of elements stored on the stack
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Add a new element to the top of the stack
        /// </summary>
        /// <param name="element"></param>
        void Push(T element);

        /// <summary>
        /// Remove the element from the top of the stack
        /// </summary>
        /// <returns>The newest element</returns>
        T Pop();

        /// <summary>
        /// Return the element at the top of the stack without removing it.
        /// </summary>
        /// <returns></returns>
        T Peek();
    }
}
