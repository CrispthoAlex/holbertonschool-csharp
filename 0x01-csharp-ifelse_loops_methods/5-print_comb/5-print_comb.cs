﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 100; num++)
            {
                Console.Write($"{num.ToString("D2")}");
                if (num < 99) { Console.Write(", "); }
            }
            Console.Write("\n");
        }
    }
}
