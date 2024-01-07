using System;

namespace Task5_7A
{
    class Program
    {
        static int GetLength(Node<int> list)
        {
            if (!list.HasNext())
                return 1;
            return GetLength(list.Next) + 1;
        }

        static int SumOfList(Node<int> list)
        {
            if (list == null)
                return 0;
            return SumOfList(list.Next) + list.Value;
        }

        static bool FindNum(Node<int> list, int num)
        {
            if (!list.HasNext())
            {
                if (list.Value == num)
                    return true;
                return false;
            }
            if (list.Value == num)
                return true;
            return FindNum(list.Next, num);
        }

        static void PrintEven(Node<int> list)
        {
            if (!list.HasNext())
            {
                if (list.Value % 2 == 0)
                    Console.Write($" {list.Value}");
            }
            else if (list.Value % 2 ==  0)
            {
                Console.Write($" {list.Value}");
                PrintEven(list.Next);
            }
            else
                PrintEven(list.Next);
        }

        static bool AreAllPositive(Node<int> list)
        {
            if(!list.HasNext())
            {
                if (list.Value < 0)
                    return false;
                return true;
            }
            if (list.Value < 0)
                return false;
            return AreAllPositive(list.Next);
        }

        static int MaxNum(Node<int> list)
        {
            if (!list.HasNext())
                return list.Value;
            return Math.Max(MaxNum(list.Next), list.Value);
        }

        static bool IsRaisingOrder(Node<int> list)
        {
            if(!list.HasNext())
                return true;
            if (list.Value >= list.Next.Value)
                return false;
            return IsRaisingOrder(list.Next);
        }

        static void Main(string[] args)
        {
        }
    }
}
