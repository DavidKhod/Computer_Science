using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace HomeWork_22_11_22
{
    class Program
    {
        static void Main(string[] args)//מחלקה Couple
        {
            int age1, age2;
            Console.WriteLine("Enter the first age of the first indevidual");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second indevidual");
            age2 = int.Parse(Console.ReadLine());
            Couple c1 = new Couple(age1,age2);
            Couple c2 = new Couple(Math.Min(age1,age2),Math.Max(age1,age2));
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            if (c1.GetNum1()==c2.GetNum1()&&c1.GetNum2()==c2.GetNum2())
            {
                Console.WriteLine("couple one ages and couple two ages are the same");
            }
            else
            {
                Console.WriteLine("couple one ages and couple two ages are not the same");
            }
        }
    }
}
