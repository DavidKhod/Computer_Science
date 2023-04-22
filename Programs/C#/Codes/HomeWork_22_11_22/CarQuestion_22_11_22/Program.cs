using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace CarQuestion_22_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string Comp, Model, Id;
            double Price;
            int Owners,PersonMoney;
            Console.WriteLine("Enter the company of the car");
            Comp = Console.ReadLine();
            Console.WriteLine("Enter the model of the car");
            Model = Console.ReadLine();
            Console.WriteLine("Enter the car's license plate");
            Id = Console.ReadLine();
            Console.WriteLine("Enter the price of the car");
            Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of owners the car had");
            Owners = int.Parse(Console.ReadLine());
            Car Car1 = new Car(Comp,Model,Id,Price,Owners);
            Console.WriteLine("Enter the amount of money the person has");
            PersonMoney = int.Parse(Console.ReadLine());
            if (PersonMoney>=Car1.GetPrice())
            {
                Console.WriteLine("He can buy the car");
                Car1.sellCar();
                Console.WriteLine(Car1);
            }
            else
            {
                Console.WriteLine("He cant buy the car");
            }
        }
    }
}
