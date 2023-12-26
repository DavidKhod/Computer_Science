using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace StudentAverageQ_22_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name1;
            int Grade1, Grade2, Grade3,Smallest;
            double Average1,Average2;
            Console.WriteLine("Enter the Student's name");
            Name1 = Console.ReadLine();
            Student Student1 = new Student(Name1);
            Console.WriteLine("Enter His/Her's first grade");
            Grade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter His/Her's Second grade");
            Grade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter His/Her's Third grade");
            Grade3 = int.Parse(Console.ReadLine());
            Student1.AddGrd(Grade1);
            Student1.AddGrd(Grade2);
            Student1.AddGrd(Grade3);
            Smallest = Math.Min(Math.Min(Grade1,Grade2),Grade3);
            Average1 = (Grade1 + Grade2 + Grade3)/3;
            Average2 = ((Average1 * 3) - Smallest) / 2;
            if (Smallest==Average2)
            {
                Average2 = Average2 + 5;
                Console.WriteLine(Average2);
            }
            else
            {
                Console.WriteLine(Average2);
            }

        }
    }
}
