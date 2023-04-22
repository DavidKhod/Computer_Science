using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q38
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Power;//מספר של החזקה
            Console.WriteLine("Enter the base number");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power number");
            Power = int.Parse(Console.ReadLine());
            int result;//התוצאה
            result = Num1;
            for (int i = 1; i < Power; i++)
            {
                result *= Num1;
            }
            Console.WriteLine($"The result is {result}");
        }
    }
}
