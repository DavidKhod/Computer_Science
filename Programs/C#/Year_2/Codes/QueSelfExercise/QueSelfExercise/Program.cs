
using System;

class Program
{

    // 1
    //  פעולה שתקבל תור של מספרים שלמים ותחזיר את מספר האיברים בתור
    static int Length(Queue<int> que)
    {
        int cnt = 0;
        for (Queue<int> pos = que; !pos.IsEmpty(); pos.Remove(), cnt++) { }
        return cnt;
    }

    // 2
    //  פעולה שתקבל תור של מספרים שלמים ומספר שלם נוסף
    // הפעולה תחזיר אמת אם המספר הנתון נמצא בתור
    // אחרת, הפעולה תחזיר שקר
    static bool Exist(Queue<int> que, int num)
    {
        for (Queue<int> pos = que; !pos.IsEmpty(); pos.Remove())
            if (pos.Head() == num)
                return true;
        return false;
    }

    // 3
    //  פעולה שתקבל תור של מספרים שלמים 
    // הפעולה תחזיר את הערך המקסימלי בתור
    // הנחה: התור לא ריק
    static int MaxValue(Queue<int> que)
    {
        int max = que.Head();
        que.Remove();
        for (Queue<int> pos = que; !pos.IsEmpty(); pos.Remove())
            max = Math.Max(max, pos.Head());
        return max;
    }

    // 4
    //  פעולה שתקבל תור של מספרים שלמים 
    // הפעולה תחזיר אמת אם הערכים בתור ממוינים בסדר עולה
    // אחרת הפעולה תחזיר שקר
    static bool IsSorted(Queue<int> que)
    {
        Queue<int> copy = Duplicate(que);
        int prev = copy.Head();
        copy.Remove();
        while(!copy.IsEmpty())
        { 
            if (prev > copy.Head())
                return false;
            else
                prev = copy.Remove();
        }
        return true;
    }

    // 5
    // x  פעולה שתקבל תור של מספרים שלמים ומספר שלם  
    // מהתור x הפעולה תוציא את כל האיברים שערכם 
    static Queue<int> RemoveNum(Queue<int> que, int num)
    {
        Queue<int> newQue = new Queue<int>();
        for (Queue<int> pos = que; !pos.IsEmpty(); pos.Remove())
            if (que.Head() != num)
                newQue.Insert(que.Head());
        return newQue;
    }

    // 6
    //  פעולה שתקבל תור של מספרים שלמים    
    // הפעולה תחזיר תור חדש שהוא העתק של התור
    static Queue<int> Duplicate(Queue<int> que)
    {
        Queue<int> copy = new Queue<int>();
        for (Queue<int> pos = que; !pos.IsEmpty(); pos.Remove())
            copy.Insert(pos.Head());
        return copy;
    }

    static Queue<int> CreateQueue(int n)
    {
        Queue<int> que = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}-Enter an integer:");
            que.Insert(int.Parse(Console.ReadLine()));
            Console.WriteLine(que);
        }
        return que;
    }

    static void Main(string[] args)
    {
        // כתוב תוכנית בדיקה שתיצור תור של מספרים שלמים
        // תכניס לתור מספר ערכים ותבדוק את נכונות כל הפעולות שכתבת
        Queue<int> que = CreateQueue(5);
        Console.WriteLine(que.ToString());
        Console.WriteLine($"Length: {Length(que)}");
        Console.WriteLine($"Exist(3): {Exist(que, 3)}");
        Console.WriteLine($"MaxValue: {MaxValue(que)}");
        Console.WriteLine($"IsSorted: {IsSorted(que)}");
        Console.WriteLine($"RemoveNum 5: {RemoveNum(que, 5)}");
        Console.WriteLine($"Duplicate: {Duplicate(que)}");
    }
}

