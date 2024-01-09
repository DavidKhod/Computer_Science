using System;

namespace Task5_8
{
    class Program
    {

        //Q1
        //..

        //Q2
        static bool Matching(Node<int> list1, Node<int> list2)
        {
            if (list1 == null && list2 == null)
                return true;
            if ((list1 == null && list2 != null) || (list1 != null && list2 == null))
                return false;
            if (list1.Value != list2.Value)
                return false;
            return Matching(list1.Next, list2.Next);
        }

        //Q3
        static int sumOfAllEvenNums(Node<int> list)
        {
            if (list == null)
                return 0;
            if (IsFullEven(list.Value))
                return sumOfAllEvenNums(list.Next) + list.Value;
            return sumOfAllEvenNums(list.Next);
        }

        static bool IsFullEven(int num)
        {
            if (num == 0)
                return true;
            if (num % 2 != 0)
                return false;
            return IsFullEven(num / 10);
        }

        //Q4
        //A -> for True: 1,-1,1,-1. for False: 1,2,6,-1
        //B -> Entry: הפעולה מקבלת הפניה לראש רשימה של מספרים שלמים
        //     Exit: אמת אם סכום כל חוליות סמוכות קטן או שווה ל-0,שקר אם לא
        //אם נניח ש N הוא גודל הרשימה,וגודל הבסיסי הוא 5, אז O(1) * n = O(n)

        //Q5
        //z,e,z,k,b,x
        //The function inputs a linked list of char
        //The function prints the list the opposite way

        //Q6
        static Node<int> OppositeList(Node<int> list)
        {
            if (!list.HasNext())
                return list;
            Node<int> temp = OppositeList(list.Next);
            list.Next.Next = list;//Changes so that temp would point at a node with list.value
            list.Next = null;//Makes it so the there would be no pointer onto temp
            return temp;
        }

        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(1, new Node<int>(2, new Node<int>(3)));
            Console.WriteLine(list);
            Console.WriteLine(OppositeList(list));
        }
    }
}
