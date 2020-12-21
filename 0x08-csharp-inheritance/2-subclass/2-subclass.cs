using System;

/// <summary>
/// Obj class define an method to check type of object
/// </summary>
class Obj
{
    /// <summary>
    /// Method to check if the object is a subclass of an specify class.
    /// <param name="derivedType">Object to check</param>
    /// <param name="baseType">base class</param>
    /// <returns>True, If derivedType is a subclass of baseType, else False</returns>
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType) ;
    }
}
