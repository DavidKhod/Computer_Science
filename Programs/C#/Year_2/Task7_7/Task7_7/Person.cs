using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_7
{
    public class Person
    {
        public string name { get; }
        public string phoneNum { get; }

        public Person(string name, string phoneNum)
        {
            this.name = name;
            this.phoneNum = phoneNum;
        }

        public override string ToString()
        {
            return $"Name: {name},Phone number: {phoneNum}";
        }

    }
}
