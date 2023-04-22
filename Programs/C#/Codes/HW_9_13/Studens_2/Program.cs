using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace Studens_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student MaxDiffName;
            int MaxDiff = 0;
            string Name;
            int Grade1, Grade2, Grade3, Grade4;
            int Diff1, Diff2, Diff3, Diff4;
            Console.Write($"Enter student's 1 name: ");
            Name = Console.ReadLine();
            Student StudentTime = new Student(Name);
            Console.Write("Enter the first grade: ");
            Grade1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second grade: ");
            Grade2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third grade: ");
            Grade3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the forth grade: ");
            Grade4 = int.Parse(Console.ReadLine());
            StudentTime.AddGrd(Grade1);
            StudentTime.AddGrd(Grade2);
            StudentTime.AddGrd(Grade3);
            StudentTime.AddGrd(Grade4);
            Diff1 = Math.Abs(Grade1 - Grade2);
            Diff2 = Math.Abs(Grade2 - Grade3);
            Diff3 = Math.Abs(Grade3 - Grade4);
            Diff4 = Math.Abs(Grade4 - Grade1);
            MaxDiffName = StudentTime;
            if (Diff1 > MaxDiff)
            {
                MaxDiff = Diff1;
                MaxDiffName = StudentTime;
            }
            if (Diff2 > MaxDiff)
            {
                MaxDiff = Diff2;
                MaxDiffName = StudentTime;
            }
            if (Diff3 > MaxDiff)
            {
                MaxDiff = Diff3;
                MaxDiffName = StudentTime;
            }
            if (Diff4 > MaxDiff)
            {
                MaxDiff = Diff4;
                MaxDiffName = StudentTime;
            }
            for (int i = 2; i <= 25; i++)
            {
                Console.Write($"Enter student's {i} name: ");
                Name = Console.ReadLine();
                Student StudentTime1 = new Student(Name);
                Console.Write("Enter the first grade: ");
                Grade1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second grade: ");
                Grade2 = int.Parse(Console.ReadLine());
                Console.Write("Enter the third grade: ");
                Grade3 = int.Parse(Console.ReadLine());
                Console.Write("Enter the forth grade: ");
                Grade4 = int.Parse(Console.ReadLine());
                StudentTime1.AddGrd(Grade1);
                StudentTime1.AddGrd(Grade2);
                StudentTime1.AddGrd(Grade3);
                StudentTime1.AddGrd(Grade4);
                Diff1 = Math.Abs(Grade1 - Grade2);
                Diff2 = Math.Abs(Grade2 - Grade3);
                Diff3 = Math.Abs(Grade3 - Grade4);
                Diff4 = Math.Abs(Grade4 - Grade1);
                if (Diff1 > MaxDiff)
                {
                    MaxDiff = Diff1;
                    MaxDiffName = StudentTime1;
                }
                if (Diff2 > MaxDiff)
                {
                    MaxDiff = Diff2;
                    MaxDiffName = StudentTime1;
                }
                if (Diff3 > MaxDiff)
                {
                    MaxDiff = Diff3;
                    MaxDiffName = StudentTime1;
                }
                if (Diff4 > MaxDiff)
                {
                    MaxDiff = Diff4;
                    MaxDiffName = StudentTime1;
                }
            }
            Console.WriteLine($"The biggest difference is {MaxDiff}");
            Console.WriteLine($"The student with the biggest difference is {MaxDiffName}");
        }
    }
}
