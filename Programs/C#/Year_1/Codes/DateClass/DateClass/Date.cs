class Date
{
    private int day;//The day in the year
    private int month;//The month in the year
    private int year;//The year

    /// <summary>
    /// Constructor of Date
    /// </summary>
    /// <param name="day">The day in the year</param>
    /// <param name="month">The month in the year</param>
    /// <param name="year">The year</param>
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    /// <summary>
    /// Get Year
    /// </summary>
    /// <returns>The value of "year" in int</returns>
    public int GetYear()
    {
        return this.year;
    }

    /// <summary>
    /// Get Month
    /// </summary>
    /// <returns>The value of "month" in int</returns>
    public int GetMonth()
    {
        return this.month;
    }

    /// <summary>
    /// Get Day
    /// </summary>
    /// <returns>The value of "Day" in int</returns>
    public int GetDay()
    {
        return this.day;
    }

    /// <summary>
    /// Sets the integer "year" 
    /// </summary>
    /// <param name="yearToSet">The new value of "year"</param>
    public void SetYear(int yearToSet)
    {
        this.year = yearToSet;
    }

    /// <summary>
    /// Sets the integer "month"
    /// </summary>
    /// <param name="monthToSet">The new value of "month"</param>
    public void SetMonth(int monthToSet)
    {
        this.month = monthToSet;
    }

    /// <summary>
    /// Sets the integer "day"
    /// </summary>
    /// <param name="dayToSet">The ne value of "day"</param>
    public void SetDay(int dayToSet)
    {
        this.day = dayToSet;
    }

    /// <summary>
    /// Comparse Dates
    /// </summary>
    /// <param name="other">The date compared to</param>
    /// <returns>-1 if the other date is is later,0 if the dates are the same,1 if the other date is sooner</returns>
    public int CompareTo(Date other)
    {
        if (this.year > other.year || this.month > other.month || this.day > other.day)
        {
            return 1;
        }
        else if (this.year < other.year || this.month < other.month || this.day < other.day)
        {
            return -1;
        }
        return 0;
    }

    /// <summary>
    /// Converts the integers day,month,year to string
    /// </summary>
    /// <returns>A string of day/month/year</returns>
    public override string ToString()
    {
        return $"{this.day}/{this.month}/{this.year}";
    }
}

