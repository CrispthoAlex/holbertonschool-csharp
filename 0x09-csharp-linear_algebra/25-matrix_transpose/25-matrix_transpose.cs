using System;
using System.Collections;
    
/// <summary>
/// This Class have a method to transpose a matrix.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method transposes a matrix and return the resulting matrix.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If the matrix is empty, return an empty matrix.
    /// </returns>
    /// <param name="matrix">: Matrix to transpose. </param>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return matrix;

        double[,] transposeMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        
        // Matrix resulting has the same number of rows as the 1st matrix, and the same number
        // of columns as the 2nd matrix.
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Move col matrix1 and row matrix2
                transposeMatrix[col, row] = matrix[row, col];
            }
        }
        return transposeMatrix;
    }
}
