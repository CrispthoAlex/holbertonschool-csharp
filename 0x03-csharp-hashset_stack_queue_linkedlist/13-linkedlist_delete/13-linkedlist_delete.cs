using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;
        for (int indexNode = 0; currentNode != null; indexNode++)
        {
            if (index == indexNode)
            {
                myLList.Remove(currentNode);
                break;
            } 
            currentNode = currentNode.Next ;
        }
    }
}
