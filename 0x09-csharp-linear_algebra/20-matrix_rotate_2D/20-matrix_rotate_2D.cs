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
        //int clock = -1;
        // The direction of vector rotation is counterclockwise if θ is positive (e.g. 90°),
        // and clockwise if θ is negative (e.g. −90°)
        //if (angle < 0)
        //    clock = -clock;

        double[,] rotateMatrix = new double[,] {
            {cosinangle, -sinangle},
            {sinangle, cosinangle}
        };
        
        if (matrix is double[,] && rotateMatrix is double[,] &&
            rotateMatrix.GetLength(0) == matrix.GetLength(1)) // Columns matrix equal to Rows rotateMatrix.
        {
            int rowMat1 = matrix.GetLength(0); // Elements of vector == Rows
            int colMat1 = matrix.GetLength(1); // Vectors / Columns
            int colMat2 = rotateMatrix.GetLength(1); // Vectors / Columns
            int rowMat2 = rotateMatrix.GetLength(0); // Elements of vector == Rows

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
                        mulMatrix[row, rxc] += Math.Round(matrix[row, col] * rotateMatrix[col, rxc], 2);
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
