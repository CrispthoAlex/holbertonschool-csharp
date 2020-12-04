using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0) 
        { 
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else 
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        if (aStack.Contains(search))
        {
            // Create a new stack to handle the old stack
            Stack<string> newStack = new Stack<string>(aStack);
            foreach (var item in newStack)
            {
                if (aStack.Pop() == search) { break; }
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
