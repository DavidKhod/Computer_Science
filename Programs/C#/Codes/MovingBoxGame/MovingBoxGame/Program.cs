using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBoxGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveNPush game = new MoveNPush();
            string decision = "";
            do
            {
                game.InitBoard();
                while (game.BoxInSpot() == false)
                {
                    Console.WriteLine($"{game.ToString()}");
                    Console.WriteLine($"W - Up | S - Down - | D - Right | A - Left");
                    game.Move(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine($"Again(y -> yes || N -> no)");
                decision = Console.ReadLine();
            } while (decision == "Y" || decision == "y");
            Console.WriteLine($"Yov'e done {game.GetRounds()} rounds");

        }

    }
}
