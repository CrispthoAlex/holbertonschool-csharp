using System;

class Int
{
    public static void divide(int a, int b)
    {
        int resultDiv = 0; // Save result from division
        try
        {
            resultDiv = a / b;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, resultDiv);
        }
    }
}
