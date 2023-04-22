using System;

namespace P67Q45
{
    class Program
    {
        /// <summary>
        /// Create a Travler variable
        /// </summary>
        /// <returns>The Travler variable from the user's input</returns>
        static Travler CreateTravler()
        {
            string name;
            int age, yearAmount;
            Console.Write("Enter name of the travler: ");
            name = Console.ReadLine();
            Console.Write("Enter the age of the travler: ");
            age = int.Parse(Console.ReadLine());
            Console.Write($"Amount of years with nature protection subscription of {name}: ");
            yearAmount = int.Parse(Console.ReadLine());
            Travler travler = new Travler(name, age, yearAmount);
            return travler;
        }

        static Random rnd = new Random();
        static Travler RandomizeTravler()
        {
            string name;
            int age, yearAmount;
            Console.Write("Enter name of the travler: ");
            name = Console.ReadLine();
            age = rnd.Next(1, 21);
            yearAmount = rnd.Next(1, age);
            Travler travler = new Travler(name, age, yearAmount);
            return travler;
        }

        static void Main(string[] args)
        {
            const int TRAVLERSAMOUNT = 3;
            int cntTravlersHalfLifeSub = 0;//The amount of travlers with the subscription more or equal to half of their life
            int cntUnderThreeSubYear = 0;//The amount of travlers with their subscription less than three years
            int sumAgeWSubUnderThree = 0;//The sum of ages of travlers with their subscription less than three years
            Travler[] Travlers = new Travler[TRAVLERSAMOUNT + 1];
            Travler tempTravler = RandomizeTravler();
            Travlers[1] = tempTravler;
            if (Travlers[1].GetYearAmont() >= Travlers[1].GetAge() / 2)
            {
                cntTravlersHalfLifeSub++;
            }
            if (Travlers[1].GetYearAmont() < 3)
            {
                cntUnderThreeSubYear++;
                sumAgeWSubUnderThree += Travlers[1].GetAge();
            }
            Travler minAgeTravler = tempTravler;
            for (int i = 2; i <= TRAVLERSAMOUNT; i++)
            {
                Travlers[i] = RandomizeTravler();
                if (Travlers[i].GetAge() < minAgeTravler.GetAge())
                {
                    minAgeTravler = Travlers[i];
                }
                if (Travlers[i].GetYearAmont() >= Travlers[i].GetAge() / 2)
                {
                    cntTravlersHalfLifeSub++;
                }
                if (Travlers[i].GetYearAmont() < 3)
                {
                    cntUnderThreeSubYear++;
                    sumAgeWSubUnderThree += Travlers[1].GetAge();
                }
            }
            Console.WriteLine($"The youngest travler is : {minAgeTravler.Tostring()}");
            Console.WriteLine($"The amount of travlers with a sub that is half their life is: {cntTravlersHalfLifeSub}");
            Console.WriteLine($"The average age of travlers that their sub is less than three is: {sumAgeWSubUnderThree / cntUnderThreeSubYear}");
        }
    }
}
