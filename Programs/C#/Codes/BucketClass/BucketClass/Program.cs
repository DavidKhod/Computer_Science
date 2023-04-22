using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket b1 = new Bucket(40);
            b1.Fill(35);
            Bucket b2 = new Bucket(100);
            b2.Fill(90);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            b1.PourInTo(b2);
            Console.WriteLine("");
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
        }
    }
}
