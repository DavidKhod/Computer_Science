using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task7_7
{
    public class KremboFactory
    {
        private Queue<Person> people;
        private Stack<Person> working;
        public KremboFactory()
        {
            people = new Queue<Person>();
            working = new Stack<Person>();
        }

        private Person CreatePerson()
        {
            string id, phoneNum;
            id = Console.ReadLine();
            phoneNum = Console.ReadLine();
            return new Person(id, phoneNum);
        }

        private void AddPerson(Person person)
        {
            people.Insert(person);
        }

        private void RemoveWorker()
        {
            if (!people.IsEmpty())
                working.Push(people.Remove());
            people.Insert(working.Peek());
        }

        private void AcceptWorker()
        {
            if(!people.IsEmpty())
                working.Push(people.Remove());
        }

        public void Choice(int choice)
        {
            if (choice == 1)
                AddPerson(CreatePerson());
            else if (choice == 2)
                AcceptWorker();
            else
                RemoveWorker();
        }
    }
}
