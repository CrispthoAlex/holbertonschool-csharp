using System;

/// <summary>
/// Shape class define a Area method.
/// </summary>
public class Shape
{
    /// <summary>
    /// Method to calculate Area.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class is defined
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Public property named Width.
    /// </summary>
    public int Width
    {
        get { return width; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0") ;
            else
                width = value ;
        }
    }
    /// <summary>
    /// Public property named Height.
    /// </summary>
    public int Height
    {
        get { return height; }
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0") ;
            else
                height = value ;
        }
    }
    /// <summary>
    /// Public method named Area that overrides Area method from Shape class.
    /// </summary>
    public override int Area() => width * height ;

    /// <summary>
    /// Public method to override ToString method.
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}" ;
    }
}
/// <summary>
/// Square class that inherits from Rectangle.
/// </summary>
public class Square : Rectangle
{
    private int size;
    /// <summary>
    /// Public property to define size.
    /// </summary>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0") ;
            else
                size = this.Width = this.Height = value ;
        }       
    }
    /// <summary>
    /// Public method to override ToString method
    /// and print a representation.
    /// </summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}" ;
    }
}
