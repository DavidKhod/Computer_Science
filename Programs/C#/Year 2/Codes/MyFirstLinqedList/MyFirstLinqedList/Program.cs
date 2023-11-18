using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLinqedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNode node1 = new IntNode(8);//Creating an isolated node
            IntNode node2 = new IntNode(2,null);//Creating an isolated node in another way

            Console.WriteLine(node1.ToString());
            Console.WriteLine(node2.ToString());
            //now we change the node1 so that it would point at node2
            node1.SetNext(node2);
            Console.WriteLine(node1.ToString());

            IntNode node3 = new IntNode(5, node1);
            Console.WriteLine(node3.ToString());

            //Prints the value of the first node
            Console.WriteLine(node3.GetValue());
            //Print the value of the second node without knwoing the to what it points to
            Console.WriteLine(node3.GetNext().GetValue());
            //Print the value of the third node without knwoing the to what it points to
            Console.WriteLine(node3.GetNext().GetNext().GetValue());

        }
    }
}
