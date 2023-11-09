using System;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;//1
                      //1     10      10
            for (int i = 1; i <= 10; i++)
                x = x * i;//10
            Console.Write(x);//1
            //33,קבוע

            int x = 1;//1
                      //1       n     n
            for (int i = 1; i <= n; i++)
                x = x * i;//n
            Console.Write(x);//1
            //3n+3,לינארי

            int x = 1;//1
                      //1       n     n
            for (int i = n; i >= 1; i--)
            {
                x = x + i;//n
                Console.Write(x);//n
            }
            Console.Write(x);//1
            //4n+3,לינארי

            int x = 1;//1
                      //1          n/2    n/2
            for (int i = 1; i <= n / 2; i++)
                x = x * i;//n/2
            Console.Write(x);//1
            //1.5n + 3,לינארי

            int x = 1;//1
                      //1      n/2      n/2
            for (int i = 1; i <= n; i = i + 2)
                x = x * i;//n/2
            Console.Write(x);//1
            //1.5n + 3,לינארי

            int x = 1;//1
            int m = n;//1
                      //1    n/2      n/2
            for (int i = 1; i <= m; i++) //Example (m = 10) -> i-m -> 1-10,2-9,3-8,4-7,5-6,6-5|stops here,4-7,3-8,2-9,1-10
            {
                x = x + i;//n/2
                m = m – 1;//n/2
            }
            Console.Write(x);//1
            Console.Write(m);//1
            //2n + 5,לינארי

            int i = 1;//1
                      //n/2
            while (i <= n)//Example (n=10) -> i-n -> 1-10,2-10,4-10,8-10,16-10
            {
                Console.Write(i);//n/2
                i = i * 2;//n/2
            }
            //1.5n+1,לינארי

            int i = n;//1
                      //logn
            while (i >= 1)//Example(i = 10) -> 10,5,2,1,0
            {
                if (i % 2 == 0)//logn/2
                    Console.Write(i);//logn/2
                else
                {
                    Console.Write("**");//logn/2
                    Console.Write(i);//logn/2
                }
                i = i / 2;//logn
            }
            //4logn + 1,לינארי

            int i = 1;//1
            int sum1;//1
            int sum2 = 0;//1
                         //n
            while (i <= n)
            {
                sum1 = 0;//n
                         //n      n^2    n^2
                for (int k = 1; k <= n; k++)
                    sum1 = sum1 + k;//n^2
                Console.WriteLine(sum1);//n
                sum2 = sum2 + sum1;//n
                i = i + 1;//n
            }
            Console.WriteLine(sum2);//1
            //3n^2 + 6n + 4,ריבועי

            int x = 1;//1
                      //1     n       n
            for (int i = 1; i <= n; i++)
            {           //n        100n
                for (int j = 1; j <= 100; j++)
                    x = x * j;//100n
                Console.Write(x);//n
            }
            //204n + 2,לינארי

            int x = 1;//1
                      //1      n      n
            for (int i = 1; i <= n; i++)
            {//            n    n^2+n    n^2+n
                for (int j = 1; j <= i; j++)
                    x = x * j; //n^2+n 
                Console.Write(x);//n
            }
            //3n^2 + 4n + 2
            int x = 1;//1
                      //1     n      n
            for (int i = 1; i <= n; i++)
            {
                m = n;//n
                      //n          n*logn   n*logn
                for (int j = 1; j <= m; j++)//Example for n = 10 -> i-m -> 1-10,2-5,3-2|Stop Here
                {
                    x = x * i;//n*logn
                    m = m / 2;//n*logn
                }
                Console.Write(x);//n
            }
            //4n*logn + 4n + 2
        }
    }
}
