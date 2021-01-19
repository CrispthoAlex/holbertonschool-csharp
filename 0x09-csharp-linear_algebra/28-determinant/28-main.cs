using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n==================== TEST 1 ======================\n");
        double[,] matrix = new double[,] {
            {2, 2},
            {-9, 4}
        };
    
        printMatrix(matrix);
        Console.WriteLine($"Determinant is: {MatrixMath.Determinant(matrix)}");

        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix1 = new double[,] {
            {-4, 9, 0},
            {1, -2, 1},
            {3, -4, 2}
        };
    
        printMatrix(matrix1);
        Console.WriteLine($"Determinant is: {MatrixMath.Determinant(matrix1)}");
        
        Console.WriteLine("\n==================== TEST 3 ======================\n");
        double[,] matrix2 = new double[,] {
            {-11, -5, 3},
            {6, 16, 21},
            {5, 2, 0},
            {1, 3, 7}
        };
        printMatrix(matrix2);
        Console.WriteLine($"Determinant is: {MatrixMath.Determinant(matrix2)}");
    }
    // Method to print Matrix
    public static void printMatrix(double [,] matrix)
    {
        if (matrix.GetLength(0) !=  matrix.GetLength(1))
        {
            Console.WriteLine("Any matrix is not a 2D or 3D matrix");
        } else
        {
            Console.WriteLine(
                $"Rows = {matrix.GetLength(0)}\nColumns = {matrix.GetLength(1)}\nAll Elements = {matrix.Length}"
                );
            
            Console.WriteLine($"Matrix is: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("( ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine(")");
            }
        }
    }
}
