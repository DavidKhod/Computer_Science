using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page124_4_12_22
{
    class Program
    {
        static void Main(string[] args)//Question 20
        {
            int j=0;
            for (int i = 1; i <= 7; i++)
            {
                double Temp;
                Console.Write("Enter the tempature today: ");
                Temp = double.Parse(Console.ReadLine());
                if (Temp>16)
                {
                    j++;
                }
            }
            Console.WriteLine($"The amount of days that the tempature got over 16 degrees is {j}");
        }
    }
}
