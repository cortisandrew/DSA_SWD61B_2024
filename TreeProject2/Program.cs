// See https://aka.ms/new-console-template for more information
using TreeProject2;

Console.WriteLine("Hello, World!");

BinaryMaxHeap<int> heap = new BinaryMaxHeap<int>();

heap.Add(40, 40);
heap.Add(24, 24);
heap.Add(20, 20);
heap.Add(22, 22);
heap.Add(14, 14);
heap.Add(5, 5);


heap.Add(42, 42);

Console.WriteLine(heap.RemoveMax());

Console.WriteLine("End");