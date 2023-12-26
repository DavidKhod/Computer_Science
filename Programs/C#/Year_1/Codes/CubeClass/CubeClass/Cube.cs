using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeClass
{
    public class Cube
    {
        private double side;
        private string color;

        public Cube(double side, string color)
        {
            this.side = side;
            this.color = color;
        }

        public Cube(Cube other)
        {
            this.side = other.side;
            this.color = other.color;
        }

        public double Side
        {
            get { return this.side; }
            set { this.side = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        /// <summary>
        /// Checks if the pointer is equal to the Cube inputed
        /// </summary>
        /// <param name="other">The Cube comparing with</param>
        /// <returns>True if the Pointer is equal to the Cube inputed,False if not</returns>
        public bool Equals(Cube other)
        {
            return this.side == other.side && this.color == other.color;
        }

        public override string ToString()
        {
            return $"Side: {this.side},Color: {this.color}";
        }
    }
}
