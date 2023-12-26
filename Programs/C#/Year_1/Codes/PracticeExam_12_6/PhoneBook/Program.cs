using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static string PrintArray(string[] arr)
        {
            string print = "";
            for (int i = 0; i < arr.Length; i++)
            {
                print += $"{arr[i]}\n";
            }
            return print;
        }

        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact("David", "054-4126121");
            phoneBook.AddContact("Maxim", "054-5129051");
            phoneBook.AddContact("Ori", "054-126141124");

            Console.WriteLine($"{phoneBook.GetPhone("David")}");
            Console.WriteLine($"{phoneBook.GetPhone("Alex")}");

            Console.WriteLine($"All Contacs:\n{PrintArray(phoneBook.GetAllContactsNames())}");

            Console.WriteLine($"{phoneBook.ToString()}");
        }
    }
}
