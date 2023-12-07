using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfNode
{
    class Program
    {
        static Node<int> BuildReverseList(int n)
        {
            Console.Write($"Enter an integer: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Enter an integer: ");
                list = new Node<int>(int.Parse(Console.ReadLine()),list);
            }
            return list;
        }
        static void Main(string[] args)
        {
            Node<int> list = BuildReverseList(7);
            Console.WriteLine(list.ToString());
        }
    }
}
