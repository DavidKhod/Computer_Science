using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letter;
            int CountSmall = 0, CountBig = 0;
            Console.WriteLine("Enter a letter from the abc");
            Letter = char.Parse(Console.ReadLine());
            if ((int)Letter >= 65 && (int)Letter <= 90)
            {
                CountBig++;
            }
            if ((int)Letter >= 97 && (int)Letter <= 122)
            {
                CountSmall++;
            }
            while ((int)Letter >= 65 && (int)Letter <= 90 || (int)Letter >= 97 && (int)Letter <= 122)
            {
                Console.WriteLine("Enter a letter from the abc");
                Letter = char.Parse(Console.ReadLine());
                if ((int)Letter >= 65 && (int)Letter <= 90)
                {
                    CountBig++;
                }
                if ((int)Letter >= 97 && (int)Letter <= 122)
                {
                    CountSmall++;
                }
            }
            Console.WriteLine($"The amount of small letters from the abc is {CountSmall}");
            Console.WriteLine($"The amount of big letters from the ABC is {CountBig}");
        }
    }
}
