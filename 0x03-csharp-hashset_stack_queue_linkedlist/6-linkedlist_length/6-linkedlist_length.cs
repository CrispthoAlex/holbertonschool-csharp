using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int countLList = 0;
        foreach (var valNode in myLList)
        {
            countLList++;
        }
        return countLList;
    }
}
