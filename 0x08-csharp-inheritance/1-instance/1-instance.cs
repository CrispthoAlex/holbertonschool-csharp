using System;

/// <summary>
/// Obj class define an method to check type of object
/// </summary>
class Obj
{
    /// <summary>
    /// Method to check if the object is an instance of, or if the object is
    /// an instance of a class that inherited from, Array.
    /// <param name="obj">integer</param>
    /// <returns>If obj is a Array instance True, else False</returns>
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array ; // Alternative a.GetType() == Array
    }
}
