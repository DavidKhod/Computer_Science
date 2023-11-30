using System;
namespace Task20_0
{
    class Program
    {
        static bool exist(StringNode list, string name)
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

        static string ShortestName(StringNode list)
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

        static bool AscendingOrderByABC(StringNode list)
        {
            while (list.HasNext())
            {
                if (list.GetValue().CompareTo(list.GetNext().GetValue()) > 0)
                    return false;
                list = list.GetNext();
            }
            return true;
        }

        static void AllLetterThatListDontAppear(StringNode list)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                bool contains = false;
                StringNode temp = list;
                while (temp.HasNext() && !contains)//looks through all of the words in the list if the letter exist in them
                {
                    if (temp.GetValue().Contains(i.ToString()))//if the letter exist in the world
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
            StringNode list =
            new StringNode("alice",
            new StringNode("bob",
            new StringNode("charlie",
            new StringNode("david",
            new StringNode("eva",
            new StringNode("frank",
            new StringNode("grace")))))));

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
