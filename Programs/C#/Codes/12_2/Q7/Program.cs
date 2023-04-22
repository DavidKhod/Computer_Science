using System;

namespace Q7
{
    class Program
    {
        //Entry Claim: The funcion gets the amount of people and the capacity of the (Chosen Item)
        //Exit Claim: The function returns the amount of (Chosen Item) needed 
        static int ItemsNeeded(int PeopleAmount, int Capacity)
        {
            int Count = 0;
            if (PeopleAmount % Capacity == 0)
            {
                Count = PeopleAmount / Capacity;
            }
            else
            {
                Count = (PeopleAmount / Capacity) + 1;
            }
            return Count;
        }
        static void Main(string[] args)
        {
            int People, TableSpace, BusSpace, BoatSpace;
            Console.WriteLine("Enter the amount of people that were invited to the party");
            People = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the capacity of a table: ");
            TableSpace = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the capacity of a bus: ");
            BusSpace = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the capacity of a boat: ");
            BoatSpace = int.Parse(Console.ReadLine());
            int CountTables = ItemsNeeded(People, TableSpace);
            int CountBuses = ItemsNeeded(People, BusSpace);
            int CountBoats = ItemsNeeded(People, BoatSpace);
            Console.WriteLine($"The amount of tables needed is {CountTables}");
            Console.WriteLine($"The amount of buses needed is {CountBuses}");
            Console.WriteLine($"The amount of boats needed is {CountBoats}");
        }
    }
}
