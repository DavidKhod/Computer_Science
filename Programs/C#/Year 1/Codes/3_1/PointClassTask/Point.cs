using System;
class Point
{
    private double x;//The x position of the point
    private double y;//The y position of the point

    //Builds the object
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    //return the x 
    public double GetX()
    {
        return this.x;
    }

    //return the y
    public double GetY()
    {
        return this.y;
    }

    //Set the value of x
    public void SetX(double x)
    {
        this.x = x;
    }

    //Set the value of y
    public void SetY(double y)
    {
        this.y = y;
    }

    //Return the distance form point1 to point2
    public double Distance(Point other)
    {
        return Math.Sqrt((this.x - other.x) * (this.x - other.x) + (this.y - other.y) * (this.y - other.y));
    }

    //Return the middle point in between point1 and point2
    public Point Middle(Point other)
    {
        double x = (this.x - other.x) / 2;
        double y = (this.y - other.y) / 2;
        Point MiddlePoint = new Point(x, y);
        return MiddlePoint;
    }

    //returns the values of the Point
    public override string ToString()
    {
        string str = $"{x}|{y}";
        return str;
    }
}

