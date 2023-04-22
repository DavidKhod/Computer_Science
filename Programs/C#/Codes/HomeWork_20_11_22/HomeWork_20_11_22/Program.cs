using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace HomeWork_20_11_22
{
    class Program
    {
        static void Main(string[] args)//Page 243 Quetion 2
        {
            int Price1,Price2;
            Console.WriteLine("Enter the price of a Bamba bag");
            Price1 = int.Parse(Console.ReadLine());
            Snack Snack1 = new Snack("Bamba","Osem",Price1);
            Console.WriteLine("Enter the price of a Bissli bag");
            Price2 = int.Parse(Console.ReadLine());
            Snack Snack2 = new Snack("Bisli", "Osem", Price2);
            Snack1.SetPrice(Snack1.GetPrice()+(Snack1.GetPrice()*0.15));
            Snack2.SetPrice(Snack2.GetPrice()-(Snack2.GetPrice()*0.05));
            Console.WriteLine(Snack1);
            Console.WriteLine(Snack2);
        }
    }
}
