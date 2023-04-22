using ObjFirstMbt1; 
using System;
namespace Q2
{
    class Program
    {
        static Circle BiggestWithColor(Circle circle1, Circle circle2)
        {
            double biggestRad = 0;
            string smallestColor = "";
            if (circle1.GetRadius() >= circle2.GetRadius())
            {
                biggestRad = circle1.GetRadius();
                smallestColor = circle2.GetColor();
            }
            else
            {
                biggestRad = circle2.GetRadius();
                smallestColor = circle1.GetColor();
            }
            Circle biggest = new Circle(biggestRad, smallestColor);
            return biggest;
        }
        static void Main(string[] args)
        {
            int option;
            Console.Write("Enter your option ((1 = First Q) or (2 = Second Q)): ");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                double rad1, rad2;
                string color1, color2;
                Console.Write("Enter the radius of circle 1: ");
                rad1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the color of circle 1: ");
                color1 = Console.ReadLine();
                Console.Write("Enter the radius of circle 2: ");
                rad2 = double.Parse(Console.ReadLine());
                Console.Write("Enter the color of circle 2: ");
                color2 = Console.ReadLine();
                Circle circle1 = new Circle(rad1, color1);
                Circle circle2 = new Circle(rad2, color2);
                Console.WriteLine($"{BiggestWithColor(circle1, circle2)}");
            }
            else if (option == 2)
            {
                double rad1, rad2;
                string color1, color2;
                Console.Write("Enter the radius of circle 1: ");
                rad1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the color of circle 1: ");
                color1 = Console.ReadLine();
                Console.Write("Enter the radius of circle 2: ");
                rad2 = double.Parse(Console.ReadLine());
                Console.Write("Enter the color of circle 2: ");
                color2 = Console.ReadLine();
                Circle circle1 = new Circle(rad1, color1);
                Circle circle2 = new Circle(rad2, color2);
                double biggestRad = 0;
                string smallestColor = "";
                if (circle1.GetRadius() >= circle2.GetRadius())
                {
                    biggestRad = circle1.GetRadius();
                    smallestColor = circle2.GetColor();
                }
                else
                {
                    biggestRad = circle2.GetRadius();
                    smallestColor = circle1.GetColor();
                }
                Circle biggest = new Circle(biggestRad, smallestColor);
                Console.WriteLine(biggest);
            }
          
        }
    }
}
