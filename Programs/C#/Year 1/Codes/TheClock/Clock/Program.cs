using System;
using System.Threading;

namespace Clock
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("__________");
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    for (int seconds = 0; seconds < 60; seconds++)
                    {
                        Console.WriteLine("|" + hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2") + "|");
                        Thread.Sleep(1000);
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    }
                }
            }
        }
    }
}
