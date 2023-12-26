using System;
namespace MoveNPushGame
{
    class Program
    {
        static void Main(string[]args)
        {
            MoveNPush game = new MoveNPush();
            game.InitBoard();
            System.Console.WriteLine($"{game.ToString()}");

        }
    }
}