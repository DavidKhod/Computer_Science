using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P80Q28
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if ((num%2>0)&&(num%3>0)&&(num%4>0))
            {
                Console.WriteLine("The amount of kids in the group is the same as shoshi's group of kids");
            }
            else
            {
                Console.WriteLine("The amount of kids in the group is not the same as shoshi's group of kids");
            }
        }
    }
}
