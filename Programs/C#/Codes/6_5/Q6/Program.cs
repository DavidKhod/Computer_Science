using System;
namespace Q6
{
    class Program
    {
        static int AmountOfAppearancesOfWord(string text, string word)
        {
            int cnt = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || text[i] == ' ')
                {
                    string newWord = "";
                    for (int j = i == 0 ? i : i + 1; j < text.Length && text[j] != ' '; j++)
                        newWord += text[j];
                    if (newWord == word)
                        cnt++;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string inputText = "Hello world Hello universe Hello everyone";
            string searchWord = "Hello";
            Console.WriteLine($"The word '{searchWord}' appears {AmountOfAppearancesOfWord(inputText, searchWord)} times in the text");
        }
    }
}
