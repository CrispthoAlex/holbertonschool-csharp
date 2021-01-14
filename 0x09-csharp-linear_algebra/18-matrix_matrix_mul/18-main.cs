using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n==================== TEST 1 ======================\n");
        double[,] matrix1 = {
            {-1, 2},
            {3, 4},
            {-5, -6}
        };
        Console.WriteLine($"Matrix1:\nColumns = {matrix1.GetLength(0)}\nRows = {matrix1.GetLength(1)}");
        double[,] matrix2 = {
            {9, 8, 7},
            {-6, -5, 4},
            {-3, 2, 1}
        };
        Console.WriteLine($"Matrix2:\nColumns = {matrix2.GetLength(0)}\nRows = {matrix2.GetLength(1)}");
        printMatrix(MatrixMath.Multiply(matrix1, matrix2));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix3 = new double[,] {
            {-11, -5},
            {6, 16},
            {5, 2},
            {1, 3}
        };

        Console.WriteLine($"Matrix1:\nColumns = {matrix1.GetLength(0)}\nRows = {matrix1.GetLength(1)}");
        Console.WriteLine($"Matrix3:\nColumns = {matrix3.GetLength(0)}\nRows = {matrix3.GetLength(1)}");
        printMatrix(MatrixMath.Multiply(matrix1, matrix3));
    }
    // Method to print Matrix
    public static void printMatrix(double [,] matrix)
    {
        if (matrix.Length == 1)
        {
            Console.WriteLine("The matrices cannot be multiplied");
            Console.WriteLine(matrix[0,0]);
        } else
        {
                    
            Console.WriteLine(
                $"Dimension (Rank) = {matrix.Rank}\nDimension Column = {matrix.GetLength(0)}\nDimension Row = {matrix.GetLength(1)}\nAll Elements = {matrix.Length}"
                );
            
            Console.WriteLine($"Multiply resulting matrix is: ");
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write("| ");
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    Console.Write($"{matrix[col,row]} ");
                }
                Console.WriteLine("|");
            }
        }
    }
}
