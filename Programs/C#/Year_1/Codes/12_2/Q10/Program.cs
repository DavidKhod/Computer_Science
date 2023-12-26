using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static int PricePerClass (int StudentsAmount)
        {
            int Price = 0;
            if (StudentsAmount >= 10)
            {
                Price = 180;
            }
            StudentsAmount = StudentsAmount - 10;
            while (StudentsAmount != 0)
            {
                Price += 5;
                StudentsAmount -= 1;
            }
            return Price;
        }
        static void Main(string[] args)
        {
            const int CLASSES = 20;
            int Students;
            int SumPrice = 0;
            for (int i = 1; i <= CLASSES; i++)
            {
                Console.WriteLine($"Enter the amount of students came {i}");
                Students = int.Parse(Console.ReadLine());
                SumPrice += PricePerClass(Students);
            }
            Console.WriteLine($"The average pay is {SumPrice / CLASSES}");
        }
    }
}
