using ObjFirstMbt1;
using System;
namespace HomeWorkQ15_5
{
    class Program
    {
        static void Main(string[] args)//Question 1
        {
            string Name, Writer, Name2, Writer2;
            int Pages, AmountPerDay, WholeBookDays1, Pages2, AmountPerDay2, WholeBookDays2;
            double Price, Price2;
            Console.Write("Enter name of the book ");
            Name = Console.ReadLine();
            Console.Write("Enter the writer of the book ");
            Writer = Console.ReadLine();
            Console.Write("Enter the amount of pages the book has ");
            Pages = int.Parse(Console.ReadLine());
            Console.Write("Enter the Price of the book ");
            Price = double.Parse(Console.ReadLine());
            Book Book1 = new Book(Name, Writer, Pages, Price);
            Console.Write("Enter the amount of pages mrs cohen reads per day ");
            AmountPerDay = int.Parse(Console.ReadLine());
            if (Book1.GetPages() % AmountPerDay == 0)
            {
                WholeBookDays1 = Book1.GetPages() / AmountPerDay;
                Console.WriteLine("The amount of days it would take mrs cohen to read the book is " + WholeBookDays1 + " Days");
            }
            else
            {
                WholeBookDays1 = (Book1.GetPages() / AmountPerDay) + 1;
                Console.WriteLine("The amount of days it would take mrs cohen to read the book is " + WholeBookDays1 + " Days");
            }
            Console.Write("Enter name of the book ");
            Name2 = Console.ReadLine();
            Console.Write("Enter the writer of the book ");
            Writer2 = Console.ReadLine();
            Console.Write("Enter the amount of pages the book has ");
            Pages2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Price of the book ");
            Price2 = double.Parse(Console.ReadLine());
            Book Book2 = new Book(Name2, Writer2, Pages2, Price2);
            if (Book1.GetPages() > Book2.GetPages())
            {
                Console.WriteLine("The longest book is " + Book1.GetName() + " it has " + Book1.GetPages() + " pages");
            }
            else if (Book1.GetPages() < Book2.GetPages())
            {
                Console.WriteLine("The longest book is " + Book2.GetName() + " it has " + Book2.GetPages() + " pages");
            }
            else
            {
                Console.WriteLine("The page amount on both of the books is the same ");
            }
            Console.Write("Enter the amount of pages mrs levi reads per day ");
            AmountPerDay2 = int.Parse(Console.ReadLine());
            if (Book2.GetPages() % AmountPerDay2 == 0)
            {
                WholeBookDays2 = Book2.GetPages() / AmountPerDay2;
            }
            else
            {
                WholeBookDays2 = (Book2.GetPages() / AmountPerDay2) + 1;
            }
            Console.WriteLine("It would take Mrs Levi " + (WholeBookDays1 + WholeBookDays2) + " days To finish the both of the books");
            if (Book1.GetPages() + Book2.GetPages() % WholeBookDays2 == 0)
            {
                Console.WriteLine("It would take him " + (Book1.GetPages() + Book2.GetPages() / WholeBookDays2));
            }
            else
            {
            }

        }
    }
}
