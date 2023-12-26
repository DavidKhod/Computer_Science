using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_rndm
{
    class Program
    {
        static void Main(string[] args)
        {
            int Day;
            Console.WriteLine("Enter the day number");
            Day = int.Parse(Console.ReadLine());
            if (Day == 1)
            {
                Console.WriteLine("Today is Sunday");

            }
            else
            {
                if (Day == 2)
                {
                    Console.WriteLine("Today is Monday");
                }
                else
                {
                    if (Day == 3)
                    {
                        Console.WriteLine("Today is Tuesday");
                    }
                    else
                    {
                        if (Day == 4)
                        {
                            Console.WriteLine("Today is Wednesday");
                        }
                        else
                        {
                            if (Day == 5)
                            {
                                Console.WriteLine("Today is Thursday");
                            }
                            else
                            {
                                if (Day == 6) 
                                {
                                    Console.WriteLine("Today is Friday");
                                }
                                else
                                {
                                    if (Day == 7)
                                    {
                                        Console.WriteLine("Today is saturday");
                                    }
                                    else
                                    {
                                        if (Day > 7)
                                        {
                                            Console.WriteLine("Today is not real");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
