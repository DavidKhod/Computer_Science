class Ad
{
    private string nameOfAd;
    private string companyName;
    private int duration;

    public Ad(string nameOfAd = "", string companyName = "", int duration = 0)
    {
        this.nameOfAd = nameOfAd;
        this.companyName = companyName;
        this.duration = duration;
    }

    public string NameOfAd
    {
        get { return this.nameOfAd; }
        set { this.nameOfAd = value; }
    }

    public string CompanyName
    {
        get { return this.companyName; }
        set { this.companyName = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }

    public override string ToString()
    {
        return $"Name: {NameOfAd},By: {CompanyName},Duration: {Duration}";
    }
}

