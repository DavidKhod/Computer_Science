using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSortedCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IntSortedCollection instance
            IntSortedCollection sortedCollection = new IntSortedCollection();

            // Insert elements into the sorted collection
            sortedCollection.Insert(3);
            sortedCollection.Insert(1);
            sortedCollection.Insert(2);
            sortedCollection.Insert(5);
            sortedCollection.Insert(4);

            // Display the sorted collection
            Console.WriteLine("Sorted Collection: " + sortedCollection.ToString());

            // Test Exist method
            Console.WriteLine("Does 2 exist in the collection? " + sortedCollection.Exist(2));
            Console.WriteLine("Does 6 exist in the collection? " + sortedCollection.Exist(6));

            // Test Delete method
            sortedCollection.Delete(3);
            Console.WriteLine("Sorted Collection after deleting 3: " + sortedCollection.ToString());

            // Test GetAll method
            int[] allElements = sortedCollection.GetAll();
            Console.WriteLine("All elements in the collection: " + string.Join(", ", allElements));
        }
    }
}
