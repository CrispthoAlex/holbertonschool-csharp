using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector = new double[] {-12.0, 6.0, 12};
        double scalar = 9.0;
        double[] kVector = {};
        
        kVector = VectorMath.Multiply(vector, scalar);
        Console.Write("Resulting vector is: { ");
        for (int i = 0; i < kVector.Length; i++)
        {
            Console.Write($"{kVector[i]} ");
        }
        Console.WriteLine("}");

        double[] numTest = {-3.0, 1, 2, 4 };
        kVector = VectorMath.Multiply(numTest, scalar);
        Console.WriteLine($"It's not a 2D or 3D Vector: \n {{ {kVector[0]} }}");
    }
}
