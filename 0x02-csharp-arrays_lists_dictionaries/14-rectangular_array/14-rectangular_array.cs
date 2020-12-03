using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 5;
        int cols = 5;
        int[,] array = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row == 2 && col == 2) { array[row, col] = 1; }
                else { array[row, col] = 0; }
                Console.Write(array[row, col]);
                if (col < cols - 1) { Console.Write(" "); }
            }
            Console.WriteLine("");
        }
    }
}
