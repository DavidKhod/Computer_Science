using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P138Q54
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int Eights = 0, Nines = 0, Tens = 0;
            int n,Max=0;
            int NumRolled,RolledSum=0;
            Console.WriteLine("Enter the amount of times you want to roll");
            n = int.Parse(Console.ReadLine());
            NumRolled = rnd.Next(8,11);
            if (NumRolled == 8)
            {
                Eights++;
            }
            if (NumRolled == 9)
            {
                Nines++;
            }
            if (NumRolled == 10)
            {
                Tens++;
            }
            Max = NumRolled;
            RolledSum += NumRolled;
            for (int i = 1; i < n; i++)
            {
                NumRolled = rnd.Next(8, 11);
                if (NumRolled == 8)
                {
                    Eights++;
                }
                if (NumRolled == 9)
                {
                    Nines++;
                }
                if (NumRolled == 10)
                {
                    Tens++;
                }
                if (NumRolled > Max)
                {
                    Max = NumRolled;
                }
                RolledSum += NumRolled;
            }
            if (Eights > Nines && Eights > Tens)
            {
                Console.WriteLine("The number rolled the most is 8");
            }
            else if (Nines > Eights && Nines > Tens)
            {
                Console.WriteLine("The number rolled the most is 9");
            }
            else if (Tens > Eights && Tens > Nines)
            {
                Console.WriteLine("The number rolled the most time is 10");
            }
            else
            {
                Console.WriteLine("At least two numbers were rolled the same amount of times");
            }
            Console.WriteLine($"The average of the numbers is {RolledSum/n}");
            Console.WriteLine($"The max number is rolled is {Max}");
        }
    }
}
