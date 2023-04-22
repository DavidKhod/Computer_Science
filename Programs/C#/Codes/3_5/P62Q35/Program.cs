using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P62Q35
{
    class Program
    {
        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($"|Show {i}: {arr[i]}| ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] show = new int[16];
            int cardAmount, showChoice;
            Console.WriteLine("Enter the amount of card you want");
            cardAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the show you want");
            showChoice = int.Parse(Console.ReadLine());
            while (showChoice != 0)
            {
                show[showChoice] += cardAmount;
                Console.WriteLine("Enter the amount of cards you want");
                cardAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the show you want(1-15)");
                showChoice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The show and the amount of cards needed:\n");
            PrintArray(show);
            int First = show[1], Second = show[2], Third = show[3];
            for (int i = 4; i < show.Length; i++)
            {
                if (show[i] > First)
                {
                    Third = Second;
                    Second = First;
                    First = show[i];
                }
                if (show[i] < First && show[i] > Second)
                {
                    Third = Second;
                    Second = show[i];
                }
                if (show[i] < First && show[i] < Second && show[i] > Third)
                {
                    Third = show[i];
                }
            }
            string firstPlace = "First: ", secondPlace = "Second: ", thirdPlace = "Third: ";
            for (int i = 1; i < show.Length; i++)
            {
                if (show[i] == First)
                {
                    firstPlace += $"{show[i]} ";
                }
                if (show[i] == Second)
                {
                    secondPlace += $"{show[i]} ";
                }
                if (show[i] == Third)
                {
                    thirdPlace += $"{show[i]} ";
                }
            }
            Console.WriteLine($"{firstPlace},{secondPlace},{thirdPlace}");
        }
    }
}
