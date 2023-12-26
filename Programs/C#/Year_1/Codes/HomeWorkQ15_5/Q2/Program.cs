using ObjFirstMbt1;
using System;
namespace Q2
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)//Question 2
        {
            string Name1, Name2, Name3, Writer1, Writer2, Writer3;
            Console.WriteLine("Enter the name of first the Book");
            Name1 = Console.ReadLine();
            Console.WriteLine("Enter the Writer of the first book");
            Writer1 = Console.ReadLine();
            Console.WriteLine("Enter the name of second the Book");
            Name2 = Console.ReadLine();
            Console.WriteLine("Enter the Writer of the second book");
            Writer2 = Console.ReadLine();
            Console.WriteLine("Enter the name of third the Book");
            Name3 = Console.ReadLine();
            Console.WriteLine("Enter the Writer of the third book");
            Writer3 = Console.ReadLine();
            Book Book1 = new Book(Name1, Writer1, rnd.Next(100, 501), (rnd.Next(4990, 2491) - 100.0));
            Book Book2 = new Book(Name2, Writer2, rnd.Next(100, 501), (rnd.Next(4990, 2491) - 100.0));
            Book Book3 = new Book(Name3, Writer3, rnd.Next(100, 501), (rnd.Next(4990, 2491) - 100.0));
            Console.WriteLine(Book1);
            Console.WriteLine(Book2);
            Console.WriteLine(Book3);
            Console.WriteLine("          ");
            double SumPriceNoSale = Book1.GetPrice() + Book2.GetPrice() + Book3.GetPrice();
            Console.WriteLine("The total price of all the books is " + SumPriceNoSale);
            double SumPriceSale = SumPriceNoSale - (SumPriceNoSale * 0.40);
            Console.WriteLine($"The total price of all the books with the sale is {SumPriceSale}");
            double AvergaeBookPrice = SumPriceSale / 3;
            Console.WriteLine("The average price for a book is " + AvergaeBookPrice);
            if (SumPriceSale % 50 == 0)
            {
                Console.WriteLine("He would have given " + (Math.Round(SumPriceSale / 50)) + " 50 shekels bills with no change");
            }
            else
            {
                double ChangeWithFifties = SumPriceSale - (Math.Round(SumPriceSale) + 50);
                Console.WriteLine("He would have given " + ((Math.Round(SumPriceSale / 50) + 1) + " 50 shekels bills with " + (Math.Abs(ChangeWithFifties * 10) / 10) + " change"));
            }
            double MostExp = Math.Max(Math.Max(Book1.GetPrice(), Book2.GetPrice()), Book3.GetPrice());
            if (MostExp == Book1.GetPrice())
            {
                Console.WriteLine("The most expensive book is " + Book1.GetName());
            }
            else if (MostExp == Book2.GetPrice())
            {
                Console.WriteLine("The most expensive book is " + Book2.GetName());
            }
            else if (MostExp == Book3.GetPrice())
            {
                Console.WriteLine("The most expensive book is " + Book3.GetName());
            }

        }
    }
}
