using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;
namespace My_first_bucket
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Bucket Bucket1 = new Bucket(rnd.Next(1,101), "Udi's");
            Bucket1.Fill(rnd.Next(1, 101));
            Console.WriteLine(Bucket1.GetCapacity() - Bucket1.GetCurrentAmount());
            if (Bucket1.IsEmpty())
            {
                Console.WriteLine("The bucket is empty");
            }
            else
            {
                Console.WriteLine("The bucket is not empty");
                Bucket1.Empty();
            }
        }
    }
}
