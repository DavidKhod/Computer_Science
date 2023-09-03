using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationClass
{
    class Player
    {
        private string name;
        private double height;
        private int points;

        public Player(string name,double height,int points)
        {
            this.name = name;
            this.height = height;
            this.points = points;
        }

        public Player(Player newPlayer)
        {
            this.name = newPlayer.name;
            this.height = newPlayer.height;
            this.points = newPlayer.points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.name},Height {this.height},Points: {this.points}";
        }
    }
}
