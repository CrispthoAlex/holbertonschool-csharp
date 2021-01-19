﻿using System;
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

        if (direction == 'x') { shearY = 1; }
        else if (direction == 'y') { shearX = 1; }
        else { return new double[,]{{-1}}; }

        // Shear parallel to the x axis, or Shear parallel to the y axis
        double[,] shareMatrix = new double[,] { 
            {1, shearX * factor},
            {shearY * factor, 1}
        };
        
        if (matrix is double[,] && matrix.GetLength(1) == 2 && matrix.GetLength(0) == 2) // Square Matrix  2X2.
        {
            int rowMat1 = matrix.GetLength(0); // Elements of vector == Rows
            int colMat1 = matrix.GetLength(1); // Vectors / Columns
            int colMat2 = shareMatrix.GetLength(1); // Vectors / Columns
            int rowMat2 = shareMatrix.GetLength(0); // Elements of vector == Rows

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
                        mulMatrix[row, rxc] += matrix[row, col] * shareMatrix[col, rxc];
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
