using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Grade, Max, Min;
            Console.WriteLine("Enter an english grade");
            Grade = int.Parse(Console.ReadLine());
            Max = Grade;
            Min = Grade;
            if (Grade <= 55)
                {
                    Console.WriteLine("You didnt pass");
                }
                if (Grade >= 95)
                {
                    Console.WriteLine("You passed good");
                }
            while (Grade >= 0)
            {
                Console.WriteLine("Enter an english grade");
                Grade = int.Parse(Console.ReadLine());
                if (Grade >= 0)
                {
                    if (Grade > Max)
                    {
                        Max = Grade;
                    }
                    if (Grade < Min)
                    {
                        Min = Grade;
                    }
                    if (Grade <= 55)
                    {
                        Console.WriteLine("You didnt pass");
                    }
                    if (Grade >= 95)
                    {
                        Console.WriteLine("You passed good");
                    }
                }
            }
            Console.WriteLine($"The biggest grade is {Max}");
            Console.WriteLine($"The lowest grade is {Min}");
        }
    }
}
