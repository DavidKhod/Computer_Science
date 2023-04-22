namespace Q2
{
    class Program
    {
        public int CountSameSize(RingsTower R1, RingsTower R2)
        {
            int cnt = 0;
            for (int i = 0; i <= R1.getN(); i++)
            {
                for (int j = 0; j <= R2.getN(); j++)
                {
                    if (R1.getBiggest() - (i * R1.getdiff()) == R2.getBiggest() - (j * R2.getdiff()))
                        cnt++;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {

        }
    }
}
