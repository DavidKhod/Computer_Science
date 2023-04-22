using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P107Q13_10_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int Guess, difference;
            bool GuessEqualThrow;
            Console.WriteLine("Enter your guess on the number on the dice");
            Guess = int.Parse(Console.ReadLine());
            Random rd = new Random();
            int Throw = rd.Next(1, 7);
            GuessEqualThrow = (Guess == Throw);
            Console.WriteLine("The number you guessed is "+Guess);
            Console.WriteLine("The actual number on the dice is "+Throw);
            if (GuessEqualThrow)
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("You guessed wrongly");
                difference = Math.Abs(Guess - Throw);
                Console.WriteLine("The difference between the guess and the throw is "+difference);
            }
        }
    }
}
