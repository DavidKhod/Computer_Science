using System;
namespace PracticeForExam_12_6
{
    class Contact
    {
        private string name;
        private string phone;

        public Contact(string name,string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public Contact(Contact other)
        {
            this.name = other.name;
            this.phone = other.phone;
        }

        public string Name
        {
            get{return this.name;}
            set{this.name = value;}
        }

        public string Phone
        {
            get{return this.phone;}
            set{this.phone = value;}
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Phone: {this.phone}";
        }
    }
}