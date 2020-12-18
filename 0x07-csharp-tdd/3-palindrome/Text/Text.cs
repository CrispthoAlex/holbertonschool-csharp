using System;

namespace Text
{
    /// <summary>
    /// Str class define an method to check palindrome string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to return True if a string is a palindrome or False if it’s not.
        /// <param name="s">string</param>
        /// <returns>True or False</returns>
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            // Apply String lowercase and stay only letters
            string newString = String.Join("", s.ToLower().Split(' ', ',', '.', ':', ';', '\''));
            int strLen = newString.Length - 1;
            
            foreach (char letter in newString)
            {
                if ( letter != newString[strLen])
                    return false;
                strLen--;
            }
            return true;
        }
    }
}
