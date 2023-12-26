using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace P245Q7_20_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;
            double Speed1,Speed2;
            int memory1, memory2, price1, price2;
            Console.WriteLine("Enter the name of model of this PC");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter the speed of its proccesor");
            Speed1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of memory this pc has");
            memory1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of this PC");
            price1 = int.Parse(Console.ReadLine());
            Computer PC1 = new Computer(name1,Speed1,memory1,price1);
            Console.WriteLine("Enter the name of model of this PC");
            name2 = Console.ReadLine();
            Console.WriteLine("Enter the speed of its proccesor");
            Speed2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of memory this pc has");
            memory2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of this PC");
            price2 = int.Parse(Console.ReadLine());
            Computer PC2 = new Computer(name2, Speed2, memory2, price2);
            int Null = PC1.GetMem();
            PC1.SetMem(PC2.GetMem());
            PC2.SetMem(Null);
            PC1.SetMem(PC1.GetMem()+100);
            PC2.SetMem(PC2.GetMem() + 100);
            Console.WriteLine(PC1);
            Console.WriteLine(PC2);
        }
    }
    }

