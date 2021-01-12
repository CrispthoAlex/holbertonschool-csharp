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
        double magVector = 0;
        double sumSqrtVec = 0;
        
        if (vector is double[])
        {
            for (int i = 0; i < vector.Length; i++)
            {
                sumSqrtVec += Math.Pow(vector[i], 2f);
            }
            magVector = Math.Sqrt(sumSqrtVec);
            // lengthVector = Math.Sqrt(Math.Pow(vector.X, 2f) + Math.Pow(vector.Y, 2f) + Math.Pow(vector.Z, 2f));
        }
        else  { return (-1); }
        
        return Math.Round(magVector, 1);
        //return lengthVector;
    }
}
