using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_6_1_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,count = 1,Digit = 0,Times = 10,NewNum;
            Console.WriteLine("Enter a natural number");
            num = int.Parse(Console.ReadLine());
            NewNum = num % 10;
            while (num - NewNum != 0)
            {
                Digit = num / Times % 10;
                if (Digit == 0)
                {
                    NewNum += 1 * Times;
                }
                else
                {
                    NewNum += Digit * Times;
                }
                Times = Times * 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
