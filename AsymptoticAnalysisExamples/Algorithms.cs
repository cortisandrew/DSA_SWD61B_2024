using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsymptoticAnalysisExamples
{
    public class Algorithms
    {
        /// <summary>
        /// An algorithm that finds the maximum from an array of number and returns the maximum number
        /// The problem size is the length of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int FindMax(int[] array)
        {
            // int n = array.Length; // problem size
            int workCarriedOut = 0;

            int maximum = array[0];
            workCarriedOut++; // declaring the maximum and assigning it to array[0] is a primitive operation (around 1 clock cycle)

            int i = 1;
            workCarriedOut++; // declaring i is a primitive operation. about 1 clock cycle

            while (i < array.Length)
            {
                workCarriedOut++; // i < array.Length was evaluated to true

                workCarriedOut++; // comparing the value at position i with the maximum takes 1 work
                if (array[i] > maximum)
                {
                    maximum = array[i];
                    workCarriedOut++; // update the maximum (only if you condition is true))
                }

                i++; // incrementing i is also a primitive operation
                workCarriedOut++;
            }

            workCarriedOut++; // exiting the while loop also counts as 1 unit of work (because i < array.Length was evaluated to false)




            workCarriedOut++; // returning the maxmimum is also 1 unit of work
            // Avoid writing to console within the method call... it is not good practice!
            Console.WriteLine($"n={array.Length}, T(n)={workCarriedOut}");
            return maximum;
        }

        long Factorial(long n)
        {
            // stopping condition
            if (n==0 || n == 1)
            {
                return 1;
            }

            // recursive call
            long recursiveResult = Factorial(n - 1);


            // extra work
            long extraWorkResult = n * recursiveResult;

            return extraWorkResult;
        }

        int[] MergeSort(int[] array)
        {
            int n = array.Length; // problem size
            int firstHalfProblemSize = n / 2;
            int secondHalfProblemSize = n - firstHalfProblemSize;

            // stopping condition
            if (array.Length <= 1)
            {
                return array;
            }

            // splitting my input into two roughly equal halves
            int[] firstHalfUnsorted = array.Take(firstHalfProblemSize).ToArray();
            int[] secondHalfUnsorted = array.Skip(firstHalfProblemSize).Take(secondHalfProblemSize).ToArray();

            // recursive callS (x2 calls!)
            int[] firstHalfSorted = MergeSort(firstHalfUnsorted);
            int[] secondHalfSorted = MergeSort(secondHalfUnsorted);

            // extra work
            int[] result = Merge(firstHalfSorted, secondHalfSorted);

            return result;
        }

        private int[] Merge(int[] firstHalfSorted, int[] secondHalfSorted)
        {
            // time equal to the firstHalfSorted.Length + secondHalfSorted.Length
            // n time
            throw new NotImplementedException();
        }
    }
}
