using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest_2_11_22
{
    class Program
    {
        static void Main(string[] args)//Question 2
        {
            int KidsAmount, BBoatAmount, SBoatAmount,notBig;
            double BigPrice, SmallPrice,TotalPrice1=0,TotalPrice2=0;
            Console.WriteLine("Enter the amount of kids");
            KidsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of a big boat");
            BigPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of a small boat");
            SmallPrice = double.Parse(Console.ReadLine());
            BBoatAmount = KidsAmount / 30;
            if (KidsAmount%30==0)
            {
                TotalPrice1 = BBoatAmount * BigPrice;
                Console.WriteLine("The amount of Big boats ordered is "+BBoatAmount);
                Console.WriteLine("The total price is "+TotalPrice1);
            }
            else
            {
                TotalPrice1 = (BBoatAmount+1) * BigPrice;
                Console.WriteLine("The amount of Big boats ordered is " + (BBoatAmount+1));
                Console.WriteLine("The total price is "+TotalPrice1);
            }
            if (KidsAmount % 30 == 0)
            {
                TotalPrice1 = BBoatAmount * BigPrice;
                Console.WriteLine("The amount of Big boats ordered is " + BBoatAmount);
                Console.WriteLine("The total price is " + TotalPrice1);
            }
            else
            {
                notBig = KidsAmount % 30;
                SBoatAmount = notBig / 10;
                if (notBig%10==0)
                {
                    TotalPrice2 = (BBoatAmount * BigPrice) + (SBoatAmount*SmallPrice);
                    Console.WriteLine("The amount of big boats ordered is "+BBoatAmount);
                    Console.WriteLine("The amount of small boats ordered is "+SBoatAmount);
                    Console.WriteLine("The total price is "+TotalPrice2);
                }
                else
                {
                    TotalPrice2 = (BBoatAmount * BigPrice) + ((SBoatAmount+1) * SmallPrice);
                    Console.WriteLine("The amount of big boats ordered is " + BBoatAmount);
                    Console.WriteLine("The amount of small boats ordered is " + (SBoatAmount+1));
                    Console.WriteLine("The total price is " + TotalPrice2);
                }
            }
            if (TotalPrice1 < TotalPrice2)
            {
                Console.WriteLine("The first option is cheaper");
            }
            else
            {
                Console.WriteLine("The second option is Cheaper");
            }
        }
    }
}
