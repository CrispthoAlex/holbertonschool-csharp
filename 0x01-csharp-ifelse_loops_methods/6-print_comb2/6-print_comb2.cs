using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = ", "; // separator
            for (int dig1 = 0; dig1 < 10; dig1++)
            {
                for (int dig2 = 0; dig2 < 10; dig2++)
                {
                    if (dig1 < dig2)
                    {
                        Console.Write($"{dig1}{dig2}");
                        if (!(dig1 == 8 && dig2 == 9))
                        {
                            Console.Write(sep);
                        }
                    }
                }
            }
            Console.Write("\n");
        }
    }
}
