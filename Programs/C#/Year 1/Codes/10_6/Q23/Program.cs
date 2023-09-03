using System;
namespace Q23
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, OpNum = 0;
            Console.WriteLine("Enter a number");
            Num = int.Parse(Console.ReadLine());
            OpNum = Num % 10;
            while (Num != 0)
            {
                Num = Num / 10;
                if (Num > 0)
                {
                    OpNum *= 10;
                    OpNum += Num % 10;
                }
            }
            Console.WriteLine(OpNum);
        }
    }
}
