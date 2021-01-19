using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n==================== TEST 1 ======================\n");
        double[,] matrix1 = {
            {1, 2},
            {3, 4}
        };
        Console.WriteLine($"Matrix1:\nRows = {matrix1.GetLength(0)}\nColumns = {matrix1.GetLength(1)}");
        printMatrix(MatrixMath.Transpose(matrix1));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix3 = new double[,] {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        Console.WriteLine($"Matrix3:\nRows = {matrix3.GetLength(0)}\nColumns = {matrix3.GetLength(1)}");
        printMatrix(MatrixMath.Transpose(matrix3));

        Console.WriteLine("\n==================== TEST 3 ======================\n");
        double[,] matrix4 = new double[,] {};
        Console.WriteLine($"Matrix4:\nRows = {matrix4.GetLength(0)}\nColumns = {matrix4.GetLength(1)}");
        printMatrix(MatrixMath.Transpose(matrix4));
    }
    // Method to print Matrix
    public static void printMatrix(double [,] matrix)
    {
        if (matrix.Length <= 1)
        {
            Console.WriteLine("The matrix is empty");
            Console.WriteLine("{}");
        } else
        {
                    
            Console.WriteLine(
                $"Dimension (Rank) = {matrix.Rank}\nDimension Row = {matrix.GetLength(0)}\nDimension Column = {matrix.GetLength(1)}\nAll Elements = {matrix.Length}"
                );
            
            Console.WriteLine($"Multiply resulting matrix is: \n");
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
