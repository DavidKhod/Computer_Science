using System;
namespace Q2
{
    class Program
    {
        static bool AddAWord(string str, string name)
        {
            int cnt = 0;
            int startingOfSpaces = -1;
            for (int i = str.Length - 1; i > 0 && str[i] == ' '; i--)
            {
                cnt++;
                startingOfSpaces = i;
            }
            if (cnt < name.Length - 1)
                return false;
            if (str.Contains(name))
                return false;
            string word = str.Substring(0, startingOfSpaces);
            word += name;
            word += str.Substring(startingOfSpaces + name.Length);
            str = word;
            return true;
        }
        static void Main(string[] args)
        {
            string sentance = "DavidMaximOriOsherSamNoam     ";
            string addWord = "Jacob";
            if(AddAWord(sentance,addWord))
                Console.WriteLine($"Added {addWord} to {sentance}");//Will print this
            else
                Console.WriteLine($"Didn't Add {addWord} to {sentance}");

            sentance = "DavidMaximOriOsherSamNoam     ";
            addWord = "Alexander";
            if (AddAWord(sentance, addWord))
                Console.WriteLine($"Added {addWord} to {sentance}");
            else
                Console.WriteLine($"Didn't Add {addWord} to {sentance}");//Will print this


        }
    }
}
