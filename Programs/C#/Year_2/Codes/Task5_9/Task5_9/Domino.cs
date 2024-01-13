
public class Domino
{
    private int side1;//Side one of the domino
    private int side2;//Side two of the domino

    /// <summary>
    /// Constructor
    /// </summary>
    public Domino(int side1, int side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public int Side1
    {
        get { return this.side1; }
        set { this.side1 = value; }
    }

    public int Side2
    {
        get { return this.side2; }
        set { this.side2 = value; }
    }

    public bool Contains(int num)
    {
        return (side1 == num || side2 == num);
    }

    /// <summary>
    /// Chceck if the dominos can be connected
    /// </summary>
    /// <param name="other">The other domino</param>
    /// <returns>True if the Dimonos are compabtle,False if the Dimonos are not compatble</returns>
    public bool IsConnectable(Domino other)
    {
        if (Contains(other.side1) || Contains(other.side2))
            return true;
        return false;
    }

    /// <summary>
    /// Converts the values of the first side and second side into a string
    /// </summary>
    /// <returns>The values of the first side and the second side as a string(side1|side2)</returns>
    public override string ToString()
    {
        return $"{side1}|{side2}";
    }
}

