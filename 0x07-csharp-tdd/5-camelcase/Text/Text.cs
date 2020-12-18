using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Str class define an method to determine how many words
    /// are in a string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to determine how many words are in a string. Each
        /// word begins with a capital letter except the first word.
        /// <param name="s">String to check</param>
        /// <returns>number of words in s</returns>
        /// </summary>
        public static int CamelCase(string s)
        {
            bool flagUpper = false; // Flag to verify if an word not contains digit
            int countWord = 0;
            
            try
            {
                foreach (char c in s)
                {
                    if (Char.IsUpper(c) && flagUpper == true)
                        countWord++;
                    else if (flagUpper == false && Char.IsLower(c))
                    {
                        countWord++;
                        flagUpper = true;
                    }
                }    
            }
            catch (NullReferenceException)
            {                
                return countWord;
            }
            return countWord;
        }
    }
}
