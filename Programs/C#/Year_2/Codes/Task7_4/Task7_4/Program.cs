namespace Task7_4
{
    using System;
    class Program
    {

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
        //Q1
        public static int GetLast(Queue<int> q)
        {
            Queue<int> que = Duplicate(q);
            int num = que.Remove();
            while (!que.IsEmpty())
                num = que.Remove();
            return num;
        }

        static int RemoveItemAt(Queue<int> q, int index)
        {
            Queue<int> removed = new Queue<int>();
            int cnt = 0;
            int rtn = -1;
            while (!q.IsEmpty())
            {
                if (index != cnt)
                    removed.Insert(q.Head());
                else
                    rtn = q.Head();
                q.Remove();
                cnt++;
            }
            while (!removed.IsEmpty())
                q.Insert(removed.Remove());
            return rtn;
        }

        static void DeleteDuplicates(Queue<int> q)
        {
            Queue<int> noDups = new Queue<int>();//No duplicates
            while (!q.IsEmpty())
            {
                noDups.Insert(q.Head());
                RemoveNum(q, q.Remove());
            }
            while (!noDups.IsEmpty())
                q.Insert(noDups.Remove());
        }





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
        static void Main(string[] args)
        {
            Queue<int> que = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                que.Insert(rnd.Next(100));
            }
            Console.WriteLine(que);
            Console.WriteLine($"{GetLast(que)}");
            Console.WriteLine(que);
        }
    }
}
