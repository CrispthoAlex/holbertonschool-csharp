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
            int flagChar = 1; // Flag to verify if an word not contains digit
            int countWord = 0;
            
            try
            {
                string[] strList = s.ToUpper().Split(' ', '\'');

                foreach (string word in strList)
                {
                    flagChar = 1;
                    foreach (char c in word)
                    {
                        if (Char.IsDigit(c))
                            flagChar = 0;
                    }
                    if (flagChar == 1)
                        countWord++;
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
