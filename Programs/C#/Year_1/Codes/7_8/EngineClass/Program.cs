using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClass
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Engine WV = new Engine(rnd.Next(1,101), rnd.Next(1900,2024));
            Train Maxim = new Train(WV);
            for (int i = 0; i < rnd.Next(1,Maxim.GetLength()); i++)
            {
                int current = rnd.Next(1, 61);
                Maxim.AddCarriage(new Carriage(current, rnd.Next(current, 61)));
            }
            Console.WriteLine($"{Maxim.ToString()}");
            Console.WriteLine($"The average pass amount: {Maxim.AveragePassAmount()}");
            Console.WriteLine($"The max amount of pass possible: {Maxim.GetMaxPassAmount()}");
        }
    }
}
