using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ4_11_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int CandyAmount;
            Console.WriteLine("Enter the amount of candy there is in the box");
            CandyAmount = int.Parse(Console.ReadLine());
            Random rd = new Random();
            int FirstTake = rd.Next(1, CandyAmount);
            Random rnd = new Random();
            int SecondTake = rd.Next(1, CandyAmount-FirstTake);
            Random red = new Random();
            int ThirdTake = rd.Next(1, CandyAmount-FirstTake-SecondTake);
            Console.WriteLine("The amount of candy taken is the first take is "+FirstTake);
            Console.WriteLine("The amount of candy taken is the second take is "+SecondTake);
            Console.WriteLine("The amount of candy taked in the third take is "+ThirdTake);
            Console.WriteLine("The amount of candy left in the box is "+(CandyAmount-FirstTake-SecondTake-ThirdTake));
        }
    }
}
