
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

    public double Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
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


