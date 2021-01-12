using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector1 = new double[] {3.0, 9.0};
        double[] vector2 = new double[] {7.0, -3.0, 9.0};
        double lengthVector = 0;
        
        lengthVector = VectorMath.Magnitude(vector1);
        Console.WriteLine($"Length of vector1 is {lengthVector}");

        lengthVector = VectorMath.Magnitude(vector2);
        Console.WriteLine($"Length of vector2 is {lengthVector}");

        lengthVector = VectorMath.Magnitude(new double[] {});
        Console.WriteLine($"Length of vector3 is {lengthVector}");

        lengthVector = VectorMath.Magnitude(new double[] {7.0, -3.0, 9.0, 8.9});
        Console.WriteLine($"It's not a 2D or 3D vector: {lengthVector}");
    }
}