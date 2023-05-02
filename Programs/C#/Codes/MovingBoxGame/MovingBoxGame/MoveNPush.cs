using System;
namespace MovingBoxGame
{
    public class MoveNPush
    {
        static Random rnd = new Random();
        private string[,] board = new string[5,5];
        private Position playerPosition;
        private Position BoxPosition;
        private Position returnSpot;

        private string playerUI = $"{Convert.ToChar(2)}";
        private string BoxUI = $"{Convert.ToChar(15)}";
        private string placeTuPutUI = $"{Convert.ToChar(19)}";

        public MoveNPush()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "_";
                }
            }
        }

        public void InitBoard()
        {
            this.board[0,0] = this.playerUI;
            Position playerPosition = new Position(0, 0);
            Position BoxPosition = new Position(rnd.Next(1, 4), rnd.Next(1, 4));
            this.board[BoxPosition.Y, BoxPosition.X] = this.BoxUI;
            Position placePosition = new Position(rnd.Next(1, 4), rnd.Next(1, 4));
            if(placePosition.X == BoxPosition.X && placePosition.Y == BoxPosition.Y)
            {
                placePosition.X = placePosition.X - 1;
                placePosition.Y = placePosition.Y - 1;
            }
            this.board[placePosition.Y, placePosition.X] = this.placeTuPutUI;
            this.playerPosition = playerPosition;
            this.BoxPosition = BoxPosition;
            this.returnSpot = placePosition;
        }



        public void Move(string direction)
        {
            //IF W
            if (direction == "W" || direction == "w")
            {
                if (this.playerPosition.Y - 1 == this.BoxPosition.Y)
                {
                    if (this.BoxPosition.Y - 1 != -1)
                    {
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = "_";
                        this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                        this.BoxPosition.Y--;
                        this.playerPosition.Y--;
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = this.BoxUI;
                        this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                    }
                }
            }
            else if (this.playerPosition.Y - 1 != -1)
            {
                this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                this.playerPosition.Y--;
                this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
            }
            //If S
            if (direction == "s" || direction == "S")
            {
                if (this.playerPosition.Y + 1 == this.BoxPosition.Y)
                {
                    if (this.BoxPosition.Y + 1 != 5)
                    {
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = "_";
                        this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                        this.BoxPosition.Y++;
                        this.playerPosition.Y++;
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = this.BoxUI;
                        this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                    }
                }
                else if (this.playerPosition.Y + 1 != 5)
                {
                    this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                    this.playerPosition.Y++;
                    this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                }
            }
            //If D
            if (direction == "D" || direction == "d")
            {
                if (this.playerPosition.X + 1 == this.BoxPosition.X)
                {
                    if (this.BoxPosition.X + 1 != 5)
                    {
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = "_";
                        this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                        this.BoxPosition.X++;
                        this.playerPosition.X++;
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = this.BoxUI;
                        this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                    }
                }
                else if (this.playerPosition.X + 1 != 5)
                {
                    this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                    this.playerPosition.X++;
                    this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                }
            }
            //If A
            if (direction == "A" || direction == "a")
            {
                if (this.playerPosition.X - 1 == this.BoxPosition.X)
                {
                    if (this.BoxPosition.X - 1 != -1)
                    {
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = "_";
                        this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                        this.BoxPosition.X--;
                        this.playerPosition.X--;
                        this.board[this.BoxPosition.Y, this.BoxPosition.X] = this.BoxUI;
                        this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
                    }
                }
            }
            else if (this.playerPosition.X - 1 != -1)
            {
                this.board[this.playerPosition.Y, this.playerPosition.X] = "_";
                this.playerPosition.X--;
                this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
            }
        }

        public override string ToString()
        {
            this.board[this.returnSpot.Y, this.returnSpot.X] = this.placeTuPutUI;
            this.board[this.BoxPosition.Y, this.BoxPosition.X] = this.BoxUI;
            this.board[this.playerPosition.Y, this.playerPosition.X] = this.playerUI;
            string print = $"Player: {playerUI},Box: {this.BoxUI},Place to put: {this.placeTuPutUI}\n";
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    print += $"|{board[i, j]}|";
                }
                print += "\n";
            }
            return print;
        }
    }
}