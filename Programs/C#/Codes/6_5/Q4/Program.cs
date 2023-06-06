using System;

namespace Q4
{
    class Program
    {
        static bool WordExistInText(string text, string word)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || text[i] == ' ')
                {
                    string newWord = "";
                    for (int j = i == 0 ? i : i + 1; j < text.Length && text[j] != ' '; j++)
                        newWord += text[j];
                    if (newWord == word)
                        return true;
                }
            }
            return false;
        }

        static bool AddNewStudentToClass(string[] classes, string name)
        {
            for (int i = 0; i < classes.Length; i++)
            {
                if (WordExistInText(classes[i], name) == false)
                {
                    classes[i] += $" {name}";
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the amount of classes there is: ");
            n = int.Parse(Console.ReadLine());
            string[] classes = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the students for class {i + 1}: ");
                classes[i] = Console.ReadLine();
            }

            Console.Write("Enter the name of the student to add: ");
            string studentName = Console.ReadLine();

            if (AddNewStudentToClass(classes, studentName))
            {
                Console.WriteLine("Student added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add the student");
            }

            Console.WriteLine("\nUpdated class list:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Class {i + 1}: {classes[i]}");
            }
        }
    }
}
