using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P80Q30
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender1, gender2;
            int age1, age2;
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;//dawdasd
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the age of the first indevidual");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second indevidual");
            age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender of the first indevidual");
            gender1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender of the second indevidual");
            gender2 = char.Parse(Console.ReadLine());
            //if ((((age1-age2<=5)&&(age1-age2>=0))||((age2-age1<=5)&&(age2-age1>=0)))&&((gender1=='m')&&(gender2=='f')||(gender1=='f')&&(gender2=='m')))
            if ((Math.Abs(age1-age2)<=5) && (gender1 != gender2))
            {
                Console.WriteLine("Those two indeviduals can date");
            }
            else
            {
                Console.WriteLine("Those two indeviduals can't date");
            }
        }
    }
}
