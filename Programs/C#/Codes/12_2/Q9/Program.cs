using System;

namespace Q9
{
    class Program
    {
        static bool IfLetter(char Note)
        {
            int note = (int)Note;
            bool IsNote = false;
            if ((note >= 97 && note <= 122) || (note >= 65 && note <= 90))
            {
                IsNote = true;
            }
            else
            {
                IsNote = false;
            }
            return IsNote;
        }
        static void Main(string[] args)
        {
            char Note;
            Console.WriteLine("Enter a note");
            Note = char.Parse(Console.ReadLine());
            if (IfLetter(Note) == true)
            {
                Console.WriteLine("It is a letter from the abc");
            }
            else
            {
                Console.WriteLine("Its not a letter from the abc");
            }
            Console.WriteLine("-------------------");
            int Count = 0;
            int MinCount = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Enter a note");
                Note = char.Parse(Console.ReadLine());
                while (IfLetter(Note) == true)
                {
                    Count++;
                    Console.WriteLine("Enter a note");
                    Note = char.Parse(Console.ReadLine());
                }
                if (i == 1)
                {
                    MinCount = Count;
                }
                if (Count < MinCount)
                {
                    MinCount = Count;
                }
                Console.WriteLine($"The length is {Count}");
                Count = 0;
            }
            Console.WriteLine($"The shortest is {MinCount}");
        }
    }
}
