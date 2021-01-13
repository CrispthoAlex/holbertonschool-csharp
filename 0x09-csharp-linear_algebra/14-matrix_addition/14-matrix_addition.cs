using System;

/// <summary>
/// This Class have a method to add two vectors.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If any matrix is not a 2D or 3D matrix, or
    /// both matrices are not the same size, return a matrix containing -1.
    /// </returns>
    /// <param name="matrix1">: Vector variable to add. </param>
    /// <param name="matrix2">: Vector variable to add. </param>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {        
        if (matrix1 is double[,] && matrix2 is double[,] &&
            matrix1.GetLength(0) == matrix2.GetLength(0) && // Equal Dimension
            matrix1.Length == matrix2.Length) // Equal Elements
        {
            int dimMat = matrix1.GetLength(0);
            double[,] sumMatrix = new double[dimMat, dimMat];
            
            for (int vec = 0; vec < dimMat; vec++)
            {
                for (int row = 0; row < dimMat; row++)
                {
                    sumMatrix[vec, row] = matrix1[vec, row] + matrix2[vec, row];
                }
            }
            return sumMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
