using System;
namespace Q1
{
    class Program
    {
        static int CountWordStartWith(string str, string starting)
        {
            int cnt = 0;
            int lenghtOfStarting = starting.Length;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == 0)
                {
                    string word = "";
                    for (int j = i + 1; j < str.Length && str[j] != ' '; j++)
                    {
                        word += str[j];
                    }
                    if (word.Length >= starting.Length)
                        if (word == starting || word.Substring(0, lenghtOfStarting) == starting)
                            cnt++;
                }
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            string sentence = "I am David and I am a person";
            string starting = "am";
            Console.WriteLine($"The amount of '{starting}' in the sentance '{sentence }' is: {CountWordStartWith(sentence, starting)}");// 2
            sentence = "Sally sells seashells by the seashore";
            starting = "se";
            Console.WriteLine($"The amount of '{starting}' in the sentance '{sentence }' is: {CountWordStartWith(sentence, starting)}");//3
            sentence = "Peter picked peaches from the peach tree";
            starting = "pe";
            Console.WriteLine($"The amount of '{starting}' in the sentance '{sentence }' is: {CountWordStartWith(sentence, starting)}");//2
        }
    }
}
