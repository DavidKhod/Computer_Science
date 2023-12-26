using System;
class Point
{
    private double x;//The x axis of the point
    private double y;//The y axis of the point

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="x">The x axis of the point</param>
    /// <param name="y">The y axis of the point</param>
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    /// <summary>
    /// Gets the x axis of the point
    /// </summary>
    /// <returns>The x axis of the point</returns>
    public double GetX()
    {
        return this.x;
    }

    /// <summary>
    /// Gets the y axis of the point
    /// </summary>
    /// <returns>The y axis of the point</returns>
    public double GetY()
    {
        return this.y;
    }



    /// <summary>
    /// Sets the x axis
    /// </summary>
    /// <param name="x">The x axis</param>
    public void SetX(double x)
    {
        this.x = x;
    }

    /// <summary>
    /// Sets the y axis of the point
    /// </summary>
    /// <param name="y">The y axis</param>
    public void SetY(double y)
    {
        this.y = y;
    }

   /// <summary>
   /// Calculates the distance form two points
   /// </summary>
   /// <param name="other">The point compared to</param>
   /// <returns>The distance in between the points as a double</returns>
    public double Distance(Point other)
    {
        return Math.Sqrt((this.x - other.x) * (this.x - other.x) + (this.y - other.y) * (this.y - other.y));
    }

    /// <summary>
    /// Calculates the middle point in between two points
    /// </summary>
    /// <param name="other">The point compared to</param>
    /// <returns>The middle point as a Point</returns>
    public Point Middle(Point other)
    {
        double x = (this.x - other.x) / 2;
        double y = (this.y - other.y) / 2;
        Point MiddlePoint = new Point(x, y);
        return MiddlePoint;
    }

    /// <summary>
    /// Converts the values of the serial number,x axis,y axis to a string
    /// </summary>
    /// <returns>The values of the point as a string (Serial number: "" ,x axis, y axis)</returns>
    public override string ToString()
    {
        string str = $"Serial number: {this.x}|{this.y}";
        return str;
    }
}

