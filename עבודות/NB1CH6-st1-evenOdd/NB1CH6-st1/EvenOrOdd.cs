using System;

namespace NB1CH6_st1
{
    class EvenOrOdd
    {


        /**
         * קלט: מספר שלם חיובי
         * פלט: הודעה אם המספר הוא זוגי או אי-זוגי
         */

        static void Main(string[] args)
        {
            /** השלם את הקוד הדרוש */
            int num;
            Console.WriteLine("Enter a whole number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 != 0 )
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }
        }
    }
}
