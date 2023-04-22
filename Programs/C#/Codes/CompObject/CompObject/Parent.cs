namespace CompObject
{
    public class Parent
    {
        private string name;
        private string cellNum;


        public Parent(string name = "", string cellNum = "")
        {
            this.name = name;
            this.cellNum = cellNum;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string CellNum
        {
            get { return this.cellNum; }
            set { this.cellNum = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Cell Number: {this.cellNum}";
        }
    }
}
