using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5B
{
    public class Model
    {
        public string name { get; }
        public int age { get; }
        public double height { get;}
        public string id { get;}
        public int type { get; }
        public Model(string name,int age,double height,string id,int type)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.id = id;
            this.type = type;
        }

        public override string ToString()
        {
            return $"Name: {name},Age: {age},Height: {height},Id: {id}";
        }
    }
}
