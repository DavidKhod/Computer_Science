using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketClass
{
    class Bucket
    {
        private int capacity;
        private int CurrentAmountWater = 0;

        public Bucket(int capacity)
        {
            this.capacity = capacity;
        }

        public double GetCapacity()
        {
            return this.capacity;
        }

        public void Empty()
        {
            this.CurrentAmountWater = 0;
        }

        public bool IsEmpty()
        {
            if (CurrentAmountWater == 0)
            {
                return true;
            }
            return false;
        }

        public void Fill(int amountToFill)
        {
            if (this.CurrentAmountWater + amountToFill <= this.capacity)
            {
                this.CurrentAmountWater += amountToFill;
            }
            else
            {
                this.CurrentAmountWater = capacity;
            }
        }

        public void PourInTo(Bucket other)
        {
            other.CurrentAmountWater += this.CurrentAmountWater;
            this.CurrentAmountWater = 0;
            if ((other.CurrentAmountWater > other.capacity))
            {
                this.CurrentAmountWater = Math.Abs(other.CurrentAmountWater - other.capacity);
                other.CurrentAmountWater -= Math.Abs(other.CurrentAmountWater - other.capacity);
            }
        }

        public override string ToString()
        {
            return $"The capacity is {this.capacity}, The amount of water is {CurrentAmountWater}";
        }
    }
}
