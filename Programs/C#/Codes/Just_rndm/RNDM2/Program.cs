using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNDM2
{
    class Program
    {
        public static Double averege(int grade1, int grade2, int grade3)
        {
            return (Double)(grade1 + grade2 + grade3)/3;
        }
        static void Main(string[] args)
        {
            int grade1, grade2, grade3;
            Console.WriteLine("Enter grades");
            grade1 = int.Parse(Console.ReadLine());
            grade2 = int.Parse(Console.ReadLine());
            grade3 = int.Parse(Console.ReadLine());
            Console.WriteLine(averege(grade1, grade2, grade3));
        }
    }
}
