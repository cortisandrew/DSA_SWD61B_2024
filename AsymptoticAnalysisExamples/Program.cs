namespace AsymptoticAnalysisExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Algorithms a = new Algorithms();

            // n is the problem size
            for (int n = 1; n < 11; n++)
            {
                int[] array = Enumerable.Range(1, n).ToArray(); // worst case, ascending order // new int[n]; // array full of zeroes (best case since max = arr[0]
                int maximumValue = a.FindMax(array);
            }

        }
    }
}