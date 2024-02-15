using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    internal class ArrayBasedVector<T> : IVectorADT
    {
        T[] _items;
    }
}
