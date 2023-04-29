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
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"{i}: {Convert.ToChar(i)}");
            }
        }

    }
}
