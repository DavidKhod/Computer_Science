using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
namespace _7_5B
{
    public class Dreams
    {
        Queue<Model> modelsQ;


        public Dreams()
        {
            modelsQ = new Queue<Model>();
        }

        public Model AcceptNextModel()
        {
            if (!modelsQ.IsEmpty())
                return modelsQ.Remove();
            return null;
        }

        public void EnterIntoQueue()
        {
            modelsQ.Insert(CreateModel());
        }

        private Model CreateModel()
        {
            string name, id;
            int age, type;
            double height;
            Console.Write($"Enter the name of the model: ");
            name = Console.ReadLine();
            Console.Write($"Enter the age of the model: ");
            age = int.Parse(Console.ReadLine());
            Console.Write($"Enter the height of the model: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the id of the mode: ");
            id = Console.ReadLine();
            Console.Write("Enter the type of model[0 -> walking,1 -> photogaph,2 -> cataloge]: ");
            type = int.Parse(Console.ReadLine());
            return new Model(name, age, height, id, type);
        }

        public Model AcceptModelByType(int type)
        {
            bool found = false;
            Model temp = null;
            Queue<Model> copy = new Queue<Model>();
            while (!modelsQ.IsEmpty())
            {
                if(!found && modelsQ.Head().type == type)
                {
                    temp = modelsQ.Remove();
                    found = true;
                }
                else
                    copy.Insert(modelsQ.Remove());
            }
            while (!copy.IsEmpty())
                modelsQ.Insert(copy.Remove());
            return temp;
        }

        public override string ToString()
        {
            return $"{modelsQ.ToString()}";
        }
    }
}
