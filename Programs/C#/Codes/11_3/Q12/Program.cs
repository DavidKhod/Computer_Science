using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID = 1, Grade = 0, SumGrade = 0;
            int CountGrade = 0, CountStudents = 0, CountOver90 = 0;
            double Avg;
            while (ID != 0)
            {
                Grade = 0;
                Avg = 0;
                SumGrade = 0;
                CountStudents++;
                Console.WriteLine("Enter your ID");
                ID = int.Parse(Console.ReadLine());
                while (Grade != -999 && ID != 0)
                {
                    SumGrade += Grade;
                    Console.WriteLine("Enter your grade");
                    Grade = int.Parse(Console.ReadLine());
                    if (Grade != -999)
                    {
                        CountGrade++;
                    }
                    if (CountGrade == 1 && Grade >= 90)
                    {
                        CountOver90++;
                    }
                }
                Avg = SumGrade / CountGrade;
                Console.WriteLine($"{ID} Avg = {Avg}");
            }
            Console.WriteLine($"The amount of students is {CountStudents}");
            Console.WriteLine($"The amount of studets that got over 90 in english is {CountOver90}");

        }
    }
}
