using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        //סעיף ב':כדי לקבל 1 - 10 11,כדי לקבל 0 - 20 231

        //סעיף ג': Exit Claim: the function returns 1 if the numbers are in the same length and 0 if not

        //סעיף ה': Equals1 יהילה יותר כי היא בודקת את שניהם כך שאם כבר אחד שונה מאפס והשני לא זה כבר אומר שהאורך שלהם שונה

        //Entry Claim: the function gets two positive full numbers
        //Exit Claim: the function returns 1 if the numbers are in the same length and 0 if not
        static int Equal2 (int n1,int n2)
        {
            int Count1 = 0, Count2 = 0;
            while (n1 != 0)
            {
                Count1++;
                n1 /= 10;
            }
            while (n2 != 0)
            {
                Count2++;
                n1 /= 10;
            }
            if (Count1 == Count2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter a pair of number");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (Equal2(n1,n2) == 1)
            {
                Console.WriteLine("Their length is the same");
            }
            else
            {
                Console.WriteLine("Their length isn't the same");
            }
        }
    }
}
