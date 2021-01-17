using System;

/// <summary>
/// This Class have a method to calculate the length of a give vector
/// </summary>
class VectorMath
{
    /// <summary>
    /// This Method calculate the length of a give vector
    /// </summary>
    /// <returns>
    /// If a vector return length of vector, else -1
    /// </returns>
    /// <param name="vector">: Vector variable to calculate its length </param>
    public static double Magnitude(double[] vector)
    {        
        if (vector is double[]  && (2 <= vector.Length && vector.Length <= 3))
        {
            double sumSqrtVec = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                sumSqrtVec += Math.Pow(vector[i], 2);
            }
            return Math.Round(Math.Sqrt(sumSqrtVec), 2);
        }
        else  { return -1; }
    }
}
