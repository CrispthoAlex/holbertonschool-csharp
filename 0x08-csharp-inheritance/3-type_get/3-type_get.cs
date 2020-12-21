using System;
using System.Collections.Generic;
using System.Reflection; // Reflection Represents type declarations for class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types.

/// <summary>
/// Obj class define an method to print object information
/// </summary>
class Obj
{
    /// <summary>
    /// Method to print the names of the available properties and methods
    /// of an object.
    /// <param name="myObj">Object to print self properties and methods</param>
    /// <returns>void</returns>
    /// </summary>
    public static void Print(object myObj)
    {
        // Save object information
        TypeInfo objInfo = myObj.GetType().GetTypeInfo();
        // Save  in a list properties and methods of an Object
        IEnumerable<PropertyInfo> propList = objInfo.GetProperties() ;
        IEnumerable<MethodInfo> meList = objInfo.GetMethods() ;

        
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (PropertyInfo prop in propList)
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (MethodInfo me in meList)
        {
            Console.WriteLine(me.Name);
        }
     }
}
