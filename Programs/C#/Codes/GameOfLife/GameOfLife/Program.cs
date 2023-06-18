using System;
using System.Collections.Generic;
using System.Threading;
namespace GameOfLife
{
    class Program
    {
        public static int[,] Board;
        public static List<Position> alivePositions = new List<Position>();
        static int AliveAmountAroundOf(Position position)//Calculates the amount of positions alive around the position given and returns it
        {
            int aroundAmount = 0;
            if (position.X == 0 && position.Y == 0 || position.X == Board.GetLength(1) - 1 && position.Y == 0 || position.Y == Board.GetLength(0) - 1 && position.X == 0 || position.X == Board.GetLength(1) - 1 && position.Y == Board.GetLength(0) - 1)//Checks if the position is a corner in the Board
            {
                if (position.X == 0 && position.Y == 0)//Top Left Corner
                {
                    aroundAmount += Board[position.Y, position.X + 1];//Right of the top left corner
                    aroundAmount += Board[position.Y + 1, position.X];//Under the top left corner
                    aroundAmount += Board[position.Y + 1, position.X + 1];//Under and to the right of the top left corner
                }
                else if (position.X == Board.GetLength(1) - 1 && position.Y == Board.GetLength(0) - 1)//Bottom Right
                {
                    aroundAmount += Board[position.Y, position.X - 1];//Left of the right bottom corner
                    aroundAmount += Board[position.Y - 1, position.X];//Over the right bottom corner
                    aroundAmount += Board[position.Y - 1, position.X - 1];//Over and to the left of the right bottom corner
                }
                else if (position.X == 0 && position.Y == Board.GetLength(0) - 1)//Bottom Left
                {
                    aroundAmount += Board[position.Y - 1, position.X];//Over the bottom left corner
                    aroundAmount += Board[position.Y, position.X + 1];//Right of the bottom left corner
                    aroundAmount += Board[position.Y - 1, position.X + 1];//Over and to the Right of the bottom left corner
                }
                else if (position.X == Board.GetLength(1) - 1 && position.Y == 0)//Top Right
                {
                    aroundAmount += Board[position.Y, position.X - 1];//Left of the Top Right corner
                    aroundAmount += Board[position.Y + 1, position.X];//Under the Top Right corner
                    aroundAmount += Board[position.Y + 1, position.X - 1];//Under and to the left of the Top Right corner
                }
            }
            else if (position.X == 0 || position.X == Board.GetLength(1) - 1 || position.Y == 0 || position.Y == Board.GetLength(0) - 1)//Checks if the position if On one of the sides of the Board
            {
                if (position.X == 0)
                {
                    aroundAmount += Board[position.Y - 1, position.X];//Over the position
                    aroundAmount += Board[position.Y, position.X + 1];//Right of position
                    aroundAmount += Board[position.Y + 1, position.X];//Under the position
                    aroundAmount += Board[position.Y - 1, position.X + 1];//Over to the right of position
                    aroundAmount += Board[position.Y + 1, position.X + 1];//Under to the right of position
                }
                else if (position.X == Board.GetLength(1)-1)
                {
                    aroundAmount += Board[position.Y - 1, position.X];//Over the position
                    aroundAmount += Board[position.Y, position.X - 1];//Left of position
                    aroundAmount += Board[position.Y + 1, position.X];//Under the position
                    aroundAmount += Board[position.Y - 1, position.X - 1];//Over to the left of position
                    aroundAmount += Board[position.Y + 1, position.X - 1];//Under to the left of position
                }
                else if (position.Y == 0)
                {
                    aroundAmount += Board[position.Y, position.X + 1];//Right of position
                    aroundAmount += Board[position.Y, position.X - 1];//Left of position
                    aroundAmount += Board[position.Y + 1, position.X];//Under the position
                    aroundAmount += Board[position.Y + 1, position.X + 1];//Under to the right of position
                    aroundAmount += Board[position.Y + 1, position.X - 1];//Under to the left of position
                }
                else if (position.Y == Board.GetLength(0)-1)
                {
                    aroundAmount += Board[position.Y, position.X + 1];//Right of position
                    aroundAmount += Board[position.Y, position.X - 1];//Left of position
                    aroundAmount += Board[position.Y - 1, position.X];//Over the position
                    aroundAmount += Board[position.Y - 1, position.X + 1];//Over to the right of position
                    aroundAmount += Board[position.Y - 1, position.X - 1];//Over to the left of position
                }
            }
            else
            {
                aroundAmount += Board[position.Y, position.X - 1];//Adds Left of the position
                aroundAmount += Board[position.Y, position.X + 1];//Adds Right of the position
                for (int i = 0; i < 3; i++)
                {
                    aroundAmount += Board[position.Y - 1, position.X - 1 + i];//Adds the row over the position
                    aroundAmount += Board[position.Y + 1, position.X - 1 + i];//Adds the row under the position
                }
            }
            return aroundAmount;
        }

