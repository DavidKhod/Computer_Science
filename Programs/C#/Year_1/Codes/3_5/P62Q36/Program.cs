using System;

namespace P62Q36
{
    class Program
    {
        static double FindAvg(int[] arr)
        {
            double sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / (arr.Length - 1);
        }

        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the amount of participants: ");
            int[] votingScores = new int[int.Parse(Console.ReadLine()) + 1];
            int place, vote;
            for (int i = 1; i < votingScores.Length; i++)
            {
                Console.Write("Enter your place: ");
                place = int.Parse(Console.ReadLine());
                Console.Write("Enter your vote(1/0): ");
                vote = int.Parse(Console.ReadLine());
                while (vote != 1 && vote != 0)
                {
                    Console.WriteLine("Error!");
                    Console.Write("Enter your vote(1/0): ");
                    vote = int.Parse(Console.ReadLine());
                }
                while (place != -999 && place != 0)
                {
                    votingScores[i] += vote;
                    Console.Write("Enter your place: ");
                    place = int.Parse(Console.ReadLine());
                    Console.Write("Enter your vote(1/0): ");
                    vote = int.Parse(Console.ReadLine());
                    while (vote != 1 && vote != 0)
                    {
                        Console.WriteLine("Error!");
                        Console.Write("Enter your vote(1/0): ");
                        vote = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("----Next Participant----");
            }
            int max = 0, maxPlace = 0;
            double avg = FindAvg(votingScores);
            string underAvgPlaces = "Under Average: ";
            for (int i = 1; i < votingScores.Length; i++)
            {
                if (votingScores[i] > max)
                {
                    max = votingScores[i];
                    maxPlace = i;
                }
                if (votingScores[i] < avg)
                {
                    underAvgPlaces += $"{votingScores[i]} ";
                }
            }
            Console.WriteLine($"The first place in votes for is {maxPlace}");
            Console.WriteLine(underAvgPlaces);
            PrintArray(votingScores);
        }
    }
}
