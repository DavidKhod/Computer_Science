using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q44
{
    class Program
    {
        static void Main(string[] args)
        {
            int niv, dana, nema;
            Console.WriteLine("Enter the amount of votes niv got");
            niv = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of votes dana got");
            dana = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of votes nema got");
            nema = int.Parse(Console.ReadLine());
            if ((niv==dana&&dana==nema))
            {
                Console.WriteLine("The votes were the same");
            }
            else
            {
                if (niv > dana && niv > nema)
                {
                    if (dana>nema)
                    {
                        Console.WriteLine("Niv 1st place");
                        Console.WriteLine("Dana 2nd place");
                        Console.WriteLine("nema 3rd place");
                    }
                    else
                    {
                        Console.WriteLine("Niv 1st place");
                        Console.WriteLine("nema 2nd place");
                        Console.WriteLine("Dana 3rd place");
                    }
                }
                else
                {
                    if (dana > niv && dana > nema)
                    {
                        if (niv > nema)
                        {
                            Console.WriteLine("Dana 1st place");
                            Console.WriteLine("Niv 2nd place");
                            Console.WriteLine("nema 3rd place");
                        }
                        else
                        {
                            Console.WriteLine("Dana 1st place");
                            Console.WriteLine("Nema 2nd place");
                            Console.WriteLine("Niv 3rd place");
                        }
                    }
                    else
                    {
                        if (nema > niv && nema > dana)
                        {
                            if (niv>dana)
                            {
                                Console.WriteLine("Nema 1st place");
                                Console.WriteLine("Niv 2nd place");
                                Console.WriteLine("Dana 3rd place");
                            }
                            else
                            {
                                Console.WriteLine("Nema 1st place");
                                Console.WriteLine("Dana 2nd place");
                                Console.WriteLine("Niv 3rd place");
                            }
                        }
                    }
                }
            }
        }
    }
}
