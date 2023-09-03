using System;

namespace _10_7
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int LetterNum,Count = 0;
            char RealLetter, Letter;
            bool Guessed = false;
            LetterNum = rnd.Next(65, 91);
            RealLetter = (char)LetterNum;
            Console.WriteLine(RealLetter);
            while (Guessed == false & Count < 5)
            {
                Count++;
                Console.WriteLine("Enter a letter from the ABC");
                Letter = char.Parse(Console.ReadLine());
                if (Letter == RealLetter)
                {
                    Guessed = true;
                }
            }
            if (!(Guessed))
            {
                Console.WriteLine("You didn't guess it");
            }
            if (Count < 5 && Guessed)
            {
                Console.WriteLine($"You guessed it after {Count} Times");
            }
            else if (Guessed & Count == 5)
            {
                Console.WriteLine("You guessed it on your last try");
            }
            
        }
    }
}
