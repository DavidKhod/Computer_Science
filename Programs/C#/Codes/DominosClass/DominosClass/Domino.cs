using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DominosClass
{
    class Domino
    {
        static Random rnd = new Random();

        private int side1;//Side one of the domino
        private int side2;//Side two of the domino

        /// <summary>
        /// Constructor, creates a random domino with both sides randomized from 1 to 6
        /// </summary>
        public Domino()
        {
            this.side1 = rnd.Next(1, 7);
            this.side2 = rnd.Next(1, 7);
        }

        /// <summary>
        /// Gets the value of first side
        /// </summary>
        /// <returns>The value of the first side as an integer</returns>
        public int GetSide1()
        {
            return this.side1;
        }

        /// <summary>
        /// Gets the value of the second side
        /// </summary>
        /// <returns>The value of the second side as an integer</returns>
        public int GetSide2()
        {
            return this.side2;
        }

        /// <summary>
        /// Chceck if the dominos can be connected
        /// </summary>
        /// <param name="other">The other domino</param>
        /// <returns>True if the Dimonos are compabtle,False if the Dimonos are not compatble</returns>
        public bool IsConnectable(Domino other)
        {
            if (this.side1 == other.side1 || this.side1 == other.side2 || this.side2 == other.side1 || this.side2 == other.side2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Converts the values of the first side and second side into a string
        /// </summary>
        /// <returns>The values of the first side and the second side as a string(side1|side2)</returns>
        public override string ToString()
        {
            return $"{side1}|{side2}";
        }
    }
}
