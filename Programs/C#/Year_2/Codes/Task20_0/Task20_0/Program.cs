using System;
namespace Task20_0
{
    class Program
    {
        static bool exist(Node<string> list, string name)
        {
            if (list == null)
            {
                return false;
            }
            else
            {
                if (list.GetValue().Equals(name))
                    return true;
                return exist(list.GetNext(), name);
            }
        }

        //Entry: The function inputs a pointer to the first string Node
        //Exis: The function return the shortest name/string in linked list
        static string ShortestName(Node<string> list)
        {
            if (!list.HasNext())
            {
                return list.GetValue();
            }
            else
            {
                int lenghtNow = list.GetValue().Length;
                string nameNext = ShortestName(list.GetNext());
                int lengthNext = nameNext.Length;
                if (lenghtNow > lengthNext)
                    return nameNext;
                return list.GetValue();
            }
        }

        //Entry: The function inputs a pointer to the first node in a string linked list
        //Exit: The function returns True if the string are in an asceing order, False if not
        static bool AscendingOrderByABC(Node<string> list)
        {
            while (list.HasNext())
            {
                if (list.GetValue().CompareTo(list.GetNext().GetValue()) > 0)
                    return false;
                list = list.GetNext();
            }
            return true;
        }

        //Entry: The function inputs a pointer to the first node in a string linked list
        //Exit: The function prints all of the letters that don't appear in any of the string in the linked list
        static void AllLetterThatListDontAppear(Node<string> list)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                bool contains = false;
                Node<string> temp = list;
                while (temp.HasNext() && !contains)
                {
                    if (temp.GetValue().Contains(i.ToString()))
                        contains = true;
                    temp = temp.GetNext();
                }
                if (!contains)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Node<string> list =
            new Node<string>("alice",
            new Node<string>("bob",
            new Node<string>("charlie",
            new Node<string>("david",
            new Node<string>("eva",
            new Node<string>("frank",
            new Node<string>("grace")))))));

            // Check if a name exists in the list
            string nameToFind = "david";
            bool nameExists = exist(list, nameToFind);
            Console.WriteLine($"Does '{nameToFind}' exist in the list? {nameExists}");

            // Find the shortest name in the list
            string shortest = ShortestName(list);
            Console.WriteLine($"Shortest name in the list: {shortest}");

            // Check if the names are in ascending order
            bool isAscending = AscendingOrderByABC(list);
            Console.WriteLine($"Are names in ascending order? {isAscending}");

            // List all letters that don't appear in any name in the list
            Console.Write("Letters that don't appear in any name: ");
            AllLetterThatListDontAppear(list);
        }
    }
}
