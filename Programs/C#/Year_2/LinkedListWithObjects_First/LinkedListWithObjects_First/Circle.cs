using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWithObjects_First
{
    public class Circle
    {
        private double r;
        private string color; 

        public Circle(double rad, string color)
        {
            this.r = rad;
            this.color = color;
        }

        public double R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            string str = $"Radius = {this.r} | Color = {this.color}";
            return str;
        }
    }
}
