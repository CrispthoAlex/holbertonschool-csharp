using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null && array.Length > 0)
        {
            for (int pos = array.Length - 1; pos >= 0; pos--)
            {
                Console.Write(array[pos]);
                if (pos > 0) { Console.Write(" ");}
            }
            Console.WriteLine("");
        }
        else 
        {
            Console.WriteLine("");
        }
    }
}
