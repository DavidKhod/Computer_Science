using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours = 0;
            double Salary, AvgSalary, Sumsalary = 0;
            for (int i = 1; i <= 500; i++)
            {
                Hours = 0;
                Console.WriteLine("Enter your hourly salary");
                Salary = double.Parse(Console.ReadLine());
                for (int j = 1; j < 25; j++)
                {
                    int HourDay;
                    Console.WriteLine($"How many hours did you work on day {j}");
                    HourDay = int.Parse(Console.ReadLine());
                    Hours += HourDay;
                }
                Sumsalary += Salary * Hours;
                Console.WriteLine($"Worker {i} salary this month is {Salary}$");
            }
            AvgSalary = Sumsalary / 500;
            Console.WriteLine($"The average salary is {AvgSalary}");
        }
    }
}
