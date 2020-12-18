using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Str class define an method to check a unique 
    /// character in a string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to return the index of a non-repeating character.
        /// <param name="s">String to check</param>
        /// <returns>index of a non-repeating char, else-1</returns>
        /// </summary>
        public static int UniqueChar(string s)
        {
            s = s.ToLower();
            foreach (char c in s)
            {
                // Using Count method to check if there is a 
                // non-repeating char.
                if (s.Count(ch => ch == c) == 1)
                {
                    // return the index of non-repeating char
                    return s.IndexOf(c);
                }
            }
            return -1;
        }
    }
}
