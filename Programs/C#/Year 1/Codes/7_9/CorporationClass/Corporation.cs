using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationClass
{
    class Corporation
    {
        private Group[] groups;

        public Corporation()
        {
            this.groups = new Group[30];
        }
        
        public bool AddTeam(Group newTeam)
        {
            bool foundNull = false;
            int cnt = 0;
            for (int i = 0; i < groups.Length && foundNull == false; i++)
            {
                if (this.groups[i] != null)
                {
                    foundNull = true;
                }
                cnt++;
            }
            if (foundNull)
            {
                this.groups[cnt] = new Group(newTeam);
                return true;
            }
            return false;
        }

        public void PrintTeamDetails()
        {
            bool foundNull = false;
            string print = "";
            for (int i = 0; i < 30 && foundNull == false; i++)
            {
                if (this.groups[i] != null)
                {
                    print += $"{this.groups[i].ToString()}\n";
                }
                else
                {
                    foundNull = true;
                }
            }
            Console.WriteLine($"{print}");
        }

        public double AveragePoints()
        {
            double avg = 0;
            int cnt = 0;
            while (this.groups[cnt] != null)
            {
                int num = 0;
                num += this.groups[cnt].CalculateSumPoints() / this.groups[cnt].CurrentPlayerAmount;
                avg += num;
            }
            avg /= cnt;
            return avg;
        }

        public override string ToString()
        {
            bool foundNull = false;
            string print = "";
            for (int i = 0; i < 30 && foundNull == false; i++)
            {
                if (this.groups[i] != null)
                {
                    print += $"{this.groups[i].ToString()}\n";
                }
                else
                {
                    foundNull = true;
                }
            }
            return print;
        }

        


    }
}
