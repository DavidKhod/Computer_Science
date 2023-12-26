using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P116Q19
{
    class Program
    {
        static int GetKidsInClass(CoupleNames[,] coupleClass)
        {
            int cnt = 0;
            for (int i = 0; i < coupleClass.GetLength(0); i++)
            {
                for (int j = 0; j < coupleClass.GetLength(1); j++)
                {
                    cnt += coupleClass[i, j].GetKidsAmount();
                }
            }
            return cnt;
        }

        static int FindKidsPlace(CoupleNames[,] coupleClass,string name)
        {
            for (int i = 0; i < coupleClass.GetLength(0); i++)
            {
                for (int j = 0; j < coupleClass.GetLength(1); j++)
                {
                    if (coupleClass[i, j].Name1 == name)
                        return i * 10 + j;
                    else if (coupleClass[i, j].Name2 == name)
                        return i * 10 + j;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {

        }
    }
}
