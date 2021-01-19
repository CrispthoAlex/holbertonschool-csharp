using System;

/// <summary>
/// This Class have a method to multiply a matrix and a scalar.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If the matrix is not a 2D or 3D matrix, return a matrix containing -1.
    /// </returns>
    /// <param name="matrix">: Matrix to get the Determinant. </param>
    public static double Determinant(double[,] matrix)
    {
        double detMatrix = 0;
        // dimension 2
        if (2 == matrix.GetLength(0) && 2 == matrix.GetLength(1))
        {
            detMatrix = matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0];
        } // dimension 3
        else if (3 == matrix.GetLength(0) && 3 == matrix.GetLength(1))
        {
            detMatrix = (
                            matrix[0, 0]*matrix[1, 1]*matrix[2, 2] + 
                            matrix[0, 1]*matrix[1, 2]*matrix[2, 0] +
                            matrix[0, 2]*matrix[1, 0]*matrix[2, 1]
                        ) -
                        (
                           matrix[0, 0]*matrix[1, 2]*matrix[2, 1] +
                           matrix[0, 1]*matrix[1, 0]*matrix[2, 2]
                        );
        } else { return -1; }
        
        return Math.Round(detMatrix, 2);
    }
}
