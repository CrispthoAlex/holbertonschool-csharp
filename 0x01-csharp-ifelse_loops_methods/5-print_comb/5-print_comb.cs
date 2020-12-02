using System;

class Program
{
    static void Main(string[] args)
    {
        string sep = ", "; // separator
        for (int num = 0; num < 100; num++)
        {
            Console.Write($"{num.ToString("d2")}");
            if (num < 99)
            {
                Console.Write(sep);
            }
        }
        Console.WriteLine(""); // new line
    }
}
