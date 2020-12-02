using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = ", "; // separator
            for (int num = 0; num < 100; num++)
            {
                if (num == 99)
                {
                    Console.Write($"{num.ToString("d2")}\n");
                }
                else
                {
                    Console.Write($"{num.ToString("d2")}" + sep);
                }
            }
        }
    }
}
