using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerWithPassport
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="day">The day</param>
        /// <param name="month">The month</param>
        /// <param name="year">The year</param>
        public Date(int day = 0, int month = 0, int year = 0)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        /// <summary>
        /// Copying constructor
        /// </summary>
        /// <param name="other"></param>
        public Date(Date other)
        {
            this.Day = other.Day;
            this.Month = other.Month;
            this.Year = other.Year;
        }

        /// <summary>
        /// Sets or Gets the value day
        /// </summary>
        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }
        /// <summary>
        /// Sets or Gets the value of month
        /// </summary>
        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        /// <summary>
        /// sets or Gets the value of year
        /// </summary>
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        /// <summary>
        /// Compares the pointer with the date inputed
        /// </summary>
        /// <param name="other">The date comparing with</param>
        /// <returns>Negative value if the pointer is sooner,0 if they are the same,Positive value if the inputed Date is sooner</returns>
        public int CompareTo(Date other)
        {
            if (this.year != other.year)
                return (this.year - other.year);
            if (this.month != other.month)
                return (this.month - other.month);
            return (this.day - other.day);
        }
        /// <summary>
        /// Converts the value of day,month,year into string
        /// </summary>
        /// <returns>"(day)/(month)/(year)"</returns>
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
