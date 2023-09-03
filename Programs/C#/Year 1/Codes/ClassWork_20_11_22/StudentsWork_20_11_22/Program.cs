using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace StudentsWork_20_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name1;
            int Grade1, Grade2, Grade3,Biggest,MMiddle,Smallest;
            Console.WriteLine("Enter the name of the student");
            Name1 = Console.ReadLine();
            Student student1 = new Student(Name1);
            Console.WriteLine("Enter the first grade");
            Grade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second grade");
            Grade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third grade");
            Grade3 = int.Parse(Console.ReadLine());
            student1.AddGrd(Grade1);
            student1.AddGrd(Grade2);
            student1.AddGrd(Grade3);
            Console.WriteLine(student1);
            double average = (double)(Grade1 + Grade2 + Grade3) / 3;
            Console.WriteLine("The average grade is " + ((Grade1 + Grade2 + Grade3) / 3));
            Biggest = Math.Abs(Math.Max(Math.Max(Grade1, Grade2), Grade3));
            Smallest = Math.Abs(Math.Min(Math.Min(Grade1, Grade2), Grade3));
            double Middle = (average * 3) - Biggest - Smallest;
            Console.WriteLine("Biggest Grade =" + Biggest);
            Console.WriteLine("Middle Grade =" + Middle);
            Console.WriteLine("Smallest Grade =" + Smallest);
        }
    }
}
