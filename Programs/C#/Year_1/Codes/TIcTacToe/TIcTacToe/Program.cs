using System;

namespace TIcTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char desicion = ' ';
            int cntX = 0,cntO = 0;
            do
            {
                Console.Clear();
                Tictactoe game = new Tictactoe();
                game.PrintGame();
                int step = 1;
                int position;
                while (game.IsWon() == false)
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
                    Console.Clear();
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
                    if (game.WhoWon() == 'O')
                        cntO++;
                    else
                        cntX++;
                }
                Console.WriteLine();
                Console.Write("Keep going(y/n): ");
                desicion = char.Parse(Console.ReadLine());
            } while (desicion == 'y' || desicion == 'Y');
            Console.WriteLine($"X won {cntX} times");
            Console.WriteLine($"O won {cntO} times");
        }
    }
}
