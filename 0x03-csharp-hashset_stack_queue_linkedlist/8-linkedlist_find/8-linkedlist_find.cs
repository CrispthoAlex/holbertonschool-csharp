using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int countLList = 0;
        foreach (var valNode in myLList)
        {
            if (valNode == value)
            {
                return countLList;
            }
            countLList++;
        }
        return -1;
    }
}
