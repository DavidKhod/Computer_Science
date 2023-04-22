
class Date
{
    private int day;
    private int month;
    private int year;

    /// <summary>
    /// Constructor of Date
    /// </summary>
    /// <param name="day">The day </param>
    /// <param name="month">The month</param>
    /// <param name="year">The year</param>
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    /// <summary>
    /// Constructor of Date by Copying The input
    /// </summary>
    /// <param name="other">The Date coying</param>
    public Date(Date other)
    {
        this.day = other.day;
        this.month = other.month;
        this.year = other.year;
    }

    public int GetDay()
    {
        return this.day;
    }

    public int GetMonth()
    {
        return this.month;
    }

    public int GetYear()
    {
        return this.year;
    }

    public void SetDay(int newDay)
    {
        this.day = newDay;
    }

    public void SetMonth(int newMonth)
    {
        this.month = newMonth;
    }

    public void SetYear(int newYear)
    {
        this.year = newYear;
    }


    /// <summary>
    /// Compares two inputed Dates
    /// </summary>
    /// <param name="other">The date compared to</param>
    /// <returns>-1 of The date pointed at is Earlier, 1 if the Date inputed is The Earlier, 0 if The Dates are The same</returns>
    public int CompareTo(Date other)
    {
        if (this.year < other.year)
        {
            return -1;
        }
        else if (this.year > other.year)
        {
            return 1;
        }
        if (this.month < other.month)
        {
            return -1;
        }
        else if (this.month > other.month)
        {
            return 1;
        }
        if (this.day < other.day)
        {
            return -1;
        }
        else if (this.day > other.day)
        {
            return 1;
        }
        return 0;
    }

    /// <summary>
    /// Creates a new Date that its Day is the next day from The Date pointed at
    /// </summary>
    /// <returns>A Date with the value of Day equal to the next day from the Date pointed at </returns>
    public Date NextDay()
    {
        Date nextDay = new Date(this);
        nextDay.day++;
        if (nextDay.month == 2)
        {
            if (nextDay.year % 4 == 0)
            {
                if (nextDay.day > 29)
                {
                    nextDay.day = 1;
                    nextDay.month = 3;
                }
            }
            else
            {
                if (nextDay.day > 28)
                {
                    nextDay.day = 1;
                    nextDay.month = 3;
                }
            }
        }
        if (this.month == 12)
        {
            if (nextDay.day > 31)
            {
                nextDay.day = 1;
                nextDay.month = 1;
                nextDay.year++;
            }
        }
        if (nextDay.month == 1 || nextDay.month == 3 || nextDay.month == 5 || nextDay.month == 7 || nextDay.month == 8 || nextDay.month == 10)
        {
            if (nextDay.day > 31)
            {
                nextDay.day = 1;
                nextDay.month++;
            }
        }
        if (nextDay.month == 4 || nextDay.month == 6 || nextDay.month == 9 || nextDay.month == 11)
        {
            if (nextDay.day > 30)
            {
                nextDay.day = 1;
                nextDay.month++;
            }
        }
        return nextDay;
    }
    /// <summary>
    /// Finds the Earlier date between the two dates inputed
    /// </summary>
    /// <param name="other">The second Date compared to</param>
    /// <returns>The Earlier Date between the pointed Date and the inputed Date,if the Dates are the same it returns the Date pointed at</returns>
    public Date EarlierDate(Date other)
    {
        if (this.year < other.year)
        {
            return this;
        }
        else if (this.year > other.year)
        {
            return other;
        }
        if (this.month < other.month)
        {
            return this;
        }
        else if (this.month > other.month)
        {
            return other;
        }
        if (this.day < other.day)
        {
            return this;
        }
        else if (this.day > other.day)
        {
            return other;
        }
        return this;
    }

    /// <summary>
    /// Converts the Values of Day,Month,Year to string
    /// </summary>
    /// <returns>As a string the values of Day,Month,Year(Day/Month/Year)</returns>
    public override string ToString()
    {
        return $"{this.day}/{this.month}/{this.year}";
    }

}

