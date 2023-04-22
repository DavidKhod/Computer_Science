using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P87_Q46_11_3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Triangle,Even,Sort,Equal;
            int Side1 , Side2 , side3;
            int num ,n1,n2,n3,Num;
            Console.WriteLine("Enter Side1");
            Side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side2");
            Side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side3");
            side3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num for B");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n3");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num for D");
            Num = int.Parse(Console.ReadLine());
            if (Side1+Side2>side3 && Side1+side3>Side2 && side3+Side2>Side1)
            {
                Triangle = true;
            }
            else
            {
                Triangle = false;
            }
            if (!(num%2==0))
            {
                Even = false;
            }
            else
            {
                Even = true;
            }
            if (n1<n2 && n2<n3)
            {
                Sort = true;
            }
            else
            {
                Sort = false;
            }
            if (!(Num%10==Num/10))
            {
                Equal = false;
            }
            else
            {
                Equal = true;
            }
        }

    }
}
