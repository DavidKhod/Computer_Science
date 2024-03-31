namespace Task1_1
{
    internal class Program2
    {
        static string ZigZagMerge(string s1, string s2)
        {
            string merged = "";
            for (int i = 0; i < Math.Max(s1.Length, s2.Length); i++)
            {
                if (i < s1.Length)
                    merged += s1[i];
                if (i < s2.Length)
                    merged += s2[i];
            }
            return merged;
        }
    }
}
