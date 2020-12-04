using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0) 
        { 
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else 
        {
            Console.WriteLine("Queue is empty");
        }
        aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        if (aQueue.Contains(search))
        {
            // Create a new stack to handle the old stack
            Stack<string> newQueue = new Stack<string>(aQueue);
            foreach (var item in newQueue)
            {
                if (aQueue.Dequeue() == search) { break; }
            }
        }
        
        return aQueue;
    }
}
