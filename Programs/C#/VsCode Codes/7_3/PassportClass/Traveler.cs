using System;

namespace PassportClass
{
    public class Travler
    {
        Passport passport;
        bool hasPaid;

        public Travler(Passport passport,bool hasPaid = false)
        {
            this.passport = passport;
            this.hasPaid = hasPaid; 
        }

        public void Pay()
        {
            this.hasPaid = true;
        }

        public bool? HasPaid()
        {
            if(hasPaid == true)
                return true;
            return null;
        }

        public bool? CheckTravel(Date travelDate)
        {
            if(this.passport.ExpiryDate.CompareTo(travelDate) >= 0)
                return true;
            return null;
        }

        public override string ToString()
        {
            return $"{passport.ToString()},Paid: {this.hasPaid}";
        }
    }
}