using System;

namespace Task7_5
{
    class Program
    {
        static Random rnd = new Random();
        static DoubleQueue RandomizeDoubleQueue()
        {
            DoubleQueue main = new DoubleQueue();
            for (int i = 0; i < rnd.Next(1, 11); i++)
                main.InsertClientToQueue(rnd.Next(1001), 0);
            for (int i = 0; i < rnd.Next(1, 11); i++)
                main.InsertClientToQueue(rnd.Next(1001), 1);
            return main;

        }
        static void Main(string[] args)
        {
            TestDoubleQueue();
        }

        static void TestDoubleQueue()
        {
            DoubleQueue dobQue = RandomizeDoubleQueue();
            int input = -1;
            while (input != -999)
            {
                Console.Write($"[0 - Add Customer, 1 - Return Queue by act,2 - Next Customer, -999 - STOP: ");
                input = int.Parse(Console.ReadLine());
                int act;
                switch (input)
                {
                    case 0:
                        Console.Write($"Enter Customer Bank account: ");
                        int bankAc = int.Parse(Console.ReadLine());
                        Console.Write($"Which Queue?[0 -> long,1 -> short]: ");
                        act = int.Parse(Console.ReadLine());
                        dobQue.InsertClientToQueue(bankAc, act);
                        break;
                    case 1:
                        Console.Write($"Which Queue?[0 -> long,1 -> short]: ");
                        act = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{dobQue.ReturnByAct(act).ToString()}");
                        break;
                    case 2:
                        Console.WriteLine($"Cusomter Removed: {dobQue.GetNextClient()}");
                        break;
                }
            }
            Console.WriteLine($"\n{dobQue.ToString()}");
        }
    }
}
