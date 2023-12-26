using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int SubmitOutTwo = 0; // הגיש שתים
            int SubmitOutOne = 0; // הגיש אחד
            int SubmitOutZero = 0; // הגיש אפס
            for (int i = 1; i <= 20; i++)
            {
                int Grade1, Grade2;
                Console.Write("Enter the grade of the first assignment(-1 --> Didn't submit the assignment): ");
                Grade1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the grade of the second assignment(-1 --> Didn't submit the assignment): ");
                Grade2 = int.Parse(Console.ReadLine());
                if (Grade1 != -1 && Grade2 != -1)
                {
                    SubmitOutTwo++;
                }
                else if ((Grade1 != -1 && Grade2 == -1) || (Grade1 == -1 && Grade2 != -1))
                {
                    SubmitOutOne++;
                }
                else if (Grade1 == -1 && Grade2 == -1)
                {
                    SubmitOutZero++;
                }
                
            }
            Console.WriteLine($"The amount of students that submited both of the assignments is {SubmitOutTwo}");
            Console.WriteLine($"The amount of students that submited one assignment is {SubmitOutOne}");
            Console.WriteLine($"The amount of students that didn't submit any assignments is {SubmitOutZero}");
        }
    }
}
