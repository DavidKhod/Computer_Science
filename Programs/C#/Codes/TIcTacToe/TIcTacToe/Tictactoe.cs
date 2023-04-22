   using System;
namespace TIcTacToe
 
{
    class Tictactoe
    {
        private char[] Game = new char[10];
        private char WonLetter = ' ';

        public Tictactoe()
        {
            for (int i = 1; i < 10; i++)
            {
                Game[i] = ' ';
            }
        }

        public bool IsTaken(int position)
        {
            if (Game[position] != ' ')
            {
                return true;
            }
            return false;
        }

        public char WhatInPlace(int position)
        {
            return Game[position];
        }

        public void Choose(int position, char Choice)
        {
            Game[position] = Choice;
        }

        public bool IsWon()
        {
            //Finding if X won
            char Choice = 'X';
            int row = 0;
            for (int i = 1; i <= 3; i++)
            {
                if(Game[1 + row] == Choice && Game[1 + row + 1] == Choice && Game[1 + row + 2] == Choice)
                {
                    WonLetter = 'X';
                    return true;
                }
                row += 3;
                if (Game[i] == Choice && Game[i+3] == Choice && Game[i+6] == Choice)
                {
                    WonLetter = 'X';
                    return true;
                }
            }

            if (Game[1] == Choice && Game[5] == Choice && Game[9] == Choice)
            {
                WonLetter = 'X';
                return true;
            }
            if (Game[3] == Choice && Game[5] == Choice && Game[7] == Choice)
            {
                WonLetter = 'X';
                return true;
            }

            //Finding if O Won
            Choice = 'O';
            row = 1;
            for (int i = 1; i <= 3; i++)
            {
                if (Game[1 + row] == Choice && Game[1 + row + 1] == Choice && Game[1 + row + 2] == Choice)
                {
                    WonLetter = 'O';
                    return true;
                }
                row += 3;
                if (Game[i] == Choice && Game[i + 3] == Choice && Game[i + 6] == Choice)
                {
                    WonLetter = 'O';
                    return true;
                }
            }

            if (Game[1] == Choice && Game[5] == Choice && Game[9] == Choice)
            {
                WonLetter = 'O';
                return true;
            }
            if (Game[3] == Choice && Game[5] == Choice && Game[7] == Choice)
            {
                WonLetter = 'O';
                return true;
            }

            return false;
        }
        
        public char WhoWon()
        {
            return WonLetter;
        }

        public void PrintGame()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"|{Game[1]}|{Game[2]}|{Game[3]}|    |1|2|3|");
            Console.WriteLine($"|{Game[4]}|{Game[5]}|{Game[6]}|    |4|5|6|");
            Console.WriteLine($"|{Game[7]}|{Game[8]}|{Game[9]}|    |7|8|9|");
            Console.WriteLine("------------------");
        }
    }



}