        static bool Die(Position position)
        {
            int amountAround = AliveAmountAroundOf(position);
            if ((amountAround < 2 || amountAround > 3) && Board[position.Y,position.X] == 1)//Checks if the amount of alive around the position is bigger than 3 and smaller than 2 and also if the position itself is alive
            {
                Board[position.Y, position.X] = 0;
                RemoveAlive(position);
                return true;
            }
            if (!alivePositions.Exists(p => p.X == position.X && p.Y == position.Y))
            {
                alivePositions.Add(position);
                Board[position.Y, position.X] = 1;
            }
            return false;
        }

        //Finds the index of the position inputed and deletes it in the List
        static void RemoveAlive(Position position)
        {
            for (int i = 0; i < alivePositions.Count; i++)
            {
                if (position.X == alivePositions[i].X && position.Y == alivePositions[i].Y)
                {
                    alivePositions.RemoveAt(i);
                    return;
                }
            }
        }

        static void ResizeBoard()
        {
            int cnt = 0;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                cnt += Board[i, 0];//Adds the left column
                cnt += Board[i, Board.GetLength(1) - 1];//Adds the right column
            }
            for (int i = 1; i < Board.GetLength(0); i++)
            {
                cnt += Board[0, i];//Adds the first row
                cnt += Board[Board.GetLength(0) - 1, i];//Adds the last row
            }
            if (cnt > 0)
            {
                int[,] newBoard = new int[Board.GetLength(0) + 2, Board.GetLength(1) + 2];//Adds two rows and two columns
                for (int i = 1; i < Board.GetLength(0) + 1; i++)
                {
                    for (int j = 1; j < Board.GetLength(1) + 1; j++)
                    {
                        newBoard[i, j] = Board[i - 1, j - 1];
                    }
                }
                Board = newBoard;
            }
        }
        static bool Repopulate(Position position)
        {
            int aroundAmount = AliveAmountAroundOf(position);
            if ((aroundAmount == 2 || aroundAmount == 3) && Board[position.Y, position.X] == 0)
            {
                Board[position.Y, position.X] = 1;
                alivePositions.Add(position);
                return true;
            }
            return false;
        }

        static void RepoOrDie(Position position)
        {
            int amountAround = AliveAmountAroundOf(position);
            if ((amountAround > 3 || amountAround < 2) && alivePositions.Exists(p => p.X == position.X && p.Y == position.Y))
            {
                Die(position);
                return;
            }
            else if ((amountAround == 3 || amountAround == 2) && !alivePositions.Exists(p => p.X == position.X && p.Y == position.Y))
            {
                Repopulate(position);
                return;
            }
        }

        static void UpdateBoard()
        {
            for (int i = 0; i < alivePositions.Count; i++)
            {
                Board[alivePositions[i].Y, alivePositions[i].X] = 1;
            }
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    RepoOrDie(new Position(i, j));
                }
            }

            ResizeBoard();
        }

        static bool ContainsInList(Position position)
        {
            foreach (Position position1 in alivePositions)
            {
                if (position1.X == position.X && position.Y == position1.Y)
                    return true;
            }
            return false;
        }

        static void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (ContainsInList(new Position(i, j)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("|X|");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|O|");
                    }

                }
                Console.WriteLine();
            }
        }
        static void ResetBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = 0;
                }
            }
        }

        static void PrintBoardForChoicePeriod()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write($"|{i},{j}|");
                }
                Console.WriteLine();
            }
        }

        static void ChoosingPhase()
        {
            PrintBoardForChoicePeriod();
            int i;
            int j;
            char choice = ' ';
            while (choice != 'Y')
            {
                Console.Write($"Choose indexes\n");
                Console.Write($"Row: ");
                i = int.Parse(Console.ReadLine());
                while (i < 0 || i > Board.GetLength(0) - 1)
                {
                    Console.Write($"Error,Enter Again: ");
                    i = int.Parse(Console.ReadLine());
                }
                Console.Write($"Column: ");
                j = int.Parse(Console.ReadLine());
                while (j < 0 || j > Board.GetLength(1) - 1)
                {
                    Console.Write($"Error,Enter Again: ");
                    j = int.Parse(Console.ReadLine());
                }
                Board[i, j] = 1;
                alivePositions.Add(new Position(i, j));
                Console.WriteLine($"Start Game?(Y/N)");
                choice = char.Parse(Console.ReadLine().ToUpper());
            }
            PrintBoard();
            Console.WriteLine($"Are you sure?(Y/N)");
            choice = char.Parse(Console.ReadLine().ToUpper());
            if (choice == 'N')
                ChoosingPhase();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game OF Life!!!!!!!!");
            Console.Write("With What size of board would you like to start?(nxn): ");
            int n = int.Parse(Console.ReadLine());
            Board = new int[n, n];
            ResetBoard();
            Console.WriteLine("Now, Pick what indexes you want to start alive");
            ChoosingPhase();
            int cnt = 0;
            while (cnt < 100)
            {
                UpdateBoard();
                Thread.Sleep(3000);
                Console.WriteLine($"Gen: {cnt}");
                PrintBoard();
            }
        }
    }
}
