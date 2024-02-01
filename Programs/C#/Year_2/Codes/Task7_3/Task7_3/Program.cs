using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
namespace Task7_3
{
    class Program
    {
        //Q1
        //O(n) when n is the length of the queue inputed
        static Queue<int> Duplicate(Queue<int> current)
        {
            Queue<int> copy = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while (!current.IsEmpty())
            {
                temp.Insert(current.Remove());
            }
            while (!temp.IsEmpty())
            {
                current.Insert(temp.Head());
                copy.Insert(temp.Remove());
            }
            return copy;
        }

        //Q2
        //O(n) when n is the length of queue inputed
        static int TimesAppears(Queue<int> que,int num)
        {
            Queue<int> copy = Duplicate(que);
            int cnt = 0;
            while (!copy.IsEmpty())
            {
                if (copy.Head() == num)
                    cnt++;
                copy.Remove();
            }
            return cnt; 
        }

        //Q3
        //O(n) when n is the length of the queue inputed
        static int LongestStreak(Queue<int> que)
        {
            Queue<int> copy = Duplicate(que);
            int streak = 0;
            int longestStreak = 0;
            int prev = copy.Remove();
            while (!copy.IsEmpty())
            {
                if (prev < copy.Head())
                    streak++;
                else
                {
                    if (streak > longestStreak)
                        longestStreak = streak;
                    streak = 0;
                }
                prev = copy.Remove();
            }
            return longestStreak;
        }

        //Q4
        //O(n) when n is the length of the queue inputed
        static int MaxNumAndDelete(Queue<int> que)
        {
            int max = MaxValue(Duplicate(que));//O(n)
            RemoveNum(que, max);//O(n)
            return max;
        }

        //O(n) when n is the length of the queue inputed
        static int MaxValue(Queue<int> que)
        {
            Queue<int> copy = Duplicate(que);
            int max = copy.Head();
            copy.Remove();
            while (!copy.IsEmpty())
            {
                if (copy.Head() > max)
                    max = copy.Head();
                copy.Remove();
            }
            return max;
        }

        //O(n) when n is length of the queue inputed
        static void RemoveNum(Queue<int> que, int num)
        {
            Queue<int> newQue = new Queue<int>();
            while (!que.IsEmpty())//O(n)
            {
                if (que.Head() != num)
                    newQue.Insert(que.Head());
                que.Remove();
            }
            while (!newQue.IsEmpty())//O(n)
                que.Insert(newQue.Remove());
        }

        //Q5
        //O(n) when n is the length of the queue inputed
        static void SortLoweringOrder(Queue<int> que)
        {
            Queue<int> sorted = new Queue<int>();
            while (!que.IsEmpty())//O(n)(Inovice series)
                sorted.Insert(MaxNumAndDelete(que));//O(n)
            while (!sorted.IsEmpty())//O(n)
                que.Insert(sorted.Remove());
        }

        //Q6
        //O(n^2) when n is the length of the matching queue
        static bool Matching(Queue<int> que1,Queue<int> que2)
        {
            Queue<int> copy1 = Duplicate(que1);
            Queue<int> copy2 = Duplicate(que2);
            int length_Of_Copy1 = 0;
            while (!copy1.IsEmpty())
            {
                if (!Exist(copy2, copy1.Remove()))
                    return false;
                length_Of_Copy1++;
            }
            if (length_Of_Copy1 != Length(copy2))
                return false;
            return true;
        }

        //O(n) when n is the length of the queue inputed
        static bool Exist(Queue<int> que, int num)
        {
            Queue<int> copy = Duplicate(que);
            while (!copy.IsEmpty())
                if (copy.Remove() == num)
                    return true;
            return false;
        }

        //O(n) when n is the length of the queue inputed
        static int Length(Queue<int> que)
        {
            int cnt = 0;
            Queue<int> copy = Duplicate(que);
            while (!copy.IsEmpty())
            {
                cnt++;
                copy.Remove();
            }
            return cnt;
        }

        static Random rnd = new Random();
        static Queue<int> CreateRandomQueue(int n,int from,int to)
        {
            to++;
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                que.Insert(rnd.Next(from, to));
            }
            return que;
        }
        static void Main(string[] args)
        {
            Queue<int> que = CreateRandomQueue(5, 1, 20);
            Console.WriteLine($"Queue: {que}");
            Console.WriteLine($"Times 5 appears in Que: {TimesAppears(que,5)}");
            Console.WriteLine($"Longest Streak: {LongestStreak(que)}");
            Console.WriteLine($"The biggest num in que is: {MaxNumAndDelete(que)}");
            Console.WriteLine($"And deleting that num from queue: {que}");
            SortLoweringOrder(que);  Console.WriteLine($"Sorting que in lowering order: {que}");
            Queue<int> que2 = CreateRandomQueue(5, 1, 20);
            Console.WriteLine($"Queue1: {que}");
            Console.WriteLine($"Queue2: {que2}");
            Console.WriteLine($"Is Queue1 and Queue2 have the same numbers? {Matching(que,que2)}");
        }
    }
}
