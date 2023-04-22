using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42
{
    class Program
    {
        static void Main(string[] args)
        {
            double Price1, Price2, Price3, Price4;
            Console.WriteLine("Enter the first bid");
            Price1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second bid");
            Price2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Thirt bid");
            Price3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entet the fourth bid");
            Price4 = double.Parse(Console.ReadLine());
            if (Price1>Price2&&Price1>Price3&&Price1>Price4)
            {
                Console.WriteLine("The car was bought for was " + Price1);
            }
            else
            {
                if (Price2 > Price1 && Price2 > Price3 && Price2 > Price4)
                {
                    Console.WriteLine("The car was bought for was "+Price2);
                }
                else
                {
                    if (Price3 > Price1 && Price3 > Price2 && Price3 > Price4)
                    {
                        Console.WriteLine("The car was bought for was " + Price3);
                    }
                    else
                    {
                        if (Price4 > Price1 && Price4 > Price3 && Price4 > Price2)
                        {
                            Console.WriteLine("The car was bought for was " + Price4);
                        }
                        else
                        {
                            Console.WriteLine("All the bids were the same");
                        }
                    }
                }
            }
        }
    }
}
