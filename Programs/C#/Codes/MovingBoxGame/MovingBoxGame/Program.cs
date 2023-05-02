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
            game.InitBoard();
            Console.WriteLine($"{game.ToString()}");
            game.Move("w");
            Console.WriteLine($"{game.ToString()}");
            game.Move("S");
            Console.WriteLine($"{game.ToString()}");
            game.Move("s");
            Console.WriteLine($"{game.ToString()}");
            game.Move("s");
            Console.WriteLine($"{game.ToString()}");
            Console.WriteLine("---");
            Console.WriteLine($"{game.ToString()}");
        }

    }
}
