using System;

namespace _3_13
{
    class Program
    {
        static void PrintStars(int n)
        {
            if (n != 0)
            {
                Console.Write("*");
                PrintStars(n - 1);
            }
        }
        static void PrintStarsXAndY(int n, int m)
        {
            if (n != 0)
            {
                PrintStars(m);
                Console.WriteLine();
                PrintStarsXAndY(n - 1, m);
            }
        }
        static void PrintTriangleOfStars(int n)
        {
            if (n != 0)
            {
                PrintStars(n);
                Console.WriteLine();
                PrintTriangleOfStars(n - 1);
            }
        }

        static void PrintTriangleOfStarsOpposite(int n)
        {
            if (n != 0)
            {
                PrintTriangleOfStarsOpposite(n - 1);
                PrintStars(n);
                Console.WriteLine();
            }
        }

        static void PrintTwoOppositeRtianglesOfStars(int n)
        {
            if (n != 1)
            {
                PrintStars(n);
                Console.WriteLine();
                PrintTwoOppositeRtianglesOfStars(n - 1);
                Console.WriteLine();
                PrintStars(n);
            }
            else
            {
                PrintStars(n);
            }
        }

        static void PrintNumNumTimes(int n, int m)
        {
            if (m < n)
            {
                m++;
                Console.Write($"{n}");
                PrintNumNumTimes(n, m);
            }
        }

        static void PrintTriangleOfNum(int n)
        {
            if (n != 0)
            {
                PrintNumNumTimes(n, 0);
                Console.WriteLine();
                PrintTriangleOfNum(n - 1);
            }
        }

        static void PrintSpaces(int n)
        {
            if (n != 0)
            {
                Console.Write(" ");
                PrintSpaces(n - 1);
            }
        }

        static void PrintSpacesAndStars(int n)
        {
            if (n != 0)
            {
                PrintSpaces(n - 1);
                Console.Write("*");
                Console.WriteLine();
                PrintSpacesAndStars(n - 1);
            }
        }

        static void SandWatchOfStars(int n)
        {
            SandWatchOfStars(n + 2, 0);
        }

        static void SandWatchOfStars(int n, int m)
        {
            if (n > 0 && n != 0)
            {
                PrintSpaces(m);
                PrintStars(n);
                Console.WriteLine();
                SandWatchOfStars(n - 2, m + 1);
                if(n != 1 && n!= 2)
                {
                    PrintSpaces(m);
                    PrintStars(n);
                    Console.WriteLine();
                }
            }
        }

        static void PrintStarsBelly(int n)
        {
            PrintStarsBelly(n, 0);
        }

        static void PrintStarsBelly(int n,int m)
        {
            if(m < n)
            {
                m++;
                PrintStars(m);
                Console.WriteLine();
                PrintStarsBelly(n, m);
                PrintStars(m);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"PrintStarsXAndY(3, 5):");
            PrintStarsXAndY(3, 5);
            Console.WriteLine("PrintTriangleOfStars(3):");
            PrintTriangleOfStars(3);
            Console.WriteLine("PrintTriangleOfStarsOpposite(3):");
            PrintTriangleOfStarsOpposite(3);
            Console.WriteLine("PrintTwoOppositeRtianglesOfStars(3):");
            PrintTwoOppositeRtianglesOfStars(3);
            Console.WriteLine();
            Console.WriteLine("PrintTriangleOfNum(3):");
            PrintTriangleOfNum(3);
            Console.WriteLine("PrintSpacesAndStars(3):");
            PrintSpacesAndStars(3);
            Console.WriteLine("SandWatchOfStars(50):");
            SandWatchOfStars(50);
            Console.WriteLine("PrintStarsBelly(3):");
            PrintStarsBelly(3);
        }
    }
}
