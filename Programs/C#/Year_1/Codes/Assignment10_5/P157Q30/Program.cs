using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P157Q30
{
    class Program
    {
        static void Main(string[] args)
        {
            int LyTimes = 0, ShirTimes = 0,count=1;
            while (!(LyTimes == 3 || ShirTimes == 3))
            {
                string LyGot = "N", ShirGot = "N";
                if (count % 2 != 0)
                {
                    Console.WriteLine("Enter what Ly got");
                    LyGot = Console.ReadLine();
                }
                else if (count % 2 == 0)
                {
                    Console.WriteLine("Enter What shir got");
                    ShirGot = Console.ReadLine();
                }
                Console.WriteLine("Enter What shir got");
                ShirGot = Console.ReadLine();
                if (LyGot == "Tree" || LyGot == "tree")
                {
                    LyTimes++;
                }
                if (ShirGot == "Tree" || ShirGot == "tree")
                {
                    ShirTimes++;
                }
                count++;
            }
            if (LyTimes >= ShirTimes)
            {
                Console.WriteLine("Ly starts the game");
            }
            if (ShirTimes > LyTimes)
            {
                Console.WriteLine("Shir starts the game");
            }
        }
    }
}
