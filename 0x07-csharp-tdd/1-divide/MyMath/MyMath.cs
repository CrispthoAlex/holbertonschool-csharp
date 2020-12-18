using System;

namespace MyMath
{
    /// <summary>
    /// Matrix class define an method to divide each element of a matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Method to divide each element of matrix by num and, return a new matrix.
        /// <param name="matrix">matrix</param>
        /// <param name="num">integer</param>
        /// <returns>A new matrix of integers</returns>
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMatrix;
            try
            {
                newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {   
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        newMatrix[row, col] = matrix[row, col] / num;
                    }
                } 
            }
            catch (NullReferenceException)
            {
                return null;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return newMatrix;
        }
    }
}
