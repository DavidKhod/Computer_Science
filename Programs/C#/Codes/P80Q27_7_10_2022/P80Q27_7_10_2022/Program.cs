using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P80Q27_7_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Char Letter;
            Console.WriteLine("Enter a note");
            Letter = char.Parse(Console.ReadLine());
            if ((Letter>=97) && (Letter<=122))
            {
                Console.WriteLine("a-z");
            }
            else
            {
                Console.WriteLine("not a-z");
            }
            
        }
    }
}
