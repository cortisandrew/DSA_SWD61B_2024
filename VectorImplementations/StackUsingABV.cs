using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    /// <summary>
    /// Data Structure that implements the IStackADT using ArrayBasedVectors
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackUsingABV<T> : IStackADT<T>
    {
        private const int DEFAULT_LENGTH = 32;
        
        private ArrayBasedVector<T> abv;

        public StackUsingABV(int initialLength = DEFAULT_LENGTH)
        {
            abv = new ArrayBasedVector<T>(initialLength);
        }

        public int Size
        {
            get { return abv.Count(); }
        }

        public T Peek()
        {
            return abv.ElementAtRank(abv.Count() - 1);
        }

        public T Pop()
        {
            return abv.RemoveAtRank(abv.Count() - 1);
        }

        public void Push(T element)
        {
            abv.Append(element);
        }

        public override string ToString()
        {
            if (abv == null)
            {
                return "Stack is Empty!";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Top of Stack");
            for (int i = abv.Count() - 1; i >=0; i--)
            {
                T getElement = abv.ElementAtRank(i);

                if (getElement == null)
                {
                    sb.AppendLine("NULL");
                }
                else
                {
                    sb.AppendLine(getElement.ToString());
                }
            }
            sb.AppendLine("#############");

            return sb.ToString();
        }
    }
}
