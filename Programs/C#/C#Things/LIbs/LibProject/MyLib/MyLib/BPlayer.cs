public class BPlayer
{
    private string name;
    private double height;
    private int score;

    public BPlayer(string name, double height, int points)
    {
        this.name = name;
        this.height = height;
        this.score = points;
    }

    public BPlayer(string name,double height)
    {
        this.name = name;
        this.height = height;
        this.score = 0;
    }

    public string Name
    {
        get { return this.name; }
    }

    public double Height
    {
        get { return this.height; }
    }

    public int Score
    {
        get { return this.score; }
        set { this.score = value; }
    }

    public override string ToString()
    {
        return $"Name: {name}|Height: {height},Score: {score} ";
    }
}

