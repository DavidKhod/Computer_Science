using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace NumbersQ_22_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3,Dif1,Dif2,Dif3,SmallestDif1,SmallestDif2;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            num3 = int.Parse(Console.ReadLine());
            Numbers threenum = new Numbers(num1, num2, num3);
            Dif1 = Math.Abs(threenum.GetN1() - threenum.GetN2());
            Dif2 = Math.Abs(threenum.GetN2() - threenum.GetN3());
            Dif3 = Math.Abs(threenum.GetN3() - threenum.GetN1());
            SmallestDif1 = Math.Min(Dif1,Dif2);
            SmallestDif2 = Math.Min(SmallestDif1,Dif3);
            Couple Couple1 = new Couple(0, 0);
            if (SmallestDif2==Dif1)
            {
                Couple1.SetNum1(num1);
                Couple1.SetNum2(num2);
            }
            else if (SmallestDif2==Dif2)
            {
                Couple1.SetNum1(num2);
                Couple1.SetNum2(num3);   
            }
            else if (SmallestDif2==Dif3)
            {
                Couple Couple3 = new Couple(num3, num1);
                Couple1.SetNum1(num3);
                Couple1.SetNum2(num1);
            }
            Console.WriteLine(Couple1);
        }
    }
}
