public class Circle // כותרת המחלקה
{
    // תכונות העצם
    private double rad; // The radius of the circle
    private string color; // The color of the circle

    // הפעולה הבונה - המאתחלת את תכונות העצם
    public Circle(double rad, string color)
    {
        this.rad = rad;
        this.color = color;
    }

    // פעולה שמחזירה את המצב שלה
    public override string ToString()
    {
        string str = $"Radius = {this.rad} | Color = {this.color}";
        return str;
    }
    public double GetRadius()
    {
        return this.rad;
    }
    public string GetColor()
    {
        return this.color;
    }
    public void SetRadius(double newRad)
    {
        this.rad = newRad;
    }
    public void SetColor(string newColor)
    {
        this.color = newColor;
    }
    public void IncRadius()
    {
        this.rad++;
    }
}
