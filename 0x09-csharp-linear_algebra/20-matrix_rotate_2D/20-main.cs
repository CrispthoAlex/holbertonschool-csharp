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
        
        double angle = -1.57;
        Console.WriteLine($"Angle = {angle}");
        
        printMatrix(MatrixMath.Rotate2D(matrix1, angle));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix3 = new double[,] {
            {-11, -5},
            {6, 16}
            //{5, 2}
        };

        Console.WriteLine($"Matrix3:\nColumns = {matrix3.GetLength(0)}\nRows = {matrix3.GetLength(1)}");
        Console.WriteLine($"Angle = {angle}");
        printMatrix(MatrixMath.Rotate2D(matrix3, angle));
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
