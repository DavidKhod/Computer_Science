using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerWithPassport
{
    public class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name on the Passport</param>
        /// <param name="number">The number of the Passport</param>
        /// <param name="expiryDate">The expiry date of the Passport</param>
        public Passport(string name = "", int number = 0, Date expiryDate = null)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }

        /// <summary>
        /// Coying Constructor
        /// </summary>
        /// <param name="other">The Passport copying</param>
        public Passport(Passport other)
        {
            this.name = other.name;
            this.number = other.number;
            this.ExpiryDate = other.expiryDate;
        }
        /// <summary>
        /// Sets or Gets the value of name on the Passport
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        /// <summary>
        /// Sets or Gets the value of the number of the Passport
        /// </summary>
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        /// <summary>
        /// Sets or Gets the value of the expiry date of the Passport
        /// </summary>
        public Date ExpiryDate
        {
            get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }
        /// <summary>
        /// Checks if the expiry date of the passport is not due to the Date inputed
        /// </summary>
        /// <param name="other">The date comparing to</param>
        /// <returns>True if the expiry date Date in not due,Null if not</returns>
        public bool? IsValid(Date other)
        {
            if (this.ExpiryDate.CompareTo(other) >= 0)
                return true;
            return null;
        }
        /// <summary>
        /// Converts the values of name,number,expiryDate into string
        /// </summary>
        /// <returns>"Name: (the value of name),Number: (the value of number),Expiry Date: (the values of expiryDate)"</returns>
        public override string ToString()
        {
            return $"Name: {this.name}, Number: {number}, Expiry date: {this.expiryDate.ToString()}";
        }
    }
}
