using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3_2_11_22
{
    class Program
    {
        static void Main(string[] args)//Question 3
        {
            String name1, name2;
            int Points1, Points2;
            bool GameOver, ExtraTime;
            bool Oneover21 = false;
            bool Oneover22 = false;
            bool Twooveroneone = false;
            bool Twoover12 = false;
            Console.WriteLine("Enter the name of the first player");
            name1 = (Console.ReadLine());
            Console.WriteLine("Enter the points " + name1 + " has");
            Points1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the Second player");
            name2 = (Console.ReadLine());
            Console.WriteLine("Enter the points " + name2 + " has");
            Points2 = int.Parse(Console.ReadLine());
            if (Math.Abs(Points1 - Points2)== 2)
            {
                GameOver = true;
            }
            else
            {
                GameOver = false;
            }
            if (Points1 > 6 || Points2 > 6)
            {
                ExtraTime = true;
            }
            else
            {
                ExtraTime = false;
            }
            if (Points1 > Points2)
            {
                if (Points2 + 1 == Points1)
                {
                    Oneover21 = true;
                }
                else
                {
                    Oneover21 = false;
                }
                if (Points2 + 2 == Points1)
                {
                    Oneover22 = true;
                }
                else
                {
                    Oneover22 = false;
                }

            }
            if (Points2 > Points1)
            {
                if (Points1 + 1 == Points2)
                {
                    Twooveroneone = true;
                }
                if (Points1 + 2 == Points2)
                {
                    Twoover12 = true;
                }
                else
                {
                    Twoover12 = false;
                }
            }
            if (GameOver)
            {
                if (ExtraTime)
                {
                    if (Points1 > Points2)
                    {
                        Console.WriteLine("Game is over");
                        Console.WriteLine(name1 + "Won in the extra time");
                    }
                    else
                    {
                        Console.WriteLine("Game is over");
                        Console.WriteLine(name2 + "Won in the extra time");
                    }
                }
                else
                {
                    if (Points1 > Points2)
                    {
                        Console.WriteLine("Game is over");
                        Console.WriteLine(name1 + "Won");
                    }
                    else
                    {
                        Console.WriteLine("Game is over");
                        Console.WriteLine(name2 + "Won");
                    }
                }

            }
            else
            {
                if (Oneover21)
                {
                    Console.WriteLine("The game is ongoing");
                    Console.WriteLine(name1 + "is leading by one point");
                }
                else if (Oneover22)
                {
                    Console.WriteLine("The game is ongoing");
                    Console.WriteLine(name1 + "is leading by two points");
                }
                if (Twooveroneone)
                {
                    Console.WriteLine("The game is ongoing");
                    Console.WriteLine(name2 + "is leading by one point");
                }
                if (Twoover12)
                {
                    Console.WriteLine("The game is ongoing");
                    Console.WriteLine(name2 + "is leading by two points");
                }
            }
        }
    }
}
