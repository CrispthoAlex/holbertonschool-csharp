using System;

/// <summary>
/// This Class have a method to multiplie a vector and a scalar.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This Method multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <returns>
    /// The resulting vector. If any is not 2D or 3D vector, return a vector containing -1.
    /// </returns>
    /// <param name="vector">: Vector variable to multiply. </param>
    /// <param name="scalar">: number to multiply. </param>
    public static double[] Multiply(double[] vector, double scalar)
    {        
        if (vector is double[] && (2 <= vector.Length && vector.Length <= 3) )
        {
            int vecLength = vector.Length;
            double[] kVector = new double[vecLength];            
            
            for (int i = 0; i < vecLength; i++)
                kVector[i] = scalar * vector[i];
            return kVector;
        }
        return new double[]{-1};
    }
}