using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_OOP
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Box Box1 = new Box(12, 8.2, 5);
            Console.WriteLine(Box1.ToString()); // הדפסת מצב העצם
            double volume = Box1.GetLength() * Box1.GetWidth() * Box1.GetHeight();
            Console.WriteLine("Volume1 = "+volume);
            Box Box2 = new Box(rnd.Next(5, 16),rnd.Next(1,16),rnd.Next(5,16));
            double volume2 = Box2.GetLength() * Box2.GetWidth() * Box2.GetHeight();
            Console.WriteLine(Box2.ToString());
            Console.WriteLine("volume2 = " + volume2);
            if (Box1.GetVolume() > Box2.GetVolume())
            {
                Console.WriteLine("The first box's volume is bigger");
            }
            else if (Box1.GetVolume() < Box2.GetVolume())
            {
                Console.WriteLine("The second's box volume is bigger");
            }
            else
            {
                Console.WriteLine("equal");
            }
        }
    }
}
