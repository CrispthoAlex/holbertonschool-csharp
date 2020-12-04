using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currentNode = myLList.First ;
        
        foreach (int valNode in myLList)
        {
            if (valNode < n) {currentNode = currentNode.Next ;}
            else { return myLList.AddBefore(currentNode, n); }
        }
        return myLList.AddLast(n);
    }
}
