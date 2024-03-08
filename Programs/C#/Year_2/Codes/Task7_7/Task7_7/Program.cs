using System;
using System.Threading;
namespace Task7_7
{
    internal class Program
    {
        static Random rnd = new Random();
        static void TwoLevelQueueQ2()
        {
            TwoLevelQueue<int> twinQue = new TwoLevelQueue<int>();
            while (twinQue.Size(1) <= 7 && twinQue.Size(2) <= 7)
            {
                int choice = rnd.Next(1, 3);
                if (choice == 1)
                {
                    int num = rnd.Next(10, 100);
                    if ((num % 10) % 2 == 0 && (num / 10) % 2 == 0)
                    {
                        twinQue.Insert(num, 1);
                        Console.WriteLine($"Inserted to q1: {num}");
                    }
                    else
                    {
                        twinQue.Insert(num, 2);
                        Console.WriteLine($"Inserted to q2: {num}");
                    }
                }
                else
                {
                    if (!twinQue.IsEmpty())
                    {
                        Console.WriteLine($"Removed: {twinQue.Remove()}");
                    }
                }
                Thread.Sleep(250);
            }
            Console.WriteLine("The length of one of the queues went over 7!");
        }
        static void Main(string[] args)
        {
            TwoLevelQueueQ2();
        }
    }
}
