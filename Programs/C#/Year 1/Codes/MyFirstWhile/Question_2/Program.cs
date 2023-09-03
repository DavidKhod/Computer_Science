using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letter,NewLetter;
            int NewChar;
            Console.WriteLine("Enter small letter from the abc");
            Letter = char.Parse(Console.ReadLine());
            while ((int)Letter >= 97 && (int)Letter <=122)
            {
                NewChar = Letter - 32;
                Console.WriteLine($"{Letter} to {(char)NewChar}");
                Console.WriteLine("Enter another small letter from the abc");
                Letter = char.Parse(Console.ReadLine());
            }
        }
    }
}
