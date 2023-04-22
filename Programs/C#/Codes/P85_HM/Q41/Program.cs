using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q41
{
    class Program
    {
        static void Main(string[] args)
        {
            char Gender1, Gender2;
            int age1, age2;
            int Group1=0, Group2=0;
            Console.WriteLine("Enter the age of the first indevidual");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender of the first indevidual");
            Gender1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second indevidual");
            age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender of the Second indevidual");
            Gender2 = char.Parse(Console.ReadLine());
            if (age1<8)
            {
                Console.WriteLine("The first indevidual is in group A");
                Group1 = 1;
            }
            else
            {
                if (age1>=8 && age1<13)
                {
                    Console.WriteLine("The first indevidual is in group B");
                    Group1 = 2;
                }
                else
                {
                    if (age1>=13 && age1<=17)
                    {
                        Console.WriteLine("The first indevidual is in group C");
                        Group1 = 3;
                    }
                    else
                    {
                        Console.WriteLine("The first's indevidual age is not for any of the groups");
                    }
                }
            }
            if (age2 < 8)
            {
                Console.WriteLine("The Second indevidual is in group A");
                Group2 = 1;
            }
            else
            {
                if (age2 >= 8 && age2 < 13)
                {
                    Console.WriteLine("The Second indevidual is in group B");
                    Group2 = 2;
                }
                else
                {
                    if (age2 >= 13 && age2 <= 17)
                    {
                        Console.WriteLine("The Second indevidual is in group C");
                        Group2 = 3;
                    }
                    else
                    {
                        Console.WriteLine("The second's indevidual age is not for any of the groups");
                    }
                }
            }
            if ((Group1==Group2&&Gender1==Gender2))
            {
                Console.WriteLine("They can fight");
            }
            else
            {
                Console.WriteLine("They can't fight");
            }
        }
    }
}
