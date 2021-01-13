using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n==================== TEST 1 ======================\n");
        double[,] matrix = new double[,] {
            {-13, 10, 8},
            {2, 0, 14},
            {-4, -5, 2}
        };
        double scalar = 4;
        printMatrix(MatrixMath.MultiplyScalar(matrix, scalar));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix1 = new double[,] {
            {-11, -5, 3},
            {6, 16, 21},
            {5, 2, 0},
            {1, 3, 7}
        };
        printMatrix(MatrixMath.MultiplyScalar(matrix1, scalar));
    }
    // Method to print Matrix
    public static void printMatrix(double [,] matrix)
    {
        if (matrix.GetLength(0) == 1)
        {
            Console.WriteLine("Any matrix is not a 2D or 3D matrix, or both matrices are not the same size");
            Console.WriteLine(matrix[0,0]);
        } else
        {
            Console.WriteLine(
                $"Dimension (Rank) = {matrix.Rank}\nDimension (Vector) = {matrix.GetLength(0)}\nAll Elements = {matrix.Length}"
                );
            
            Console.WriteLine($"Resulting adding matrix is: ");
            for (int vec = 0; vec < matrix.GetLength(0); vec++)
            {
                Console.Write("( ");
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.Write($"{matrix[vec, row]} ");
                }
                Console.WriteLine(")");
            }
        }
    }
}
