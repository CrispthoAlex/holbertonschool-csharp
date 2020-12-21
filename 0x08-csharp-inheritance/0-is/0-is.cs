using System;

/// <summary>
/// Obj class define an method to check type of object
/// </summary>
class Obj
{
    /// <summary>
    /// Method to chech if obj parameter is int type
    /// <param name="obj">integer</param>
    /// <returns>If obj is int True, else False</returns>
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int ;
    }
}
