using System;
// using System.Exception;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int intPrinted = 0; // Save the number of elements that was printed
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                intPrinted++;
            }
        }
        catch (System.Exception)
        {
            // Console.WriteLine();
        }
        return intPrinted;
    }
}
