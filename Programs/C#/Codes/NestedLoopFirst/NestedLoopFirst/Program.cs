using System;

namespace NestedLoopFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int Grade = 0, Count, Sum;
            string Name, AllClass = "";
            double Avg;
            string[] arr = new string[2];
            for (int i = 1; i <= 2; i++)
            {
                Sum = 0;
                Count = 0;
                Grade = 0;
                Console.WriteLine($"Enter student's {i} name");
                Name = Console.ReadLine();
                while (Grade != -1)
                {
                    Sum += Grade;
                    Count++;
                    Console.WriteLine("Enter Grade,To end -1");
                    Grade = int.Parse(Console.ReadLine());
                }
                Avg = Sum / Count;
                AllClass += $"Name:{Name},Average:{Avg} ";
                arr[i] = $"Name:{Name},Average:{Avg}";


            }
            Console.WriteLine(AllClass);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
        }
    }
}
