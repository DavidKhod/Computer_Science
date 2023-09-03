using System;

namespace CompObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent("Udi Omer", "04012315");
            Console.WriteLine(p1.ToString());

            Student s1 = new Student("David", "054-2427799", p1);
            Console.WriteLine($"{s1.ToString()}");

            Student s2 = new Student();

            Console.Write($"Enter you name: ");
            s2.Name = Console.ReadLine();
            Console.Write($"Enter you cell phone number: ");
            s2.CellNum = Console.ReadLine();

            Parent p2 = new Parent();
            Console.Write("Enter you parents name: ");
            p2.Name = Console.ReadLine();
            Console.Write($"Enter your parent's cell phone number: ");
            p2.CellNum = Console.ReadLine();
            s2.Parents = p2;
            Console.WriteLine($"{s2.ToString()}");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Your parent's name is: {s2.Parents.Name}");

        }
    }
}
