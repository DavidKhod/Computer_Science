using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationClass
{
    class Group
    {
        private string name;
        private int currentPlayerAmount;
        private Player[] players;


        public Group(string name,int playerAmount)
        {
            this.players = new Player[20];
            this.name = name;
            this.currentPlayerAmount = playerAmount;
        }

        public Group(Group newGroup)
        {
            this.name = newGroup.name;
            this.currentPlayerAmount = newGroup.currentPlayerAmount;
            this.players = new Player[20];
            for (int i = 0; i < newGroup.currentPlayerAmount; i++)
                this.players[i] = new Player(newGroup.players[i]);

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int CurrentPlayerAmount
        {
            get { return this.currentPlayerAmount; }
            set { this.currentPlayerAmount = value; }
        }

        public Player[] Players()
        {
            Player[] newPlayers = new Player[this.players.Length];
            for (int i = 0; i < this.currentPlayerAmount; i++)
            {
                newPlayers[i] = new Player(this.players[i]);
            }
            return newPlayers;
        }

        public bool AddPlayer(Player newPlayer)
        {
            if (this.currentPlayerAmount < 20)
            {
                this.players[this.currentPlayerAmount] = new Player(newPlayer);
                this.currentPlayerAmount++;
                return true;
            }
            return false;
        }

        public int CalculateSumPoints()
        {
            int sum = 0;
            for (int i = 0; i < this.currentPlayerAmount; i++)
            {
                sum += this.players[i].Points;
            }
            return sum;
        }

        public override string ToString()
        {
            string print = $"Name: {this.name},Current player amount: {this.currentPlayerAmount}\n";
            for (int i = 0; i < this.currentPlayerAmount; i++)
            {
                print += $"{players[i].ToString()}\n";
            }
            return print;
        }
    }
}
