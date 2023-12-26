using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double finalGrade = 0,diff,grade2,grade1;
            int score;
            string name, name1, name2,second = "",forth = "";
            int max = 0, min = 11;
            Console.WriteLine("Enter your country");
            name = Console.ReadLine();
            Console.WriteLine("Enter your score");
            score = int.Parse(Console.ReadLine());
            finalGrade += score;
            if (score > max)
            {
                max = score;
            }
            if (score < min)
            {
                min = score;
            }
            Console.WriteLine("Enter your difficulty score");
            diff = double.Parse(Console.ReadLine());
            finalGrade = (finalGrade - max - min) * diff;
            name1 = name;
            name2 = name;
            grade1 = finalGrade;
            grade2 = finalGrade;
            while (name != "")
            {
                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine("Enter your score");
                    score = int.Parse(Console.ReadLine());
                    finalGrade += score;
                    if (score > max)
                    {
                        max = score;
                    }
                    if (score < min)
                    {
                        min = score;
                    }
                }
                Console.WriteLine("Enter your difficulty score");
                diff = double.Parse(Console.ReadLine());
                finalGrade = (finalGrade - max - min) * diff;
                if (finalGrade > grade1)
                {
                    forth += $"|{name}| ";
                    grade2 = grade1;
                    name2 = name1;
                    grade1 = finalGrade;
                    name1 = name;
                }
                if (finalGrade < grade1 && finalGrade > grade2)
                {
                    forth += $"|{name2}| ";
                    grade2 = finalGrade;
                    name2 = name;
                }
            }
        }
    }
}
