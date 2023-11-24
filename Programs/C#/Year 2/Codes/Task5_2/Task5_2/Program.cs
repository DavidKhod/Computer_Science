using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
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

        static int Sum(IntNode list)
        {
            int sum = 0;
            while (list != null)
            {
                sum += list.GetValue();
                list = list.GetNext();
            }
            return sum;
        }

        static bool Exist(IntNode list,int num)
        {
            while (list != null)
            {
                if (num == list.GetValue())
                    return true;
                list = list.GetNext();
            }
            return false;
        }

        static int MaxNum(IntNode list)
        {
            int max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }

        static Random rnd = new Random();
        static IntNode CreateRandomNodehain(int length,int from,int until)
        {
            IntNode list = new IntNode(rnd.Next(from, until + 1));
            IntNode rtnlist = list;
            int cnt = 1;
            while (cnt <= length)
            {
                list.SetNext(new IntNode(rnd.Next(from, until + 1)));
                list = list.GetNext();
                cnt++;
            }
            return rtnlist;
        }

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
        static void Main(string[] args)
        {
            IntNode list = CreateRandomNodehain(10, 1, 10);
            Console.WriteLine(list.ToString());
            Console.WriteLine($"List Length: {GetLength(list)}");
            Console.WriteLine($"Sum Of All: {Sum(list)}");
            int rand = rnd.Next(1, 11);
            bool exist = Exist(list, rand);
            if(exist)
                Console.WriteLine($"{rand} exits in the list");
            else
                Console.WriteLine($"{rand} doesn't exist in the list");
            Console.WriteLine($"The biggest num in list is: {MaxNum(list)}");
            bool isRais = IsRaisingOrder(list);
            if(isRais)
                Console.WriteLine($"List is in raising order");
            else
                Console.WriteLine($"List is not i raising order");
        }
    }
}
