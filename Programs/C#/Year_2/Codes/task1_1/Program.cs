static void PrintLongest(string s1, string s2)
{
    if (s1.Length > s2.Length)
        Console.WriteLine(s1);
    else if (s2.Length > s1.Length)
        Console.WriteLine(s2);
    else Console.WriteLine($"{s1} {s2}");
}

static string ReturnLongest(string s1, string s2)
{
    if (s1.Length > s2.Length)
        return s1;
    else if (s2.Length > s1.Length)
        return s2;
    else
        return s1 += s2;
}

static void PrintReverse(string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
    {
        Console.Write(s[i]);
    }
}

static string ReturnReverse(string s)
{
    string rev = "";
    for (int i = s.Length - 1; i >= 0; i--)
    {
        rev += s[i];
    }
    return rev;
}

static void PrintZigZag(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
    {
        Console.Write(s[i]);
        Console.Write(s[s.Length - i]);
    }
}

static char BiggestChar(string s)
{
    char max = s[0];
    for (int i = 1; i < s.Length; i++)
    {
        if (max < s[i])
            max = s[i];
    }
    return max;
}

static int MinPlace(string s)
{
    char min = 'z';
    int place = -1;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] < min)
        {
            min = s[i];
            place = i;
        }
    }
    return place;
}

static int CountChar(string s, char let)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == let)
            count++;
    }
    return count;
}

static bool isSorted(string s)
{

    for (int i = 1; i < s.Length; i++)
    {
        if (s[i] < s[i - 1])
            return false;
    }
    return true;
}





