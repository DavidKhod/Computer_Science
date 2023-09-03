using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kids,Fallen1,Fallen2,Left;
            Console.WriteLine("Enter the amount of kids playing");
            Kids = int.Parse(Console.ReadLine());
            Fallen1 = Kids / 7;
            Console.WriteLine("The amount of kids that leave in the first round is "+Fallen1);
            Fallen2 = (Kids - Fallen1)/7;
            Left = (Kids - Fallen1) - Fallen2;
            Console.WriteLine("The amount of kids left after the second round is "+Left);
        }
    }
}
