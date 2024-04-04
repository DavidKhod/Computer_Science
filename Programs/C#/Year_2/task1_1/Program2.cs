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

        static string Intersection(string s1, string s2)
        {
            string str = "";
            bool found = false;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length && !found; j++)
                {
                    if (s1[i] != s2[j])
                        found = false;
                }
                if (found)
                    str += s1[i];
                found = false;
            }
            return str;
        }

        static string Unique(string s)
        {

        }

        static string Intersection2(string s1, string s2)
        {
            string str = "";
            bool found = false;
            for (int i = 0; i < s1.Length; i++)
            {
                found = false;
                for (int j = 0; j < s2.Length && !found; j++)
                {
                    if (s1[i] == s2[j])
                        found = true;
                }
                if (found)
                {
                    for (int j = 0; j < str.Length && found; j++)
                    {
                        if (s1[i] == str[j])
                            found = false;
                    }
                    if (found)
                        str += s1[i];
                }
            }
            return str;
        }

        //static string Intesection2(string s1, string s2)
        //{
        //    string str = "";
        //    for (int i = 0; i < s1.Length; i++)
        //    {
        //        for (int j = 0; j < s2.Length; j++)
        //            if (s1.Contains(s2) && !str.Contains(s1[i]))
        //                str += s1[i];
        //    }
        //    return str;
        //}



        static int StartsWith(string[] names, string start)
        {
            bool startsWith = true;
            int cnt = 0;
            for (int i = 0; i < names.Length; i++)
            {
                int j;
                for (j = 0; j < names[i].Length; j++)
                {
                    if(j < start.Length)

                }
                startsWith = true;
            }
        }



       

    }
}
