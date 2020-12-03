using System;

class Array
{
    public static int[] CreatePrint(int size)
    {           
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] values = new int[size];
        if (size == 0)
        {
            Console.WriteLine("");
        }
        else
        {
            for (int pos = 0; pos < size; pos++)
            {
                values[pos] = pos;
                Console.Write(values[pos]);
                if (pos < size - 1) { Console.Write(" ");}
            }
            Console.WriteLine("");
        }
        return values;
    }
}
