using System;

namespace TIcTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char desicion = ' ';
            do
            {
                Tictactoe game = new Tictactoe();
                game.PrintGame();
                int step = 1;
                int position;
                while (game.IsWon() == false && step <= 9)
                {
                    if (step % 2 != 0)
                    {
                        Console.Write($"Enter your position(X): ");
                        position = int.Parse(Console.ReadLine());
                        while (game.IsTaken(position) == true)
                        {
                            Console.WriteLine("Position taken");
                            Console.Write($"Enter your position(X): ");
                            position = int.Parse(Console.ReadLine());
                        }
                        game.Choose(position, 'X');
                    }
                    else
                    {
                        Console.Write($"Enter your position(O): ");
                        position = int.Parse(Console.ReadLine());
                        while (game.IsTaken(position) == true)
                        {
                            Console.WriteLine("Position taken");
                            Console.Write($"Enter your position(O): ");
                            position = int.Parse(Console.ReadLine());
                        }
                        game.Choose(position, 'O');
                    }
                    step++;
                    game.PrintGame();
                }
                Console.WriteLine("---------");
                if (game.IsWon() == false)
                {
                    Console.WriteLine($"GAME OVER");
                    Console.WriteLine($"No one won");
                }
                else
                {
                    Console.WriteLine($"GAME OVER");
                    Console.WriteLine($"Player {game.WhoWon()} Won");
                }
                Console.WriteLine();
                Console.Write("Keep going(y/n): ");
                desicion = char.Parse(Console.ReadLine());
            } while (desicion == 'y' || desicion == 'Y');
        }
    }
}
