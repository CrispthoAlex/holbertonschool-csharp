using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int countLList = 0;
        foreach (var valNode in myLList)
        {
            if (countLList == n)
            {
                return valNode;
            }
            countLList++;
        }
        return 0;
    }
}
