using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam17_12_2023
{
    class Program
    {
        static Node<int> BuildPairsPalindrom(Node<int> list)
        {
            while (!ispair(list,list.Value) && list != null)
            {
                list = list.Next;
            }
            if (list == null)
                return null;
            Node<int> pairs = new Node<int>(list.Value);
            pairs.Next = new Node<int>(list.Value / 10 + (list.Value % 10) * 10);
            Node<int> midOfPairs = pairs;
            while (list.HasNext())
            {
                if (!Exist(list, list.Value) && ispair(list, list.Value))
                {
                    int opNum = list.Value / 10 + (list.Value % 10) * 10;
                    midOfPairs.Next = new Node<int>(opNum, new Node<int>(list.Value, midOfPairs.Next));
                    list = list.Next;
                    midOfPairs = midOfPairs.Next;
                }
            }
            return pairs;
        }
        static bool Exist(Node<int> list, int num)
        {
            while (list != null)
            {
                if (num == list.Value)
                    return true;
                list = list.Value;
            }
            return false;
        }
        static bool ispair(Node<int> list, int num)
        {
            int opNum = num / 10 + (num % 10) * 10;
            while (list.HasNext())
            {
                if (list.Value == opNum)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
        }
    }
}
