using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational NewRat = new Rational(1, 10);
            Console.WriteLine(NewRat.ToString());
            Console.WriteLine($"{NewRat.GetNumerator()}\n");

            Console.WriteLine($"{NewRat.GetDenominator()}\n");

            Rational NewRat2 = new Rational(2, 20);
            Console.WriteLine(NewRat2.ToString());
            Console.WriteLine($"{NewRat.IsEqual(NewRat2)}");

            Console.WriteLine($"{NewRat.Multiply(NewRat2)}");
            Console.WriteLine($"{NewRat.Divide(NewRat2)}\n");

            //חלק ב'
            Console.WriteLine($"{NewRat.ToString()}");
            Console.WriteLine($"{NewRat2.ToString()}");
            Console.WriteLine($"{NewRat.Plus(NewRat2)}\n");

            Console.WriteLine($"{NewRat.Minus(NewRat2)}");
        }
    }
}
