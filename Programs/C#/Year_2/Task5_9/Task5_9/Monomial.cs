namespace Task5_9
{
    public class Monomial
    {
        private int num;
        private int power;

        public Monomial(int num, int power)
        {
            this.num = num;
            this.power = power;
        }

        public int Num
        {
            get { return num; }
            set { this.num = value; }
        }

        public int Power
        {
            get { return power; }
            set { this.power = value; }
        }

        public override string ToString()
        {
            return $"{num}^{power}";
        }
    }
}
