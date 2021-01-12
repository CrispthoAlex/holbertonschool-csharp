using System;

/// <summary>
/// This Class have a method to add two vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This Method adds two vectors and returns the resulting vector.
    /// </summary>
    /// <returns>
    /// The resulting vector. If any is not 2D or 3D vector,  if the vectors 
    /// are not of the same size, return a vector containing -1.
    /// </returns>
    /// <param name="vector1">: Vector variable to add. </param>
    /// <param name="vector2">: Vector variable to add. </param>
    public static double[] Add(double[] vector1, double[] vector2)
    {        
        if (vector1 is double[] && vector2 is double[] &&
            vector1.Length == vector2.Length &&
            vector1.Length <= 3 && vector2.Length <= 3)
        {
            double[] sumVector = new double[vector1.Length];            
            
            for (int i = 0; i < vector1.Length; i++)
                sumVector[i] = vector1[i] + vector2[i];
            return sumVector;
        }
        else  { return new double[]{-1}; }
    }
}
