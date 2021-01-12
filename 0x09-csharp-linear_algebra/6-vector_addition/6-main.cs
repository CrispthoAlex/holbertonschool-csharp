using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector1 = new double[] {3.0, 9.0, -12};
        double[] vector2 = new double[] {7.0, -3.0, 9.0};
        double[] sumVector = {};
        
        sumVector = VectorMath.Add(vector1, vector2);
        Console.Write("Resulting vector is: { ");
        for (int i = 0; i < sumVector.Length; i++)
        {
            Console.Write($"{sumVector[i]} ");
        }
        Console.WriteLine("}");

        double[] vector3 = new double[] {7.0, -3.0};
        sumVector = VectorMath.Add(vector1, vector3);
        Console.WriteLine($"It's not the same sizes: \n {{ {sumVector[0]} }}");
    }
}
