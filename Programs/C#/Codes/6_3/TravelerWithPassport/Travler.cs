using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerWithPassport
{
    public class Travler
    {
        private Passport passport;
        private bool hasPaid;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="passport">The passport class variable of the Travler</param>
        /// <param name="hasPaid">The boolien if the Travler paid or not</param>
        public Travler(Passport passport = null, bool hasPaid = false)
        {
            this.passport = passport;
            this.hasPaid = hasPaid;
        }


        public Passport ETPassport
        {
            get { return this.passport; }
            set { this.passport = value; }
        }

        public bool ETHasPaid
        {
            get { return this.hasPaid; }
            set { this.hasPaid = value; }
        }

        /// <summary>
        /// Make the HasPaid boolien equal to True
        /// </summary>
        public void Pay()
        {
            this.hasPaid = true;
        }

        /// <summary>
        /// Checks if the Travler paid
        /// </summary>
        /// <returns>True if the Travler paid(boolien HasPaid = true), Null if not</returns>
        public bool? HasPaid()
        {
            if (hasPaid == true)
                return true;
            return null;
        }

        /// <summary>
        /// Checks if the ExpiryDate Date variable is sooner than the Date inputed
        /// </summary>
        /// <param name="travelDate">The Date variable checking with</param>
        /// <returns>True if the ExpiryDate Date is sooner, Null if not</returns>
        public bool? CheckTravel(Date travelDate)
        {
            if (this.passport.ExpiryDate.CompareTo(travelDate) >= 0)
                return true;
            return null;
        }
        /// <summary>
        /// Converts the values of Passport,hasPaid into string
        /// </summary>
        /// <returns>The values of passport,hasPaid into string(passport.ToString(),Paid: (True or False))</returns>
        public override string ToString()
        {
            return $"{passport.ToString()}, Paid: {this.hasPaid}";
        }
    }
}
