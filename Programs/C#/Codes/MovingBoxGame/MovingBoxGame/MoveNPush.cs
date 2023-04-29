using System;
namespace MovingBoxGame
{
    class MoveNPush
    {
        static Random rnd = new Random();
        private string[] board = new string[26];
        private string printBoard = "--------------- \n";

        public MoveNPush()
        {
            for (int i = 1; i < this.board.Length; i++)
            {
                board[i] = "|_|";
            }
        }

        public void InitBoard()
        {
            int times = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    printBoard += $"{board[j + times]}";
                }
                printBoard += "\n";
                times += 5;
            }
            printBoard += $"---------------";
        }

        public override string ToString()
        {
            return printBoard;
        }
    }
}