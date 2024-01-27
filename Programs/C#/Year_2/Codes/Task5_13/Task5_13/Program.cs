using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IntSet instances
            IntSet set1 = new IntSet();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            IntSet set2 = new IntSet();
            set2.Add(2);
            set2.Add(3);
            set2.Add(4);

            // Display original sets
            Console.WriteLine("Set 1: " + set1.ToString());
            Console.WriteLine("Set 2: " + set2.ToString());

            // Test Unify method
            IntSet unifiedSet = set1.Unify(set2);
            Console.WriteLine("Unified Set: " + unifiedSet);

            // Test Intersect method
            IntSet intersectedSet = set1.Intersect(set2);
            Console.WriteLine("Intersected Set: " + intersectedSet);

            // Test Delete method
            set1.Delete(2);
            Console.WriteLine("Set 1 after deleting 2: " + set1);
        }
    }
}
