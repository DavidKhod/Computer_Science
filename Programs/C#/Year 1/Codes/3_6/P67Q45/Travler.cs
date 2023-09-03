using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P67Q45
{
    class Travler
    {
        private string name;
        private int age;
        private int yearAmount;

        public Travler(string name,int age,int yearAmount)
        {
            this.name = name;
            this.age = age;
            this.yearAmount = yearAmount;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public int GetYearAmont()
        {
            return this.yearAmount;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetYearAmount(int yearAmount)
        {
            this.yearAmount = yearAmount;
        }

        public string Tostring()
        {
            return $"Name: {name},Age: {age},Amount of years with Nature Protection Authority subscription: {yearAmount}";
        }

    }
}
