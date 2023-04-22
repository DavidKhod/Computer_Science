using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P85_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            int PhycGrade;
            double BagAvg;
            Console.WriteLine("Enter you psychometric test grade");
            PhycGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you Bagrut avrage grade");
            BagAvg = double.Parse(Console.ReadLine());
            if (BagAvg>=90 && !(PhycGrade>=600))
            {
                Console.WriteLine("you need to improve you psychometric grade to pass");
            }
            else
            {
                if (!(BagAvg >= 90) && (PhycGrade >= 600))
                {
                    Console.WriteLine("You neet to improve you bagrut avrage grade to pass");
                }
                else
                {
                    if (!(BagAvg >= 90) && !(PhycGrade >= 600))
                    {
                        Console.WriteLine("You cannot join");
                    }
                    else
                    {
                        Console.WriteLine("You are able to join this special class");
                    }
                }
            }
            }
        }
    }

