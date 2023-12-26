namespace CompObject
{
    public class Student
    {
        private string name;
        private string cellNum;
        private Parent parent;

        public Student(string name = "", string cellNum = "", Parent parent = null)
        {
            this.name = name;
            this.cellNum = cellNum;
            this.parent = parent;
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
        public Parent Parents
        {
            get { return this.parent; }
            set { this.parent = value; }
        }
        public override string ToString()
        {
            string parentID = this.parent != null ? this.parent.ToString() : "There is no information about that parent ";
            return $"Name: {this.name}, Cell Num: {this.cellNum}, --> \nParent info: {this.parent}";
        }
    }
}
