using System;

namespace HelpingOsherPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int First, Second, Third;
            int SpeedGot;
            string CarID;
            string FirstID ="", SecondID = "", ThirdID = "";
            int RacersAmount;
            Console.Write("Enter the amount of racer participated: ");
            RacersAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter the ID of car 1 : ");
            CarID = Console.ReadLine();
            FirstID = CarID;
            Console.Write($"Enter the speed {CarID} got to on the finish line: ");
            SpeedGot = int.Parse(Console.ReadLine());
            First = SpeedGot;
            Second = 1;
            Third = 0;
            Console.WriteLine("        ");
            for (int i = 2; i <= RacersAmount; i++)
            {
                Console.Write($"Enter the ID of car {i}: ");
                CarID = Console.ReadLine();
                Console.Write($"Enter the speed {CarID} got to on the finish line: ");
                SpeedGot = int.Parse(Console.ReadLine());
                if (SpeedGot > First)
                {
                    Third = Second;
                    ThirdID = SecondID;
                    Second = First;
                    SecondID = FirstID;
                    First = SpeedGot;
                    FirstID = CarID;
                }
                if (SpeedGot < First && SpeedGot > Second)
                {
                    Third = Second;
                    ThirdID = SecondID;
                    SecondID = CarID;
                    Second = SpeedGot;
                }
                if (SpeedGot < First && SpeedGot < Second && SpeedGot > Third)
                {
                    ThirdID = CarID;
                    Third = SpeedGot;
                }
                Console.WriteLine("       ");
            }
            Console.WriteLine($"The first place is {FirstID} with the speed of {First}");
            Console.WriteLine($"The Second place is {SecondID} with the speed of {Second}");
            Console.WriteLine($"The third place is {ThirdID} with the speed of {Third}");

        }
    }
}
