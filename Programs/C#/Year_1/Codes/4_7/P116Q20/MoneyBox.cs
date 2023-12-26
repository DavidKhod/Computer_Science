using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P116Q20
{
    class MoneyBox
    {
        private string cashier;//Cashier's name
        private double money;//income amount

        public MoneyBox(string cashier)
        {
            this.cashier = cashier;
        }

        public string Cashier
        {
            get { return this.cashier; }
            set { this.cashier = value; }
        }

        public double Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public override string ToString()
        {
            return $"Cashier: {this.cashier},Money: {this.money}";
        }
    }
}
