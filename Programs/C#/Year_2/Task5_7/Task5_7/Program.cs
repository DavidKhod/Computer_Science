using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_7
{
    class Program
    {
        //Q1
        static int Length(Node<int> list)
        {
            if (!list.HasNext())
                return 1;
            return Length(list.Next) + 1;
        }

        //Q2
        static int SumOfEven(Node<int> list)
        {
            if(!list.HasNext())
            {
                if (list.Value % 2 == 0)
                    return list.Value;
                return 0;
            }
            else
            {
                if (list.Value % 2 == 0)
                    return SumOfEven(list.Next) + list.Value;
                return SumOfEven(list.Next);
            }
        }

        //Q3
        static int suminRange(Node<int> list,Node<int> p,Node<int> d)
        {
            if (list == d)
                return d.Value;
            else
            {
                if (list == p)
                    return suminRange(list.Next, p.Next, d) + p.Value;
                return suminRange(list.Next, p, d);
            }
        }

        //Q4
        static void PrintEvenIndexs(Node<int> list)
        {
            if(list != null)
            {
                Console.WriteLine(list.Value);
                if (list.Next != null)
                    PrintEvenIndexs(list.Next.Next);
            }
        }

        //Q5
        static bool Exist(Node<int> list,int num)
        {
            if (list == null)
                return false;
            if (list.Value == num)
                return true;
            return Exist(list.Next, num);
        }

        //Q6
        static string ShortestName(Node<string> list)
        {
            if (!list.HasNext())
                return list.Value;
            string str = ShortestName(list.Next);
            if (str.Length < list.Value.Length)
                return str;
            return list.Value;
        }

        //Q7
        static bool InABCOrder(Node<string> list)
        {
            if (list == null)
                return true;
            if (list.Value.CompareTo(list.Next.Value) == 1)
                return false;
            return InABCOrder(list.Next);
        }
        static void Main(string[] args)
        {
        }
    }
}
