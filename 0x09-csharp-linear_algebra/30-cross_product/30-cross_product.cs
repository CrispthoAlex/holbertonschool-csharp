using System;

/// <summary>
/// This Class have a method to calculate the cross product of two 3D vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This Method calculates the cross product of two 3D vectors.
    /// </summary>
    /// <returns>
    /// The resulting vector. If either vector is not a 3D vector, return a
    ///  vector containing -1.
    /// </returns>
    /// <param name="vector1">: Vector variable to calculate Cross/Vector product. </param>
    /// <param name="vector2">: Vector variable to calculate Cross/Vector product. </param>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 is double[] && vector1 is double[] &&
            vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            // (V1xV2)x = V1yV2z − V1zV2y
            // (V1xV2)y = V1zVx − V1xV2z
            // (V1xV2)z = V1xV2y − V1yV2x
            double[] crossProduct = new double[]
            {
                vector1[1]*vector2[2] - vector1[2]*vector2[1],
                vector1[2]*vector2[0] - vector1[0]*vector2[2],
                vector1[0]*vector2[1] - vector1[1]*vector2[0]
            };
            return crossProduct;
        }
        return new double[] {-1};
    }
}
