using System;

namespace Exam17_12_2023
{
    class Program
    {
        static Node<int> BuildPairsPalindrom(Node<int> list)
        {
            while (list != null && !ispair(list, list.Value))
            {
                list = list.Next;
            }
            if (list == null)
                return null;
            Node<int> pairs = new Node<int>(list.Value);
            pairs.Next = new Node<int>(list.Value / 10 + (list.Value % 10) * 10);
            Node<int> midOfPairs = pairs;
            while (list != null)
            {
                if (!Exist(pairs, list.Value) && ispair(list, list.Value))
                {
                    int opNum = list.Value / 10 + (list.Value % 10) * 10;
                    midOfPairs.Next = new Node<int>(opNum, new Node<int>(list.Value, midOfPairs.Next));
                    midOfPairs = midOfPairs.Next;
                }
                list = list.Next;
            }
            return pairs;
        }

        static bool Exist(Node<int> list, int num)
        {
            while (list != null)
            {
                if (num == list.Value)
                    return true;
                list = list.Next;
            }
            return false;
        }

        static bool ispair(Node<int> list, int num)
        {
            int opNum = num / 10 + (num % 10) * 10;
            while (list != null)
            {
                if (list.Value == opNum)
                    return true;
                list = list.Next;
            }
            return false;
        }

        static Node<int> BuildList(int n)
        {
            Console.Write($"Enter an integer: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            Node<int> tempList = list;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Enter an integer: ");
                list.Next = new Node<int>(int.Parse(Console.ReadLine()));
                list = list.Next;
            }
            return tempList;
        }
        static void Main(string[] args)
        {
            Node<int> list = BuildList(5);
            Console.WriteLine(BuildPairsPalindrom(list).ToString());
        }
    }
}
