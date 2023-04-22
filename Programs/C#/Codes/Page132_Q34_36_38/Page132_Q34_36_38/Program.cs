using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page132_Q34_36_38
{
    class Program
    {
        static void Main(string[] args)//חישוב עצרת של מספר הקלט
        {
            int n,result=1;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result = result * i;

            }
            Console.WriteLine(result);
        }
    }
}
