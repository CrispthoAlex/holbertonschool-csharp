using System;

/// Abstract class named Base
public abstract class Base
{
    /// String Member of the class
    public string name = null;

    /// ToString method overrided
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
        
}
