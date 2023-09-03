using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace BookQuestion_20_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String NameBook, Author,NameBook2,Author2;
            int PagesAmount,PagesAmount2;
            double price,price2;
            Console.Write("Enter the book's name ");
            NameBook = Console.ReadLine();
            Console.Write("Enter the author's name ");
            Author = Console.ReadLine();
            Console.Write("Enter the amount of pages in the book ");
            PagesAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of the book ");
            price = double.Parse(Console.ReadLine());
            Book Book1 = new Book(NameBook,Author,PagesAmount,price);

            Console.Write("Enter the second book's name ");
            NameBook2 = Console.ReadLine();
            Console.Write("Enter the second book author's name ");
            Author2 = Console.ReadLine();
            Console.Write("Enter the amount of pages in the second book ");
            PagesAmount2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of the second book ");
            price2 = double.Parse(Console.ReadLine());
            Book Book2 = new Book(NameBook2, Author2, PagesAmount2, price2);
            Book1.ChangePrice(Book1.GetPrice()*0.9);
            Book1.ChangePrice(Book1.GetPrice()+5);
            Console.WriteLine(Book1);
            Console.WriteLine(Book2);
            Console.WriteLine((Book1.GetPrice()+Book2.GetPrice())/2);

        }
    }
}
