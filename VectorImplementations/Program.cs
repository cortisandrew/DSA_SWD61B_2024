// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using VectorImplementations;

#region some example use of the ArrayBasedVector
/*
ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>();
arrayBasedVector.Append("Hello");

ArrayBasedVector<double> arrayBasedVector2 = new ArrayBasedVector<double>();
arrayBasedVector2.Append(1.0);
*/
#endregion

Stopwatch stopwatch = new Stopwatch();

// Sizes of arrays to consider
List<int> problemSizes = new List<int>() { 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

int repetitions = 100;
Random r = new Random();

// Execute the methods a few time prior to timing so that the code does not slow down in the first problem size
ArrayBasedVector<int> arrayBasedVector = new ArrayBasedVector<int>(100);
for (int i = 0; i < 100; i++)
{
    arrayBasedVector.Append(i);
}
arrayBasedVector.ElementAtRank(0);

Console.WriteLine("Testing the speed of the Element At Rank");
foreach (var problemSize in problemSizes)
{
    stopwatch.Reset();

    arrayBasedVector = new ArrayBasedVector<int>(problemSize);
    for (int i = 0; i < problemSize; i++)
    {
        arrayBasedVector.Append(i);
    }

    for (int i = 0; i < repetitions; i++)
    {
        int randomRank = r.Next(0, problemSize);

        stopwatch.Start();
        arrayBasedVector.ElementAtRank(randomRank);
        stopwatch.Stop();
    }

    // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks/repetitions}");
}

Console.WriteLine("Testing the speed of Append");
foreach (var problemSize in problemSizes)
{
    stopwatch.Reset();

    arrayBasedVector = new ArrayBasedVector<int>(problemSize + repetitions + 2);
    for (int i = 0; i < problemSize; i++)
    {
        arrayBasedVector.Append(i);
    }

    for (int i = 0; i < repetitions; i++)
    {
        int randomValue = r.Next(0, problemSize);

        stopwatch.Start();
        arrayBasedVector.Append(randomValue);
        stopwatch.Stop();
    }

    // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks / repetitions}");
}

Console.WriteLine("Testing the speed of InsertAtRank 0");
foreach (var problemSize in problemSizes)
{
    stopwatch.Reset();

    arrayBasedVector = new ArrayBasedVector<int>(problemSize + repetitions + 2);
    for (int i = 0; i < problemSize; i++)
    {
        arrayBasedVector.Append(i);
    }

    for (int i = 0; i < repetitions; i++)
    {
        int randomValue = r.Next(0, problemSize);

        stopwatch.Start();
        arrayBasedVector.InsertAtRank(0, randomValue);
        stopwatch.Stop();
    }

    // Console.WriteLine($"The total time to read {repetitions} elements from an ABV of size {problemSize} is {stopwatch.ElapsedTicks} ticks");

    Console.WriteLine($"{problemSize}, {(double)stopwatch.ElapsedTicks / repetitions}");
}