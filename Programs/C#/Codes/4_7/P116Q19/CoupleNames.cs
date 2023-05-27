namespace P116Q19
{
    class CoupleNames
    {
        private string name1;
        private string name2;

        public CoupleNames(string name1, string name2)
        {
            this.name1 = name1;
            this.name2 = name2;
        }

        public int GetKidsAmount()
        {
            int cnt = 0;
            if (this.name1 != "")
                cnt++;
            if (this.name2 != "")
                cnt++;
            return cnt;
        }

        public string Name1
        {
            get { return this.name1; }
            set { this.name1 = value; }
        }

        public string Name2
        {
            get { return this.name2; }
            set { this.name2 = value; }
        }

        public override string ToString()
        {
            return $"Name 1: {this.name1},Name2: {this.name2}";
        }

    }
}
