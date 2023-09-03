using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeriesClass
{
    class MathSeries
    {
        private double firstnum;//The first number in the series
        private double diff;//The difference between each pair
        private int numAmount;//The amount of number with in the series

        /// <summary>
        /// Construcor,Creats a math series
        /// </summary>
        /// <param name="firstnum">The first number in the series</param>
        /// <param name="diff">The difference from each number to the next</param>
        /// <param name="numAmount">The length/amount of the numbers in the series</param>
        public MathSeries(double firstnum,double diff,int numAmount)
        {
            this.firstnum = firstnum;
            this.diff = diff;
            this.numAmount = numAmount;
        }

        /// <summary>
        /// Sets the length/amount of number within the series
        /// </summary>
        /// <param name="newNUmAmount">The new length/amount of numbers within the series</param>
        public void SetNumAmount(int newNUmAmount)
        {
            this.numAmount = newNUmAmount;
        }

        /// <summary>
        /// Calculates the value of the number in the place inputed
        /// </summary>
        /// <param name="placeInSeries">The place of the num in the series</param>
        /// <returns>The value of the num in the place inputed within the series</returns>
        public double GetValueof(int placeInSeries)
        {
            double value = this.firstnum;
            for (int i = 1; i <= placeInSeries; i++)
            {
                value += diff;
            }
            return value;
        }

        /// <summary>
        /// Calculates the whole math series and converts it to a string
        /// </summary>
        /// <returns>The Whole math series as a string</returns>
        public override string ToString()
        {
            string theSeries = $"{this.firstnum}, ";
            double num = this.firstnum;
            for (int i = 2; i <= numAmount; i++)
            {
                num += this.diff;
                if (i != numAmount)
                {
                    theSeries += $"{num}, ";
                }
                else
                {
                    theSeries += $"{num}";
                }
            }
            return theSeries;
        }

    }
}
