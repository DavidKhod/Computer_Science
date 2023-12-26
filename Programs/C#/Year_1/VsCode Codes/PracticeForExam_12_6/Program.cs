using System;
namespace PracticeForExam_12_6
{
    class Program
    {
        static void Main(string[]args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact("David","054-4126121");
            phoneBook.AddContact("Maxim","054-5129051");
            phoneBook.AddContact("Ori","054-126141124");

            Console.WriteLine($"{phoneBook.GetPhone("David")}");
            Console.WriteLine($"{phoneBook.GetPhone("Alex")}");

            Console.WriteLine($"All Contacs:\n {phoneBook.GetAllContactsNames()}");

            Console.WriteLine($"{phoneBook.ToString()}");
            
        }
    }
}