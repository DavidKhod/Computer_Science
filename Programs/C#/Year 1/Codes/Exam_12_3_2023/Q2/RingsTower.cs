class RingsTower
{
    private int n;
    private int biggest;
    private int diff;

    public RingsTower(int n, int biggest, int diff)
    {
        this.n = n;
        this.biggest = biggest;
        this.diff = diff;
    }

    public int getN()
    {
        return this.n;
    }

    public int getdiff()
    {
        return this.diff;
    }

    public int getBiggest()
    {
        return this.biggest;
    }

    public RingsTower RemoveTop(int num)
    {
        if (num >= this.n)
        {
            return null;
        }
        RingsTower R1 = new RingsTower(this.n - num, this.biggest, this.diff);
        return R1;
    }

    public bool Exist(int num)
    {
        for (int i = 0; i <= this.n; i++)
        {
            if (this.biggest - i * diff == num)
            {
                return true;
            }
        }
        return false;
    }

    public void AddRings(int num)
    {
        this.n += num;
    }

    public bool CanMerge(RingsTower other)
    {
        if (this.diff != other.diff)
        {
            return false;
        }
        int smallest = this.biggest;
        for (int i = 1; i <= this.n; i++)
        {
            if (this.biggest - i * diff < smallest)
            {
                smallest = this.biggest - i * diff;
            }
        }
        int otherSmallest = other.biggest;
        for (int i = 1; i <= other.n; i++)
        {
            if (other.biggest - i * diff < otherSmallest)
            {
                otherSmallest = other.biggest - i * other.diff;
            }
        }
        if (smallest + diff == other.biggest || smallest - diff == other.biggest || this.biggest + diff == other.biggest || this.biggest - diff == otherSmallest)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        string Tower = $"|{this.biggest}| ";
        for (int i = 1; i <= this.n; i++)
        {
            Tower += $"|{this.biggest - i * diff}| ";
        }
        return Tower;
    }
}

