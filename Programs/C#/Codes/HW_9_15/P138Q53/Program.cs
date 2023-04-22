using System;

namespace P138Q53
{
    class Program
    {
        static void Main(string[] args)
        {
            string CarsUnder4IDs = "";
            int CarsUnder4Minutes = 0;
            double TimeTaken, AverageTime, SumTimeTaken = 0;
            string CarID;
            Console.Write("Enter your car's ID:");
            CarID = Console.ReadLine();
            Console.Write("Enter the time it took you to go through the race track(In minutes):");
            TimeTaken = double.Parse(Console.ReadLine());
            if (TimeTaken > 5)
            {
                Console.WriteLine("You are not able to continue to the next step");
            }
            if (TimeTaken < 4)
            {
                CarsUnder4Minutes++;
                CarsUnder4IDs += $"{CarID} ";
            }
            SumTimeTaken += TimeTaken;
            Console.WriteLine("    ");
            for (int i = 2; i <= 10; i++)
            {
                Console.Write("Enter your car's ID:");
                CarID = Console.ReadLine();
                Console.Write("Enter the time it took you to go through the race track(In minutes):");
                TimeTaken = double.Parse(Console.ReadLine());
                if (TimeTaken > 5)
                {
                    Console.WriteLine("You are not able to continue to the next step");
                }
                if (TimeTaken < 4)
                {
                    CarsUnder4Minutes++;
                    CarsUnder4IDs += $",{CarID} ";
                }
                SumTimeTaken += TimeTaken;
                Console.WriteLine("    ");
            }
            AverageTime = SumTimeTaken / 10;
            Console.WriteLine($"The amount of cars that got under 4 Minutes is {CarsUnder4Minutes}");
            Console.WriteLine($"And their car numbers are {CarsUnder4IDs}");
            Console.WriteLine($"The average time taken to finish the race is {AverageTime}");


        }
    }
}
