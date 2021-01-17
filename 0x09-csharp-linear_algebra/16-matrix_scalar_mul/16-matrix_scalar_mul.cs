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
    /// <param name="matrix">: Vector variable to multiply. </param>
    /// <param name="scalar">: Scalar variable to multiply. </param>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {        
        if (matrix is double[,] && (2 == matrix.GetLength(0) && 2 == matrix.GetLength(1)) ||
        (3 == matrix.GetLength(0) && 3 == matrix.GetLength(1)) )
        {
            int dimMat = matrix.GetLength(0);
            double[,] kMatrix = new double[dimMat, dimMat];
            
            for (int vec = 0; vec < dimMat; vec++)
            {
                for (int row = 0; row < dimMat; row++)
                {
                    kMatrix[vec, row] = scalar * matrix[vec, row] ;
                }
            }
            return kMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
