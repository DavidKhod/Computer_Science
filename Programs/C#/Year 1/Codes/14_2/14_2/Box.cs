using System;
public class Box
{
    private double length;
    private double width;
    private double height;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="length">The length of the box</param>
    /// <param name="width">The width of the box</param>
    /// <param name="height">The height of the box</param>
    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="size">The size of the cube</param>
    public Box(double size)
    {
        this.length = size;
        this.width = size;
        this.height = size;
    }

    /// <summary>
    /// Get Length
    /// </summary>
    /// <returns>The length of the box</returns>
    public double GetLength()
    {
        return this.length;
    }

    /// <summary>
    /// Get Width
    /// </summary>
    /// <returns>The width of the box</returns>
    public double GetWidth()
    {
        return this.width;
    }

    /// <summary>
    /// Get Height
    /// </summary>
    /// <returns>The height of the box</returns>
    public double GetHeight()
    {
        return this.height;
    }

    /// <summary>
    /// Sets the Length of the box
    /// </summary>
    /// <param name="length">The length of the box</param>
    public void SetLength(double length)
    {
        this.length = length;
    }

    /// <summary>
    /// Sets the width of the box
    /// </summary>
    /// <param name="width">The width of the box</param>
    public void SetWidth(double width)
    {
        this.width = width;
    }

    /// <summary>
    /// Sets the Height of the box
    /// </summary>
    /// <param name="height">The height of the box</param>
    public void SetHeight(double height)
    {
        this.height = height;
    }

    /// <summary>
    /// Get Volume
    /// </summary>
    /// <returns>The volume of the box</returns>
    public double GetVolume()
    {
        return (this.length * this.width * this.height);
    }

    /// <summary>
    /// Converts the values of Length,Width,Height to a string (Length = "",Width = "",Height = "")
    /// </summary>
    /// <returns>In string the values of Length,width,height</returns>
    public override string ToString()
    {
        string str = $"Length = {this.length},Width = {this.width},Height = {this.height}";
        return str;
    }
}