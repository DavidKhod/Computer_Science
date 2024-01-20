using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
namespace Task5_11
{
    class Program
    {
        static Node<int> NumsFrom1ToNumThatDontAppearInList(Node<int> list,int num)
        {
            int temp = 1;
            Node<int> rtnList = new Node<int>(0);
            Node<int> pos = rtnList.Next;
            while (list != null && temp < num)
            {
                if (!Exist(list, temp))
                {
                    pos = new Node<int>(temp);
                    pos = pos.Next;
                }
                temp++;
                list = list.Next;
            }
            return rtnList.Next;
        }
        //If n is the size of the list, the complexity of the operation will be O(n^2) meaning that the basic step is n that happens n times, so that O(n) * n = O(n^2)
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
        static void Main(string[] args)
        {

        }
    }
}
