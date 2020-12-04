using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sumValueLList = 0;
        foreach (var valNode in myLList)
        {
            sumValueLList += valNode;
        }
        return sumValueLList;
    }
}
