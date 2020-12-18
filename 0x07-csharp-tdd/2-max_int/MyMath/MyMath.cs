using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This class defines a method to operate a list.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// a method that returns the max integer in a list of integers.
        /// <param name="nums">list of integers</param>
        /// <returns>max integer in list</returns>
        /// </summary>
        public static int Max(List<int> nums)
        {
            int maxNumber = 0;
            try
            {
                maxNumber = nums[0];
                
                foreach (int num in nums)
                {
                    if (num > maxNumber)
                        maxNumber = num;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // List is empty
                return maxNumber;
            }
            catch (NullReferenceException)
            {
                // List is null
                return maxNumber;
            }
            return maxNumber;
        }
    }
}
