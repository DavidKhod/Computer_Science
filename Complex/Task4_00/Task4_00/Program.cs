using System;
namespace Task4_00
{
    class Program
    {
        static double Avg(int[] arr)//2n + 3
        {
            int sum = 0;//1
                        //1         n           n
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];//n
            }
            return sum / arr.Length;//1
        }

        static void BubbleSort(int[] arr)//6n^2 + 3n + 2
        {
            int tempnum;//1
                        //1         n           n
            for (int i = 0; i < arr.Length; i++)
            {            //n        n^2              n^2
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])//n^2
                    {
                        tempnum = arr[j];//n^2
                        arr[j] = arr[j + 1];//n^2
                        arr[j + 1] = tempnum;//n^2
                    }
                }
            }
        }

        static int NumLength(int num)//n = num length, 3n + 2
        {
            int cnt = 0;//1
            while (num != 0)//n
            {
                cnt++;//n
                num /= 10;//n
            }
            return cnt;//1
        }

        static int SameDigits(int n1, int n2)//n = num length,5n^2 + 11n + 8
        {
            int n1Len = NumLength(n1);//3n+2
            int n2Len = NumLength(n2);//3n+2
            int cnt = 0, temp;//2
                              //1        //n      //n
            for (int i = 0; i < n1Len; i++)
            {
                temp = n2;//n
                          //n       n^2       n^2
                for (int j = 0; j < n2Len; j++)
                {
                    if (n1 % 10 == temp % 10)//n^2
                    {
                        cnt++;//n^2
                    }
                    temp /= 10;//n^2
                }
                n1 /= 10;//n
            }
            return cnt;//1
        }


        static int CountA(string str)//4n+3
        {
            int cnt = 0;//1
                        //1       n         n
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')//n
                    cnt++;//n
            }
            return cnt;//1
        }

        static bool AllTheSame(int[,] mat) //n = mat.x = mat.y,3n^2 + 3n + 3
        {
            int n = mat[0, 0];//1
                              //1        n                n
            for (int i = 0; i < mat.GetLength(0); i++)
            {           //n          n^2               n^2
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] != n)//n^2
                    {
                        return false;//0
                    }
                }
            }
            return true;//1
        }

        static bool AllTheSameDig(int[,] mat)//n = mat.y = mat.x,3n+3
        {
            int n = mat[0, 0];//1
                              //1          //n             //n
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat[i, i] != n)//n
                    return false;
            }
            return true;//1
        }

        static int MaxInMat(int[,] mat)//4n^2 + 3n + 3
        {
            int max = mat[0, 0];//1
                                //1           //n           //n
            for (int i = 0; i < mat.GetLength(0); i++)
            {         //n           //n^2             //n^2
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] > max)//n^2
                        max = mat[i, j];//n^2
                }
            }
            return max;//1
        }

        static bool Exist(int[,] mat, int num)//3n^2 + 3n + 1
        {           //1           //n              //n
            for (int i = 0; i < mat.GetLength(0); i++)
            {              //n         //n^2          /N^2
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == num)//n^2
                        return true;
                }
            }
            return false;//1
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
