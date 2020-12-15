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
            for (; intPrinted < n; intPrinted++)
            {
                Console.WriteLine(myList[intPrinted]);
                // intPrinted++;
            }
        }
        catch (System.Exception)
        {
            // Console.WriteLine();
        }
        return intPrinted;
    }
}
