using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new queue
        Queue<string> queue = new Queue<string>();

        // Add elements to the queue
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Cherry");

        // Display the first element without dequeuing it
        Console.WriteLine("Peek: " + queue.Peek());  // Outputs: Apple

        // Dequeue elements from the queue
        while (queue.Count > 0)
        {
            string fruit = queue.Dequeue();
            Console.WriteLine("Dequeued: " + fruit);
        }
        
    }
}