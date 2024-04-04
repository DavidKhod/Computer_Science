using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4New;
namespace LinkedListMethods
{
    class Program
    {
        //The function inputs a list of chars
        //The function returns the answers of the equation
        static Node<double> ResultList(Node<char> list)
        {
            Node<double> results = new Node<double>(Equation(list.GetValue(), list.GetNext().GetValue(), list.GetNext().GetNext().GetValue()));
            Node<double> pos = results;
            list = list.GetNext().GetNext().GetNext();
            while (list != null)
            {
                pos.SetNext(new Node<double>(Equation(list.GetValue(), list.GetNext().GetValue(), list.GetNext().GetNext().GetValue())));
                pos = pos.GetNext();
                list = list.GetNext().GetNext().GetNext();
            }
            return results;
        }

        static double Equation(char num1,char op,char num2)
        {
            if (op == '+')
                return (num1 - '0') + (num2 - '0');
            else if(op == '-')
                return (num1 - '0') - (num2 - '0');
            else if(op == '*')
                return (num1 - '0') * (num2 - '0');
            else 
                return (num1 - '0') / (num2 - '0');
        }
        static void Main(string[] args)
        {
            Node<char> list = new Node<char>('5', new Node<char>('+', new Node<char>('6')));
            Console.WriteLine(list);
            Console.WriteLine(ResultList(list));
        }
    }
}
