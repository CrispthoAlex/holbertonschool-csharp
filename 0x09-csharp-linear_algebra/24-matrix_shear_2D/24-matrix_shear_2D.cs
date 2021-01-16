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
    /// <param name="direction">: char x or y to indicate direction. </param>
    /// <param name="factor">: Shear factor. </param>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int shearX = 0, shearY = 0;

        if (direction == 'x') { shearX = 1; }
        else if (direction == 'y') { shearY = 1; }
        else { return new double[,]{{-1}}; }

        double[,] shareMatrix = new double[,] { {1, shearY * factor}, {shearX * factor, 1} };
        
        if (matrix is double[,] && shareMatrix is double[,] &&
            shareMatrix.GetLength(1) == matrix.GetLength(0)) // Columns matrix equal to Rows shareMatrix.
        {
            int colMat1 = matrix.GetLength(0); // Vectors / Columns
            int rowMat1 = matrix.GetLength(1); // Elements of vector == Rows
            int rowMat2 = shareMatrix.GetLength(1); // Elements of vector == Rows
            int colMat2 = shareMatrix.GetLength(0); // Vectors / Columns

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
                        // Move col matrix and row shareMatrix
                        mulMatrix[col, row] += matrix[rxc, row] * shareMatrix[col, rxc];
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
