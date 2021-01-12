using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector1 = new double[] {-4, 0, 10};
        double[] vector2 = new double[] {3, 7, -9};
        double dot = 0;
        
        dot = VectorMath.DotProduct(vector1, vector2);
        Console.WriteLine($"Dot product is: {dot}");
        
        double[] vector3 = {-5.0, 1, 11, 15};
        double[] vector4 = {-3.0, 10, 2, 17};
        dot = VectorMath.DotProduct(vector3, vector4);
        Console.WriteLine($"It's no the same size or not 2D/3D vector => {dot}");
    }
}
