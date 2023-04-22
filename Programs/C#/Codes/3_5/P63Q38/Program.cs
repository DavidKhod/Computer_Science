using System;

namespace P63Q38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] compition = new int[51];
            int first = 0, second = 0, third = 0;
            int firstChoice, secondChoice, thirdChoice;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Judge {i}");
                Console.Write($"Choose first place: ");
                firstChoice = int.Parse(Console.ReadLine());
                compition[firstChoice] += 3;
                Console.Write($"Choose second place: ");
                secondChoice = int.Parse(Console.ReadLine());
                compition[secondChoice] += 2;
                Console.Write($"Choose third place: ");
                thirdChoice = int.Parse(Console.ReadLine());
                compition[thirdChoice] += 1;
            }
            first = compition[1];
            second = compition[2];
            third = compition[3];
            string firstPlace = $"{first}", secondPlace = $"{second}", thirdPlace = $"{third}";
            for (int i = 4; i < compition.Length; i++)
            {
                if (compition[i] > first)
                {
                    third = second;
                    second = first;
                    first = compition[i];
                    firstPlace = $"First Place: {first}";
                    secondPlace = $"Second Place; {second}";
                    thirdPlace = $"Third Place: {third}";
                }
                else if (compition[i] < first && compition[i] > second)
                {
                    third = second;
                    thirdPlace = $"Third Place: {third}";
                    second = compition[i];
                    secondPlace = $"Second Place: {second}";
                }
                else if (compition [i] < third)
                {
                    third = compition[i];
                    thirdPlace = $"Third Place: {third}";
                }
            }
            Console.WriteLine($"{firstPlace},{secondPlace},{thirdPlace}");

        }
    }
}
