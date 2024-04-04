using System;

namespace Task5_5
{
    class Program
    {
        static Node<double> ConvertIntoNumbers(Node<char> list)
        {
            Node<char> startOfList = list;
            double equation = NumOpNum(list.Value, list.Next.Value, list.Next.Next.Value);
            Node<double> equations = new Node<double>(equation);
            Node<double> pos = equations;
            list = list.Next.Next.Next;// Moves three forward, example: 1-> 4-> 7-> 10...
            while (list != null)
            {
                equation = NumOpNum(list.Value, list.Next.Value, list.Next.Next.Value);
                pos.Next = new Node<double>(equation);
                pos = pos.Next;
                list = list.Next.Next.Next;
            }
            return equations;
        }

        static double NumOpNum(char num1, char op, char num2)
        {
            double equation;
            if (op == '+')
                equation = (num1 - '0') + (num2 - '0');
            else if (op == '-')
                equation = (num1 - '0') - (num2 - '0');
            else if (op == '*')
                equation = (num1 - '0') * (num2 - '0');
            else
                equation = (num1 - '0') / (num2 - '0');
            return equation;
        }

        static Node<string> OppositeToInput()//Q19P93
        {
            Console.Write($"Enter a string: ");
            string str = Console.ReadLine();
            Node<string> startOfStrings = new Node<string>(str);
            Console.Write($"Enter a string: ");
            str = Console.ReadLine();
            while (str != "")
            {
                startOfStrings = new Node<string>(str, startOfStrings);
                Console.Write($"Enter a string: ");
                str = Console.ReadLine();
            }
            return startOfStrings;
        }

        static Node<int> Merge(Node<int> chain1, Node<int> chain2)//Q11A and Q11B Page 218
        {
            Node<int> startOfChain1 = chain1;
            while (chain1.HasNext())
                chain1 = chain1.Next;
            chain1.Next = chain2;
            chain1 = startOfChain1;
            chain1 = ConvertToSortedList(chain1);
            return chain1;

        }

        static Node<int> ConvertToSortedList(Node<int> chain)
        {
            Node<int> prev = chain.Next;
            Node<int> current = chain.Next;
            Node<int> pos = chain;
            while (current != null)
            {
                int NumOfCurrent = current.Value;
                if (NumOfCurrent <= chain.Value)
                {
                    prev.Next = current.Next;
                    chain = new Node<int>(NumOfCurrent, chain);
                }
                else
                {
                    prev.Next = current.Next;
                    pos = chain;
                    while (pos.HasNext() && NumOfCurrent > pos.Next.Value)
                    {
                        pos = pos.Next;
                    }
                    pos.Next = new Node<int>(NumOfCurrent, pos.Next);
                }
                prev = prev.Next;
                current = prev.Next;
            }
            return chain;
        }
        static Node<char> CompressSequance(Node<char> chain)//Q8P217
        {
            Node<char> current = chain;
            Node<char> pos = current.Next;
            while (pos != null)
            {
                if (current.Value == pos.Value)
                {
                    while (pos != null && current.Value == pos.Value)
                    {
                        pos = pos.Next;
                    }
                    current.Next = pos;
                }
                current = current.Next;
                pos = current.Next;
            }
            return chain;
        }

        static void RemoveNum(Node<int> list, int num)
        {
            Node<int> previous = null;
            Node<int> pos = list;
            if (list.Value == num)
            {
                list = list.Next;
                previous = pos;
                pos = pos.Next;
            }
            while (pos != null)
            {
                if (pos.Value == num)
                {
                    previous.Next = pos.Next;
                    pos = pos.Next;
                }
                else
                {
                    previous = pos;
                    pos = pos.Next;
                }
            }
        }

        static Node<int> RemoveAllDuplicates(Node<int> list)//Q9P281
        {
            Node<int> start = list;
            while (list != null)
            {
                RemoveNum(list, list.Value);
                list = list.Next;
            }
            return start;
        }

        static Node<int> MoveAllEvenToStart(Node<int> list)//Q26P95
        {
            Node<int> startOfList = list;
            Node<int> prev = startOfList.Next;
            Node<int> current = prev.Next;
            while (current != null)
            {
                if (prev.Value % 2 == 0)
                {
                    startOfList = new Node<int>(prev.Value, startOfList);
                    prev.Next = current.Next;
                }
                prev = prev.Next;
                current = prev.Next;
            }
            return startOfList;
        }

        static Node<int> FlipList(Node<int> list)//Q20P93
        {
            Node<int> prev = list.Next;
            Node<int> current = prev.Next;
            while (current != null)
            {
                list = new Node<int>(current.Value, list);
                prev.Next = current.Next;
                prev = prev.Next;
                current = prev.Next;
            }
            return list;
        }
        static void Main(string[] args)
        {
            //Test ConvertIntoNumbers
            Node<char> list = new Node<char>('5', new Node<char>('+', new Node<char>('6')));
            Node<double> listNums = ConvertIntoNumbers(list);
            Console.WriteLine("ConvertIntoNumber: ");
            Console.WriteLine(listNums.ToString());
            // Test OppositeToInput
            Node<string> stringList = OppositeToInput();
            Console.WriteLine("String List:");
            Console.WriteLine(stringList.ToString());

            // Test Merge
            Node<int> chain1 = new Node<int>(1);
            chain1.Next = new Node<int>(3);
            chain1.Next.Next = new Node<int>(5);

            Node<int> chain2 = new Node<int>(2);
            chain2.Next = new Node<int>(4);
            chain2.Next.Next = new Node<int>(6);

            Node<int> mergedChain = Merge(chain1, chain2);
            Console.WriteLine("\nMerged Chain:");
            Console.WriteLine(mergedChain.ToString());

            // Test CompressSequance
            Node<char> charChain = new Node<char>('A');
            charChain.Next = new Node<char>('A');
            charChain.Next.Next = new Node<char>('B');
            charChain.Next.Next.Next = new Node<char>('A');
            Node<char> compressedChain = CompressSequance(charChain);
            Console.WriteLine("\nCompressed Chain:");
            Console.WriteLine(compressedChain.ToString());
        }
    }
}
