using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();
        Boolean flagZero = false;
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                if (list2[i] == 0)
                {
                    flagZero = true;
                    resultList.Add(0);
                    // Console.WriteLine(resultList[i]);
                }
                else
                {
                    // flagZero = false;
                    resultList.Add(list1[i] / list2[i]);
                    // Console.WriteLine(resultList[i]);
                }
            }
        }
        catch (System.Exception)
        {
            if (flagZero == true)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            if ( listLength > list1.Count || listLength > list2.Count )
            {
                Console.WriteLine("Out of range");
            }
        }
        return resultList;
    }
}
