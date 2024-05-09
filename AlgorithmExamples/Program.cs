// See https://aka.ms/new-console-template for more information
using AlgorithmExamples;

Console.WriteLine("Hello, World!");

/*
int n = 100;

for (int i = 0; i < n; i++)
{
    int innerLoopWork = 0;
    for (int j = i; j < n; j++)
    {
        innerLoopWork++; 
    }
    // innerLoopWork = n - i + 1;

    Console.Write(innerLoopWork + ",");
}
*/

Algorithms a = new Algorithms();

Random r = new Random();
int length = 25;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    array[i] = r.Next(1000);
}

int[] sorted = a.MergeSort(array);

Console.WriteLine(String.Join(", ", sorted));
