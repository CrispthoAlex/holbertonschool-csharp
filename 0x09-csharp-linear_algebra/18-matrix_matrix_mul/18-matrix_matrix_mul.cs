using System;
using System.Collections;
    
/// <summary>
/// This Class have a method to multiply two matrices.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If the matrices cannot be multiplied, return a matrix containing -1.
    /// </returns>
    /// <param name="matrix1">: Matrix to multiply. </param>
    /// <param name="matrix2">: Matrix to multiply. </param>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // int countColMat1 = 0; // Number of columns in Matrix1
        
        if (matrix1 is double[,] && matrix2 is double[,] &&
            matrix2.GetLength(0) == matrix1.GetLength(1)) // Columns matrix1 equal to Rows matrix2.
        {
            int rowMat1 = matrix1.GetLength(0); // Elements of vector == Rows
            int colMat1 = matrix1.GetLength(1); // Vectors / Columns
            int colMat2 = matrix2.GetLength(1); // Vectors / Columns
            int rowMat2 = matrix2.GetLength(0); // Elements of vector == Rows

            double[,] mulMatrix = new double[rowMat1, colMat2];

            // Matrix resulting has the same number of rows as the 1st matrix, and the same number
            // of columns as the 2nd matrix.
            for (int col = 0; col < colMat1; col++)
            {
                for (int row = 0; row < rowMat1; row++)
                {
                    for (int rxc = 0; rxc < colMat2; rxc++)
                    {
                        // Move col matrix1 and row matrix2
                        mulMatrix[row, rxc] += matrix1[row, col] * matrix2[col, rxc] ;
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
