using System;
namespace Basic_Node1
{
    class Program
    {
        static bool IsRaisingOrder(IntNode list)
        {
            while (list.HasNext())
            {
                if (list.GetValue() > list.GetNext().GetValue())
                {
                    Console.WriteLine($"The List is not in raising order");
                    return false;
                }
                else
                {
                    list = list.GetNext();
                }
            }
            return true;
        }

        static int GetLength(IntNode list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();//Points the pointer onto the next pointer
            }
            return count;
        }
        static void Main(string[] args)
        {
            IntNode list = new IntNode(3, new IntNode(7, new IntNode(-4, new IntNode(1, new IntNode(8)))));
            Console.WriteLine($"List -> {list}");
            int count = 0;
            IntNode temp = list;//Temporate pointer onto the first node in the node list
            while (temp != null)
            {
                count++;
                temp = temp.GetNext();//Points the pointer onto the next pointer
            }
            Console.WriteLine(count);

            //Check if the list is in raising order
            IntNode list2 = new IntNode(1, new IntNode(2, new IntNode(3, new IntNode(4, new IntNode(5, new IntNode(6))))));
            Console.WriteLine($"List Length -> {GetLength(list)}");
            Console.WriteLine($"List2 Length -> {GetLength(list2)}");
            bool Rais = IsRaisingOrder(list);
            if (Rais)
                Console.WriteLine("Raising Order");
            else
                Console.WriteLine($"Not raising order");
            Rais = IsRaisingOrder(list2);
            if (Rais)
                Console.WriteLine("Raising Order");
            else
                Console.WriteLine($"Not raising order");

        }
    }
}
