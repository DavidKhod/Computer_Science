using System;

namespace PassportClass
{
    public class Passport
    {
        private string name;
        private int number;
        private Date? expiryDate;
        public Passport(string name = "",int number = 0,Date? expiryDate = null)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }

        public Passport(Passport other)
        {
            this.name = other.name;
            this.number = other.number;
            this.ExpiryDate = other.expiryDate;
        }

        public string UserName
        {
            get{return this.name;}
            set{this.name = value;}
        }

        public int Number
        {
            get{return this.number;}
            set{this.number = value;}
        }

        public Date ExpiryDate
        {
            get{return this.expiryDate;}
            set{this.expiryDate = value;}
        }
 
        public bool? IsValid(Date other)
        {
            if(this.ExpiryDate.CompareTo(other) >= 0)
                return true;
            return null;
        }

        public override string ToString()
        {
            return $"Name: {this.name},Number: {number},Expiry date: {this.expiryDate.ToString()}";
        }
    }
}