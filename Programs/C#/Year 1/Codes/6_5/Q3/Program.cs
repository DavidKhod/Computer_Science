using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static bool WordExistInText(string text,string word)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || text[i] == ' ')
                {
                    string newWord = "";
                    for (int j = i == 0 ? i : i+1; j < text.Length && text[j] != ' '; j++)
                        newWord += text[j];
                    if (newWord == word)
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string text = "time is money";
            string word = "time";
            Console.WriteLine(WordExistInText(text,word));//Will print true
            text = "i hope you'll visit here sometime";
            Console.WriteLine(WordExistInText(text, word));//Will print false
        }
    }
}
