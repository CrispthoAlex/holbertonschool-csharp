using System;
using System.Collections;
    
/// <summary>
/// This Class have a method to rotate a matrix.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If the matrix is of an invalid size, return a matrix containing -1.
    /// </returns>
    /// <param name="matrix">: Matrix to rotate. </param>
    /// <param name="angle">: Angle to rotate the matrix. </param>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cosinangle = Math.Cos(angle);
        double sinangle = Math.Sin(angle);

        double[,] rotateMatrix = new double[,] { {cosinangle, sinangle}, {-sinangle, cosinangle} };
        
        if (matrix is double[,] && rotateMatrix is double[,] &&
            rotateMatrix.GetLength(1) == matrix.GetLength(0) ) // Columns matrix equal to Rows rotateMatrix.
        {
            int colMat1 = matrix.GetLength(0); // Vectors / Columns
            int rowMat1 = matrix.GetLength(1); // Elements of vector == Rows
            int rowMat2 = rotateMatrix.GetLength(1); // Elements of vector == Rows
            int colMat2 = rotateMatrix.GetLength(0); // Vectors / Columns

            double[,] mulMatrix = new double[colMat2, rowMat1];

            // Matrix resulting has the same number of rows as the 1st matrix, and the same number
            // of columns as the 2nd matrix.
            for (int col = 0; col < colMat2; col++)
            {
                for (int row = 0; row < rowMat1; row++)
                {
                    mulMatrix[col, row] = 0;
                    for (int rxc = 0; rxc <  colMat1; rxc++)
                    {
                        // Move col matrix and row rotateMatrix
                        mulMatrix[col, row] += Math.Round(matrix[rxc, row] * rotateMatrix[col, rxc], 0) ;
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
