using System.Diagnostics;

namespace EmpiricalAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            int repetitions = 100;
            bool firstAttempt = true;
            List<int> problemSizes = new List<int>() { 100, 100, 1000, 10000, 100000, 1000000 };
            Random r = new Random();

            Console.WriteLine("Find max...");
            // Setup the algorithm to execute here...

            foreach (var problemSize in problemSizes)
            {
                stopwatch.Reset();

                // perform some setup here...
                int[] array = new int[problemSize];
                
                for (int i = 0; i < repetitions; i++)
                {
                    // additional setup here...
                    for (int j = 0; j < problemSize; j++)
                    {
                        array[j] = r.Next(int.MaxValue);
                    }

                    stopwatch.Start();
                    // execute what you want to time here...
                    
                    // Find maximum
                    int max = array[0];
                    int maxPosition = 0;

                    for (int j = 1; j < problemSize; j++)
                    {
                        if (array[j] > max)
                        {
                            max = array[j];
                            maxPosition = j;
                        }
                    }
                    // End find maximum

                    stopwatch.Stop();
                }

                // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

                if (firstAttempt)
                {
                    firstAttempt = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks / repetitions}");
                }
            }

            firstAttempt = true;
            
            Console.WriteLine("Find mean...");
            // Setup the algorithm to execute here...

            foreach (var problemSize in problemSizes)
            {
                stopwatch.Reset();

                // perform some setup here...
                int[] array = new int[problemSize];

                for (int i = 0; i < repetitions; i++)
                {
                    // additional setup here...
                    for (int j = 0; j < problemSize; j++)
                    {
                        array[j] = r.Next(int.MaxValue);
                    }

                    stopwatch.Start();
                    // execute what you want to time here...

                    // Find mean 
                    long sum = 0;

                    for (int j = 1; j < problemSize; j++)
                    {
                        sum += array[j];

                        // some extra work to slow the algorithm down
                        System.Threading.Thread.Sleep(new TimeSpan(1));
                    }

                    double mean = sum / problemSize;
                    // End find mean

                    stopwatch.Stop();
                }

                // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

                if (firstAttempt)
                {
                    firstAttempt = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks / repetitions}");
                }
            }

            firstAttempt = true;

            Console.WriteLine("Sort array...");
            // Setup the algorithm to execute here...

            foreach (var problemSize in problemSizes)
            {
                stopwatch.Reset();

                // perform some setup here...
                int[] array = new int[problemSize];

                for (int i = 0; i < repetitions; i++)
                {
                    // additional setup here...
                    for (int j = 0; j < problemSize; j++)
                    {
                        array[j] = r.Next(int.MaxValue);
                    }

                    stopwatch.Start();
                    // execute what you want to time here...

                    // Find mean 
                    for (int j = 1; j < problemSize; j++)
                    {
                        Array.Sort(array);
                    }
                    // End find mean

                    stopwatch.Stop();
                }

                // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

                if (firstAttempt)
                {
                    firstAttempt = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks / repetitions}");
                }
            }
        }
    }
}