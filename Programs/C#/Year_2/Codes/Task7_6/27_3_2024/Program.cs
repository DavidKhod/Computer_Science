namespace _27_3_2024
{
    internal class Program
    {
        //Q1
        //Entry: The function inputs a generic queue.
        //Exit: The function returns a copy of the queue.
        static Queue<T> Duplicate<T>(Queue<T> current)
        {
            Queue<T> copy = new Queue<T>();
            Queue<T> temp = new Queue<T>();
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

        //Entry: The function inputs a queue and an integer.
        /*Exit: The function returns True if there are two numbers in the queue
                that their sum is equal to the integer inputed, False if not.
        */
        static bool TwoSum(Queue<int> que, int x)
        {
            int temp;
            while (!que.IsEmpty())
            {
                temp = que.Remove();
                Queue<int> tmpQ = Duplicate<int>(que);
                while (tmpQ.IsEmpty())
                {
                    if (tmpQ.Remove() + temp == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Q2
        public class TwoQueue
        {
            private Queue<int> numbers;
            private Queue<int> sums;

            public TwoQueue()
            {
                numbers = new Queue<int>();
                sums = new Queue<int>();
            }

            public void Insert(int x)
            {
                if (sums.IsEmpty() && numbers.IsEmpty())
                {
                    sums.Insert(x);
                    numbers.Insert(x);
                }
                else
                {
                    Queue<int> copyOfSums = Duplicate<int>(sums);
                    int lastNumOfSums = copyOfSums.Remove();
                    while (!copyOfSums.IsEmpty())
                        lastNumOfSums = copyOfSums.Remove();
                    sums.Insert(lastNumOfSums + x);
                    numbers.Insert(x);
                }
            }

            private Queue<T> Duplicate<T>(Queue<T> current)
            {
                Queue<T> copy = new Queue<T>();
                Queue<T> temp = new Queue<T>();
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

            public Queue<int> GetNums(int x)
            {
                Queue<int> temp = Duplicate<int>(numbers);
                Queue<int> newQueue = new Queue<int>();
                int sum = 0;
                while (sum != x)
                {
                    sum += temp.Head();
                    newQueue.Insert(temp.Remove());
                }
                return newQueue;
            }

            public void EraseNum(int x)
            {
                Queue<int> newSums = new Queue<int>();
                Queue<int> newNums = new Queue<int>();
                int sum = 0;
                while (!numbers.IsEmpty())
                {
                    if (numbers.Head() == x)
                        numbers.Remove();
                    if (!numbers.IsEmpty())
                    {
                        sum += numbers.Head();
                        newNums.Insert(numbers.Head());
                        newSums.Insert(sum);
                    }
                }
                this.numbers = newNums;
                this.sums = newSums;
            }
        }
        public class TwoStack
        {

        }

        static void Main(string[] args)
        {

        }
    }
}
