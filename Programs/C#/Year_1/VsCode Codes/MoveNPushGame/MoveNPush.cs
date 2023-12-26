using System;
namespace MoveNPushGame
{
    class MoveNPush
    {
        static Random rnd = new Random();
        private string[] board = new string[26];
        private string printBoard = "";

        public MoveNPush()
        {
            for (int i = 1; i < this.board.Length; i++)
            {
                board[i] = "⬛";
            }
        }

        public void InitBoard()
        {
            printBoard = "";
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
        }

        public override string ToString()
        {
            return printBoard;
        }
    }
}