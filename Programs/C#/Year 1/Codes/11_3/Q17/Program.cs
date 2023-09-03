using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
    class Program
    {
        static void Main(string[] args)
        {
            const int UNTILHOUR = 24;
            int Second = 0, Minutes = 0, Hours = 0;
            while (Hours != UNTILHOUR)
            {
                Console.WriteLine($"{Hours}:{Minutes}:{Second}");
                Second++;
                if (Second == 60)
                {
                    Minutes++;
                    Second = 0;
                }
                if (Minutes == 60)
                {
                    Hours++;
                    Minutes = 0;
                }
            }
        }
    }
}
