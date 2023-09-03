using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace BankQ_22_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name, number;
            int MoneyAmount,DepositMoneyAmount,WithdrawlMoneyAmount,Option;
            Console.WriteLine("Enter the name of the owner of the account");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the account's number");
            number = Console.ReadLine();
            Console.WriteLine("Enter the amount of money currently is the account");
            MoneyAmount = int.Parse(Console.ReadLine());
            BankAccount Account1 = new BankAccount(Name,number,MoneyAmount);
            Console.WriteLine("Enter what action you want to do");
            Console.WriteLine("0=Withdrawl    1=Deposit");
            Option = int.Parse(Console.ReadLine());
            if (Option==1)
            {
                Console.WriteLine("Enter the amount of money you would like to deposit");
                DepositMoneyAmount = int.Parse(Console.ReadLine());
                Account1.DepositMoney(DepositMoneyAmount);
            }
            else if (Option==0)
            {
                Console.WriteLine("Enter the amount of money you want to Withdrawl");
                WithdrawlMoneyAmount = int.Parse(Console.ReadLine());
                if (WithdrawlMoneyAmount <= MoneyAmount)
                {
                    Console.WriteLine("Action succeed");
                    Account1.WithdrawalMoney(WithdrawlMoneyAmount);
                }
                else
                {
                    Console.WriteLine("You don't enough money in your account");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(Account1);
        }
    }
}
