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

Console.WriteLine(heap);


PriorityQueue<string> queue = new PriorityQueue<string>();

queue.Enqueue(100, "High");
queue.Enqueue(10, "Low");
queue.Enqueue(20, "Medium");

queue.DequeueHighestPriority();

queue.Enqueue(50, "High");

while (queue.Count() > 0)
{
    Console.WriteLine(queue.DequeueHighestPriority().ToString());
}

List<int> unsorted = new List<int>() { 14, 2, 45, 90, 43, 23 };

Console.WriteLine(String.Join(",", new HeapSort().SortDescending(unsorted)));