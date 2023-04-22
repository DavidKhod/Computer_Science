using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_OF_EXAMS = 6,STUDENT_NUM = 10;
            int Grade, fail = 0;
            for (int i = 1; i <= STUDENT_NUM; i++)
            {
                int Avg, Sum = 0;
                for (int j = 1; j <= NUM_OF_EXAMS; j++)
                {
                    Console.WriteLine("Enter your grade");
                    Grade = int.Parse(Console.ReadLine());
                    if (Grade < 55)
                    {
                        fail++;
                    }
                    Sum += Grade;
                }
                Avg = Sum / NUM_OF_EXAMS;
                Console.WriteLine($"Your average grade is {Avg}");
            }
            Console.WriteLine($"The amount of failures is {fail}");
        }
    }
}
