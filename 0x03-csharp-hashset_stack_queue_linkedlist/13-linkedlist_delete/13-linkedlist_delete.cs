using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;
        int positionNode = 0;

        foreach (int valNode in myLList)
        {
            if (index == positionNode)
            {
                myLList.Remove(currentNode);
                break;
            }
            else 
            { 
                currentNode = currentNode.Next ;
                positionNode++;
            }
        }
    }
}
