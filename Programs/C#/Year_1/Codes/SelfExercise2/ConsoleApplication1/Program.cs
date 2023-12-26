using System;

namespace Q1
{
    class program
    {

        /*
         *  כתוב תוכנית הקולטת שני ציונים של רועי במחשבים,
         *  מחשבת ומציגה כפלט את ממוצע הציונים 
         */
        static void Main(string[] args)
        {
            int FirstGrade, SecondGrade;
            double Avg;
            Console.WriteLine("Enter the first grade of roi");
            FirstGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second grade");
            SecondGrade = int.Parse(Console.ReadLine());
            Avg = (double)(FirstGrade + SecondGrade) / 2;
            Console.WriteLine("The average is "+Avg);


        }
    }
}
