using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q32
{
    class Program
    {
        static void Main(string[] args)
        {
            char FirstLetter,Letter = '*';
            int Count = 0;
            Console.WriteLine("Enter the first letter of your name");
            FirstLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter a letter");
            while (Letter != FirstLetter)
            {
                Count++;
                Letter = char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The first letter of your name is in the {Count} place");
        }
    }
}
