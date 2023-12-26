using System;

namespace Q19
{
    class Program
    {
        static int PointsForPoints(int Points, int grade)
        {
            if (Points == 5)
            {
                return grade + 20;
            }
            else if (Points == 4)
            {
                return grade + 10;
            }
            else
            {
                return grade;
            }
            
        }
        static void Main(string[] args)
        {
            int points, grade, sum = 0;
            int i = 1;
            double avg;
            Console.WriteLine("Enter your grade (1)");
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your points in grade (1)");
            points = int.Parse(Console.ReadLine());
            while (grade > 0 && points > 0)
            {
                i++;
                sum += PointsForPoints(points, grade);
                Console.WriteLine($"Enter your grade ({i})");
                grade = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your points in grade 1");
                points = int.Parse(Console.ReadLine());
            }
            avg = sum / i;
            Console.WriteLine($"The average is {avg}");
        }
    }
}
