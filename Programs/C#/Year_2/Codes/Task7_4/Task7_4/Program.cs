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

        static Queue<Carrier> Duplicate(Queue<Carrier> current)
        {
            Queue<Carrier> copy = new Queue<Carrier>();
            Queue<Carrier> temp = new Queue<Carrier>();
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

        static Queue<Time> Duplicate(Queue<Time> current)
        {
            Queue<Time> copy = new Queue<Time>();
            Queue<Time> temp = new Queue<Time>();
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

        //Q2
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

        //Q3
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


        //Q4
        static Time DiffOfFirstAndLast(Queue<Time> runners)
        {
            Time first = runners.Head();
            Time last = GetLast(runners);
            return Diff(first, last);
        }

        static void SmallestDiff(Queue<Time> runners)
        {
            Queue<Time> copy = Duplicate(runners);
            int i = 1, iSmallest = 1, smallestDiff = 0;
            Time prev = copy.Remove();
            smallestDiff = Diff(prev, copy.Head()).AllToSec();
            i += 2;
            prev = copy.Remove();
            while (!copy.IsEmpty())
            {
                int tempDiff = Diff(prev, copy.Head()).AllToSec();
                if (tempDiff < smallestDiff)
                {
                    iSmallest = i;
                    smallestDiff = tempDiff;
                }
                prev = copy.Remove();
                i++;
            }
            Console.WriteLine($"The pair with the smallest diff is {iSmallest} and {iSmallest + 1}");
        }

        static Time Diff(Time time1, Time time2)
        {
            int diff = Math.Abs(time1.AllToSec() - time2.AllToSec());
            int hour = diff / 3600;
            int min = diff % 3600 / 60;
            int sec = diff % 3600 % 60;
            return new Time(hour, min, sec);
        }

        public static Time GetLast(Queue<Time> q)
        {
            Queue<Time> que = Duplicate(q);
            Time num = que.Remove();
            while (!que.IsEmpty())
                num = que.Remove();
            return num;
        }


        //Q5
        static void RemoveThatAreWithinTheTimeInputed(Queue<Job> jobs, int time)
        {
            while (!jobs.IsEmpty() && time - jobs.Head().duration > 0)
            {
                time -= jobs.Head().duration;
                Console.WriteLine($"discharged {jobs.Remove().id}");
            }
        }

        //Q6
        static Carrier Carrier_With_Needed_Capacity(Queue<Carrier> que, double needCapacity)
        {
            Queue<Carrier> copy = new Queue<Carrier>();
            while (!que.IsEmpty() && que.Head().capacity < needCapacity)
                copy.Insert(que.Remove());
            Carrier car = que.Remove();
            while (!que.IsEmpty())
            {
                copy.Insert(que.Remove());
            }
            while (!copy.IsEmpty())
            {
                que.Insert(copy.Remove());
            }
            return car;
        }

        //Q7
        static Queue<Client> MergeQueues(Queue<Client> open, Queue<Client> closed)
        {
            Queue<Client> merge = new Queue<Client>();
            while (!open.IsEmpty() && !closed.IsEmpty())
            {
                merge.Insert(open.Remove());
                merge.Insert(closed.Remove());
            }
            while (!open.IsEmpty())
                merge.Insert(open.Remove());
            while (!closed.IsEmpty())
                merge.Insert(closed.Remove());
            return merge;
        }
        static void Main(string[] args)
        {
            TestGetLast();
            TestSmallestDiff();
            TestRemoveElementAt();
            TestRemoveThatAreWithinTheTimeInputed();
            TestGetFirstAvailable();
            TestMergeLines();
        }
        static void TestGetLast()
        {
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            int last = GetLast(queue);
            Console.WriteLine($"Test GetLast: Last element in the queue: {last}");
        }

        static void TestRemoveElementAt()
        {
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            int removedElement = RemoveItemAt(queue, 1);
            Console.WriteLine($"Test RemoveElementAt: Removed element at index 1: {removedElement}");
        }

        static void TestSmallestDiff()
        {
            Queue<Time> timeQueue = new Queue<Time>();
            timeQueue.Insert(new Time(10, 30, 0));
            timeQueue.Insert(new Time(12, 15, 0));
            timeQueue.Insert(new Time(14, 0, 0));
            SmallestDiff(timeQueue);
        }

        static void TestRemoveThatAreWithinTheTimeInputed()
        {
            Queue<Job> jobQueue = new Queue<Job>();
            jobQueue.Insert(new Job("Job1", 5));
            jobQueue.Insert(new Job("Job2", 8));
            jobQueue.Insert(new Job("Job3", 3));
            int availableTime = 10;
            RemoveThatAreWithinTheTimeInputed(jobQueue, availableTime);
        }

        static void TestGetFirstAvailable()
        {
            Queue<Carrier> carrierQueue = new Queue<Carrier>();
            carrierQueue.Insert(new Carrier("Carrier1", 20));
            carrierQueue.Insert(new Carrier("Carrier2", 15));
            carrierQueue.Insert(new Carrier("Carrier3", 25));
            int neededEngineCapacity = 18;
            Carrier firstAvailable = Carrier_With_Needed_Capacity(carrierQueue, neededEngineCapacity);
            Console.WriteLine($"Test GetFirstAvailable: First available carrier: {firstAvailable.id}");
        }

        static void TestMergeLines()
        {
            Queue<Client> queue1 = new Queue<Client>();
            queue1.Insert(new Client("Line1A"));
            queue1.Insert(new Client("Line1B"));

            Queue<Client> queue2 = new Queue<Client>();
            queue2.Insert(new Client("Line2A"));
            queue2.Insert(new Client("Line2B"));

            Queue<Client> merged = MergeQueues(queue1, queue2);
            Console.WriteLine($"Test MergeLines: Merged queue: {merged}");
        }
    }
}
