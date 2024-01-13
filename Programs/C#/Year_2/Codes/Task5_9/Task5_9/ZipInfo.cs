public class ZipInfo
{
    char ch;
    int times;

    public ZipInfo(char ch, int times)
    {
        this.ch = ch;
        this.times = times;
    }

    public char Ch
    {
        get { return this.ch; }
        set { this.ch = value; }
    }

    public int Times
    {
        get { return this.times; }
        set { this.times = value; }
    }

    public override string ToString()
    {
        return $"{this.ch}:{this.times}";
    }
}

