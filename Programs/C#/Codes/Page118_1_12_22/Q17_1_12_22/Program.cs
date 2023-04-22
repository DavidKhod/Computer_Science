using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17_1_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 58; i++)
            {
                int MathGrade, PhysicsGrage, ComputerGrade;
                double Average;
                Console.WriteLine("Enter the student's grade in math");
                MathGrade = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's grade in physics");
                PhysicsGrage = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's grade in computer science");
                ComputerGrade = int.Parse(Console.ReadLine());
                Average = (MathGrade+ PhysicsGrage+ ComputerGrade) / 3;
                if (Average>92 && ComputerGrade > 90 && PhysicsGrage>90 && MathGrade>90)
                {
                    Console.WriteLine($"Student {i}, average grade = {Average}");
                }
            }
        }
    }
}
