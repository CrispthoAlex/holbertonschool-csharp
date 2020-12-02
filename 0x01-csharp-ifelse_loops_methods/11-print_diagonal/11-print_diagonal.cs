using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int diag, diag2;

        if (length <= 0)
        {
            Console.WriteLine("\n");
        }
        for (diag = 0; diag < length; diag++)
        {
            for (diag2 = 0; diag2 < diag; diag2++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        
    }
}
