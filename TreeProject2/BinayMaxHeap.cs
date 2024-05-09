using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject2
{

    /// <summary>
    /// Max heap means that the largest element is on the top.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryMaxHeap<T>
    {
        List<KeyValuePair<int, T>> data = new List<KeyValuePair<int, T>>();

        private int LeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private int RightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        private int ParentIndex(int index) {

            // Math.Floor rounds downwards
            return (int)Math.Floor((index - 1) / 2.0);

            // return (index - 1) / 2;
        }


        public void Add(int key, T value)
        {
            // added to the end of the heap
            // we still keep the complete property
            data.Add(new KeyValuePair<int, T>(key, value));

            // perform an uphead at the index of the newly added element
            // the upheap will compare the key against the key of its parent, and swap if necessary
            Upheap(data.Count - 1);

        }

        private void Upheap(int index)
        {
            // stopping condition: index is the root!
            // this means that the element is at the top of the heap and has the largest value
            if (index == 0)
            {
                return;
            }

            // compare the key of the element at the index with its parent
            // if the parent has a SMALLER value we have to swap! (MAX heap)
            int parentIndex = ParentIndex(index);

            if (data[index].Key > data[parentIndex].Key)
            {
                data.Swap(index, parentIndex);
                Upheap(parentIndex);
            }

            // if we have swapped, we need to continue the Upheap, until we don't have to swap OR we have reached the root
        }

        public T RemoveMax()
        {
            T value = data[0].Value; // get the value that corresponds to the largest key

            data.Swap(0, data.Count - 1); // swap with the last element
            data.RemoveAt(data.Count - 1); // remove the item we have just obtained

            // now the heap is complete, but the heap-order is lost, because the root might not be the largest element!
            DownHeap(0);

            return value;
        }

        private void DownHeap(int index)
        {
            // downheap is performed until:
            // either heap-order is restored OR
            // the node at index has NO children

            int leftChildIndex = LeftChildIndex(index);

            if (leftChildIndex >= data.Count)
            {
                // data[leftChildIndex] would be out of range
                // because there is no left child
                // since there is no left child, it also means that we do not have a right child!
                // heap-order is restored
                return;
            }

            int largestChildIndex = leftChildIndex;

            if (leftChildIndex == data.Count - 1)
            {
                // left child is the last element
                // therefore there is only 1 child!

                // since there is ONLY 1 child, the largestChildIndex is the leftChildIndex
            }
            else
            {
                // we have two children!
                int rightChildIndex = RightChildIndex(index);

                if (data[leftChildIndex].Key < data[rightChildIndex].Key)
                {
                    // right Child is larger!
                    largestChildIndex = rightChildIndex;
                }
            }

            // we have at least one child. The largest child is at largest Child Index!
            if (data[index].Key < data[largestChildIndex].Key)
            {
                data.Swap(index, largestChildIndex);
                DownHeap(largestChildIndex);
                // return;
            }
            /*
            else
            {
                // we did not need to swap
                return;
            }
            */
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // notation is DOT notation
            // we can create a graph using GraphViz tool online

            if (data.Count > 0)
            {
                sb.AppendLine("Graph G {");
                sb.AppendLine(data[0].Key.ToString());

                for (int i = 1; i < data.Count; i++)
                {
                    int parentIndex = ParentIndex(i);

                    sb.AppendLine($"{data[parentIndex].Key.ToString()}--{data[i].Key.ToString()}");
                }


                sb.AppendLine("}");
            }
            else
            {
                return "EMPTY";
            }

            return sb.ToString();
        }

        public int Count()
        {
            return data.Count;
        }
    }
}
