using System;
namespace RationalClass
{
    /// <summary>
    /// Fraction
    /// </summary>
    class Rational
    {
        private int x;//Numerator
        private int y;//denominator

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">The Numerator</param>
        /// <param name="y">The denominator</param>
        public Rational(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Gets The Numerator
        /// </summary>
        /// <returns>The Numerator of the rational</returns>
        public int GetNumerator()
        {
            return this.x;
        }

        /// <summary>
        /// Gets the Denominator
        /// </summary>
        /// <returns>The denominator of the rational</returns>
        public int GetDenominator()
        {
            return this.y;
        }

        /// <summary>
        /// Checks if both rationals are the same
        /// </summary>
        /// <param name="other">The rational compared to</param>
        /// <returns>true if the rationals are the same,false if rationals are to the same</returns>
        public bool IsEqual(Rational other)
        {
            if (this.x == other.x && this.y == other.y)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Multiplies the first rational by the other one
        /// </summary>
        /// <param name="other">The rational multiplied by</param>
        /// <returns>The result as a new rational</returns>
        public Rational Multiply(Rational other)
        {
            Rational multiplied = new Rational(this.x * other.x, this.y * other.y);
            return multiplied;
        }

        /// <summary>
        /// Divides the first rational by the other one
        /// </summary>
        /// <param name="other">The rational divided by</param>
        /// <returns>The result as a new Rational, if the denominator of "other" rational isn't equal to zero,null if the denominator of rational "other" is equal to zero</returns>
        public Rational Divide(Rational other)
        {
            if (this.y != 0 && other.x != 0)
            {
                Rational Divided = new Rational(this.x * other.y, this.y * other.x);
                return Divided;
            }
            return null;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>The values of the Numerator,denominator as a string (Numerator/denominator)</returns>
        public override string ToString()
        {
            return $"{this.x}/{this.y}";
        }

        //חלק ב'
        /// <summary>
        /// Calculates the sum of the first Rational plus the other Rational
        /// </summary>
        /// <param name="other">The Rational Added by</param>
        /// <returns>The sum/result as a new Rational</returns>
        public Rational Plus(Rational other)
        {
            if (this.y == other.y)
            {
                Rational Plus = new Rational(this.x + other.x, this.y);
                return Plus;
            }
            int Max, Min;
            Max = Math.Max(this.y, other.y);
            Min = Math.Min(this.y, other.y);
            int whichIsMin;
            if (Min == this.y)
            {
                whichIsMin = this.y;
            }
            else
            {
                whichIsMin = other.y;
            }
            for (int i = 1; i <= Max; i++)
            {
                if (Min * i == Max)
                {
                    if (whichIsMin == this.y)
                    {
                        this.y *= i;
                        this.x *= i;
                        Rational Plus = new Rational(this.x + other.x, Max);
                        return Plus;
                    }
                    else
                    {
                        other.y *= i;
                        other.x *= i;
                        Rational Plus = new Rational(other.x + this.x, Max);
                        return Plus;
                    }
                }
            }
            Rational Plus2 = new Rational((this.x * this.y) + (other.x * this.y), this.y * other.y);
            return Plus2;
        }

        /// <summary>
        /// Calculates the sum of the first Rational minus the other Rational
        /// </summary>
        /// <param name="other">The Rational minused by</param>
        /// <returns>The sum/result as a new Rational</returns>
        public Rational Minus (Rational other)
        {
            if (this.y == other.y)
            {
                Rational minus = new Rational(this.x - other.x, this.y);
                return minus;
            }
            int Max, Min;
            Max = Math.Max(this.y, other.y);
            Min = Math.Min(this.y, other.y);
            int whichIsMin;
            if (Min == this.y)
            {
                whichIsMin = this.y;
            }
            else
            {
                whichIsMin = other.y;
            }
            for (int i = 1; i <= Max; i++)
            {
                if (Min * i == Max)
                {
                    if (whichIsMin == this.y)
                    {
                        this.y *= i;
                        this.x *= i;
                        Rational minus = new Rational(this.x - other.x, Max);
                        return minus;
                    }
                    else
                    {
                        other.y *= i;
                        other.x *= i;
                        Rational minus = new Rational(other.x - this.x, Max);
                        return minus;
                    }
                }
            }
            Rational minus2 = new Rational((this.x * this.y) - (other.x * this.y), this.y * other.y);
            return minus2;
        }
    }
}
