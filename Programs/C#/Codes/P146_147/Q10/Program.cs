using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            char Vote;
            int Yes = 0, No = 0, Denied = 0, Sum = 0;

            Console.WriteLine("Enter your vote");
            Vote = char.Parse(Console.ReadLine());
            while (Vote != 'f')
            {
                if (Vote == 'y')
                {
                    Yes++;
                }
                if (Vote == 'n')
                {
                    No++;
                }
                if (Vote == 'd')
                {
                    Denied++;
                }
                Console.WriteLine("Enter your vote");
                Vote = char.Parse(Console.ReadLine());
            }
            Sum = Yes + No + Denied;
            Console.WriteLine($"Voted yes = {Yes}, Voted no = {No},Decided not to vote = {Denied}");
            if (Yes >= 0.6 * Sum)
            {
                Console.WriteLine("The reforme is good to go");
            }
        }
    }
}
