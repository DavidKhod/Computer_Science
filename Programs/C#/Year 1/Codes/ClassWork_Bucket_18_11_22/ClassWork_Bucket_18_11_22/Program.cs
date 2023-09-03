using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;
namespace ClassWork_Bucket_18_11_22
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Bucket b1 = new Bucket(100, "Units");
            b1.Fill(rnd.Next(50,101));
            Console.WriteLine("Bucket current amount of water is "+b1.GetCurrentAmount());
            Console.WriteLine("The amount of water needed to fill the bucket up is "+(100-b1.GetCurrentAmount()));
            Bucket b2 = new Bucket(rnd.Next(10,101), "Litters");
            Console.WriteLine("Bucket 2 capacity is "+b2.GetCapacity());
            int CurrentAm = (int)b1.GetCurrentAmount();
            b1.PourInto(b2);
            Console.WriteLine("The amount of water left in bucket 1 after the pour is "+(b1.GetCurrentAmount()));
            if (b1.IsEmpty())
            {
                b2.Fill(b2.GetCapacity() - b2.GetCurrentAmount());
            }
            else
            {
                b2.Empty();
            }
            if (b1.IsEmpty() && !(b2.IsEmpty()))
            {
                Console.WriteLine("the bucket is water left is Bucket 2");
            }
            else if (b2.IsEmpty() && !(b1.IsEmpty()))
            {
                Console.WriteLine("The bucket with water left is Bucket 1");
            }
        }
    }
}
