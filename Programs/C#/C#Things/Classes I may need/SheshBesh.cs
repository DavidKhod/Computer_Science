using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWithObjects_First
{
    class SheshBesh
    {
        private int dice1;
        private int dice2;


        public SheshBesh(int dice1,int dice2)
        {
            this.dice1 = dice1;
            this.dice2 = dice2;
        }

        public int Dice1
        {
            get { return this.dice1; }
            set { this.dice1 = value; }
        }

        public int Dice2
        {
            get { return this.dice2; }
            set { this.dice2 = value; }
        }

        public override string ToString()
        {
            return $"{dice1}:{dice2}";
        }
    }
}
