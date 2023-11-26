using System;

namespace Task5_3
{
    class Program
    {
        static Random rnd = new Random();
        static IntNode CreateRandomIntNode(int length, int from, int until)
        {
            IntNode list = new IntNode(rnd.Next(from, until + 1));
            IntNode rtnlist = list;
            int cnt = 1;
            while (cnt < length)
            {
                list.SetNext(new IntNode(rnd.Next(from, until + 1)));
                list = list.GetNext();
                cnt++;
            }
            return rtnlist;
        }
        static void PrintListFromTo(IntNode list, int i, int j)//Q7P90
        {
            int until = Math.Max(i, j);
            int from = Math.Min(i, j);
            int cnt = 0;
            while (cnt <= until)
            {
                if (cnt >= from && cnt < until)
                    Console.Write($"{list.GetValue()} ");
                list = list.GetNext();
                cnt++;
            }
            Console.WriteLine();
        }

        static bool IsInList(IntNode list, int num)//Q2
        {
            while (list != null)
            {
                if (num == list.GetValue())
                    return true;
                list = list.GetNext();
            }
            return false;
        }

        static double Average(IntNode list)//Q3
        {
            int cnt = 1;
            double sum = 0;
            while (list != null)
            {
                cnt++;
                sum += list.GetValue();
                list = list.GetNext();
            }
            return sum / cnt;
        }

        static char PrintEvenOrOddBigger(IntNode list)//Q4P90
        {
            int odd = 0;
            int even = 0;
            while (list != null)
            {
                if (list.GetValue() % 2 != 0)
                    odd++;
                else
                    even++;
                list = list.GetNext();
            }
            if (odd == even)
                return 's';
            else if (odd > even)
                return 'e';
            else
                return 'z';
        }

        static bool IsRaisingOrder(IntNode list)//Q3P89
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

        static void PrintNumBiggerThenNext(IntNode list)//Q5P90
        {
            while (list.HasNext())
            {
                if (list.GetValue() > list.GetNext().GetValue())
                {
                    Console.Write($"{list.GetValue()} ");
                }
                list = list.GetNext();
            }
            Console.WriteLine();
        }

        static int SequanceOfNumberAmount(IntNode list, int num)//Q2P89
        {
            int cnt = 0;
            while (list.HasNext())
            {
                if (list.GetValue() == num && list.GetNext().GetValue() != num)
                    cnt++;
                list = list.GetNext();
            }
            return cnt;
        }

        static bool IsBalanced(IntNode list)//Q6P90
        {
            int avg = (int)Average(list);
            int overAvg = 0;
            int underAvg = 0;
            while (list.HasNext())
            {
                if (list.GetValue() > avg)
                    overAvg++;
                else if (list.GetValue() < avg)
                    underAvg++;
                list = list.GetNext();
            }
            if (overAvg == underAvg)
                return true;
            return false;
        }

        static IntNode GetLast(IntNode list)//Q9
        {
            while (list.HasNext())
            {
                list = list.GetNext();
            }
            return list;
        }

        static IntNode GetPrev(IntNode list, IntNode node)//Q10
        {
            while (list.HasNext())
            {
                if (list.GetNext() == node)
                    return list;
                list = list.GetNext();
            }
            return null;
        }

        static IntNode GetPos(IntNode list, int num)//Q11
        {
            while (list.HasNext())
            {
                if (list.GetValue() == num)
                    return list;
                list = list.GetNext();
            }
            return null;
        }
        static void Main(string[] args)
        {
            const int FROM = 1;
            const int UNTIl = 10;
            IntNode list = CreateRandomIntNode(10, FROM, UNTIl);
            Console.WriteLine(list.ToString());
            Console.WriteLine($"PrintListFromTo: ");
            PrintListFromTo(list, 4, 8);
            PrintListFromTo(list, 2, 4);

            Console.WriteLine($"IsInList: ");
            int num1 = rnd.Next(FROM, UNTIl + 10);
            int num2 = rnd.Next(FROM, UNTIl + 10);
            bool Exits1 = IsInList(list, num1);
            bool Exits2 = IsInList(list, num2);
            Console.WriteLine($"For {num1} it: {Exits1}");
            Console.WriteLine($"For {num2} it: {Exits2}");

            Console.WriteLine($"Average: {Average(list)}");
            Console.WriteLine($"PrintEvenOrOddBigger: {PrintEvenOrOddBigger(list)}");
            Console.WriteLine($"List is sorted: {IsRaisingOrder(list)}");
            Console.Write($"All numbers that are bigger then the next: ");
            PrintNumBiggerThenNext(list);

            int num = rnd.Next(FROM, UNTIl + 1);
            Console.WriteLine($"The amount of sequances of {num} is: {SequanceOfNumberAmount(list, num)}");
            Console.WriteLine($"The Node is balanced: {IsBalanced(list)}");
            Console.WriteLine($"The last node is: {GetLast(list)}");

            IntNode example = null;
            if (rnd.Next(1, 3) == 1)
                example = list.GetNext().GetNext().GetNext();
            Console.WriteLine($"The previus to {example.ToString()} is: {GetPrev(list, example).ToString()}");

            int pos = rnd.Next(FROM, UNTIl + 1);
            Console.WriteLine($"{pos} is in position: {GetPos(list, pos).ToString()}");
        }
    }
}
