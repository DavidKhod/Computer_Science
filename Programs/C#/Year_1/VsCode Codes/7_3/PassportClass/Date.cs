namespace PassportClass
{
    public class Date 
    {
        private int day;
        private int month;
        private int year;

        public Date(int day = 0,int month = 0,int year = 0)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Date(Date other)
        {
            this.Day = other.Day;
            this.Month = other.Month;
            this.Year = other.Year;
        }

        public int Day
        {
            get{return this.day;}
            set{this.day = value;}
        }

        public int Month
        {
            get{return this.month;}
            set{this.month = value;}
        }

        public int Year
        {
            get{return this.year;}
            set{this.year = value;}
        }

        public int CompareTo(Date other)
        {
            if (this.year != other.year)
                return (this.year - other.year);
            if (this.month != other.month) 
                return (this.month - other.month);
            return (this.day - other.day);
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
