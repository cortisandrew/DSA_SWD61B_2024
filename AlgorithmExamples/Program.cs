// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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