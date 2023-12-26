using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYearWorkAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int CY, BD;
            Console.WriteLine("Enter your current year");
            CY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth year");
            BD = int.Parse(Console.ReadLine());
            while (CY > BD)
            {
                Console.WriteLine("Your age is " + (CY - BD));
                CY = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
