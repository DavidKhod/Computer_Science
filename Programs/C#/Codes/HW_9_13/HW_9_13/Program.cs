using ObjFirstMbt1;
using System;
namespace HW_9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ExpensiveBook, ShortestBook;
            string Name, Writer;
            int Pages;
            double Price;
            Console.Write("Enter the name of the book: ");
            Name = Console.ReadLine();
            Console.Write("Enter the Writer of the book: ");
            Writer = Console.ReadLine();
            Console.Write("Enter the page amount in this book: ");
            Pages = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of the book: ");
            Price = double.Parse(Console.ReadLine());
            Console.WriteLine("                ");
            Book PlaceHolderBook = new Book(Name, Writer, Pages, Price);
            ExpensiveBook = PlaceHolderBook;
            ShortestBook = PlaceHolderBook;
            for (int i = 2; i <= 10; i++)
            {
                Console.Write("Enter the name of the book: ");
                Name = Console.ReadLine();
                Console.Write("Enter the Writer of the book: ");
                Writer = Console.ReadLine();
                Console.Write("Enter the page amount in this book: ");
                Pages = int.Parse(Console.ReadLine());
                Console.Write("Enter the price of the book: ");
                Price = double.Parse(Console.ReadLine());
                Book PlaceHolderBook1 = new Book(Name, Writer, Pages, Price);
                if (PlaceHolderBook1.GetPrice() > ExpensiveBook.GetPrice())
                {
                    ExpensiveBook = PlaceHolderBook1;
                }
                if (PlaceHolderBook1.GetPages() < ShortestBook.GetPages())
                {
                    ShortestBook = PlaceHolderBook1;
                }
                Console.WriteLine("                       ");
            }
            Console.WriteLine($"The most expensive book is {ExpensiveBook}");
            Console.WriteLine("          ");
            Console.WriteLine($"The shortest book is {ShortestBook}");
        }
    }
}
