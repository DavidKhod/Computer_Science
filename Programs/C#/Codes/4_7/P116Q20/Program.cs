using System;

namespace P116Q20
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyBox[,] shop = new MoneyBox[6, 5];
            for (int i = 0; i < shop.GetLength(0); i++)
            {
                for (int j = 0; j < shop.GetLength(1); j++)
                {
                    Console.WriteLine($"({i + 1},{j + 1})Enter the cashier's name: ");
                    shop[i, j] = new MoneyBox(Console.ReadLine());
                }
            }
            int department;
            int cashRegister;
            double moneyInputed = -1;
            while (moneyInputed != 0)
            {
                Console.Write($"Enter the department: ");
                department = int.Parse(Console.ReadLine());
                Console.Write($"Enter the cash register: ");
                cashRegister = int.Parse(Console.ReadLine());
                Console.Write($"Enter the amount of money got: ");
                shop[department-1, cashRegister-1].Money += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < shop.GetLength(0); i++)
            {
                for (int j = 0; j < shop.GetLength(1); j++)
                {
                    Console.Write($"({i+1},{j+1}){shop[i,j].ToString()}\n");
                }
                Console.WriteLine();
            }
        }
    }
}
