using System;

/// <summary>
/// This Class have a method to calculates dot product of either two 2D or two 3D vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This Method calculates dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <returns>
    /// The resulting scalar. If any is not 2D or 3D vector, or both vectors
    /// are not the same size, return  -1.
    /// </returns>
    /// <param name="vector1">: Vector variable to calculate dot product. </param>
    /// <param name="vector2">: Vector variable to calculate dot product. </param>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1 is double[] && vector1 is double[] &&
            vector1.Length == vector2.Length &&
            vector1.Length <= 3 && vector2.Length <= 3)
        {
            int vecLength = vector1.Length;
            double dotProduct = 0;            
            
            for (int i = 0; i < vecLength; i++)
                dotProduct += vector1[i] * vector2[i];
            
            return dotProduct;
        }
        return -1;
    }
}
