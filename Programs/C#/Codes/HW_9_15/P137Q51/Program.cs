using System;

namespace P137Q51
{
    class Program
    {
        static void Main(string[] args)
        {
            int NotebooksSum = 0;
            int PricePerNotebook,Price;
            Console.WriteLine("Enter the price of a notebook");
            PricePerNotebook = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int NoteBooks;
                Console.WriteLine($"Enter the amount of notebooks student {i} bought");
                NoteBooks = int.Parse(Console.ReadLine());
                NotebooksSum += NoteBooks;
            }
            Price = NotebooksSum * PricePerNotebook;
            Console.WriteLine($"The amount of notebooks bought is {NotebooksSum}");
            Console.WriteLine($"The sum price of all the is {Price} ");
        }
    }
}
