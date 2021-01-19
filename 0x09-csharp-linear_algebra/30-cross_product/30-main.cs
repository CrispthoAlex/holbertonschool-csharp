using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector1 = new double[] {2, -2, 1};
        double[] vector2 = new double[] {-8, 8, -4};
        double[] crossVector = new double[] {};

        crossVector = VectorMath.CrossProduct(vector1, vector2);
        Console.Write("Resulting vector is: { ");
        for (int i = 0; i < crossVector.Length; i++)
        {
            Console.Write($"{crossVector[i]} ");
        }
        Console.WriteLine("}");

        double[] testVector = {-3.0, 1, 2, 4 };
        crossVector = VectorMath.CrossProduct(vector2, testVector);
        Console.WriteLine($"Any Vector ss not a 2D or 3D Vector: \n {{ {crossVector[0]} }}");
    }
}
