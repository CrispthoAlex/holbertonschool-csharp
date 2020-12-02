using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 99; num++)
            {
                Console.Write($"{num} = 0x{num.ToString("x")}\n");
            }
            
        }
    }
}
