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
        Console.WriteLine($"Matrix1:\nColumns = {matrix1.GetLength(0)}\nRows = {matrix1.GetLength(1)}");
        char direction = 'x';
        double factor = 2;
        Console.WriteLine($"Factor = {factor}\nDirection = {direction}");
        
        printMatrix(MatrixMath.Shear2D(matrix1, direction, factor));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix3 = new double[,] {
            {-11, -5},
            {6, 16}
            //{5, 2}
        };

        Console.WriteLine($"Matrix3:\nColumns = {matrix3.GetLength(0)}\nRows = {matrix3.GetLength(1)}");
        direction = 'y';
        Console.WriteLine($"Factor = {factor}\nDirection = {direction}");
        printMatrix(MatrixMath.Shear2D(matrix3, direction, factor));

        Console.WriteLine("\n==================== TEST 3 ======================\n");
        double[,] matrix4 = new double[,] {
            {6, 16},
            {5, 2},
            {-3, -7}
        };

        Console.WriteLine($"Matrix4:\nColumns = {matrix4.GetLength(0)}\nRows = {matrix4.GetLength(1)}");
        direction = 'x';
        Console.WriteLine($"Factor = {factor}\nDirection = {direction}");
        printMatrix(MatrixMath.Shear2D(matrix4, direction, factor));

        Console.WriteLine("\n==================== TEST 4 ======================\n");
        double[,] matrix5 = new double[,] {
            {6, 16},
            {-3, -7}
        };

        Console.WriteLine($"Matrix5:\nColumns = {matrix5.GetLength(0)}\nRows = {matrix5.GetLength(1)}");
        direction = 'a';
        Console.WriteLine($"Factor = {factor}\nDirection = {direction}");
        printMatrix(MatrixMath.Shear2D(matrix5, direction, factor));
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
