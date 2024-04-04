using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam899205_2010
{
    internal class Program
    {
        static void UpdateMessageBoxs(MessageBox[] messageBoxs) 
        {
            for (int i = 0; i < messageBoxs.Length; i++)
            {
                if (messageBoxs[i].currentCap >= messageBoxs[i].currentCap * 0.8)
                    messageBoxs[i].max_capacity *= 2;
                else if (messageBoxs[i].currentCap <= messageBoxs[i].currentCap * 0.3)
                    messageBoxs[i].max_capacity /= 2;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
