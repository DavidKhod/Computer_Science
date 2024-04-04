using System;

namespace Task5_9
{
    class Program
    {
        //Q1
        static void CreateListOfBox()
        {
            Node<Box> listOfBox = new Node<Box>(CreateABox());
            Node<Box> pos = listOfBox.Next;
            for (int i = 1; i <= 10; i++)
            {
                pos.Value = CreateABox();
                pos = pos.Next;
            }
            Console.WriteLine(BiggestVolume(listOfBox).ToString());
        }
        static Box BiggestVolume(Node<Box> list)
        {
            if (!list.HasNext())
                return list.Value;
            Box temp = BiggestVolume(list.Next);
            if (list.Value.GetVolume() < temp.GetVolume())
                return temp;
            return list.Value;
        }
        static Box CreateABox()
        {
            Console.Write($"Enter Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write($"Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write($"Enter Heigth: ");
            double height = double.Parse(Console.ReadLine());
            return new Box(length, width, height);
        }

        //Q2A
        static Node<Circle> AddCircleToList(Node<Circle> list, Circle cir)
        {
            if (cir.R <= list.Value.R)
                list = new Node<Circle>(cir, list);
            else
            {
                Node<Circle> pos = list;
                while (pos.HasNext() && cir.R > pos.Next.Value.R)
                {
                    pos = pos.Next;
                }
                pos.Next = new Node<Circle>(cir, pos.Next);
            }
            return list;
        }
        //Q2B
        static Node<Circle> BuildSortedList(int n)
        {
            Node<Circle> list = new Node<Circle>(CreateCircle());
            Node<Circle> startOfList = list;
            for (int i = 1; i < n; i++)
            {
                Circle temp = CreateCircle();
                if (temp.R <= startOfList.Value.R)
                {
                    startOfList = new Node<Circle>(temp, startOfList);
                }
                else
                {
                    list = startOfList;
                    while (list.HasNext() && temp.R > list.Next.Value.R)
                    {
                        list = list.Next;
                    }
                    list.Next = new Node<Circle>(temp, list.Next);
                }
            }
            return startOfList;
        }
        static Circle CreateCircle()
        {
            Console.Write($"Enter the Radius: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write($"Enter the color: ");
            string color = Console.ReadLine();
            return new Circle(R, color);

        }
        //Q47P99
        static int MostRolled(Node<SheshBesh> list)
        {
            int[] arr = new int[6];
            while (list != null)
            {
                arr[list.Value.Dice1 - 1]++;
                arr[list.Value.Dice2 - 1]++;
                list = list.Next;
            }
            int max = arr[0];
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i + 1;
                }
            }
            return maxIndex;
        }
        //Q48P99
        static bool CanConnectToList(Node<Domino> list, Domino dom)
        {
            while (list != null && !list.Value.IsConnectable(dom))
            {
                list = list.Next;
            }
            if (list == null)
                return false;
            return true;
        }
        //Q56P102
        static Node<Monomial> AddPolindroms(Node<Monomial> list1, Node<Monomial> list2)
        {
            Node<Monomial> pos1 = list1;
            Node<Monomial> pos2 = list2;
            Node<Monomial> rtnList = new Node<Monomial>(new Monomial(0, 0));
            Node<Monomial> pos = rtnList;
            int sum;
            while (list1 != null)
            {
                sum = 0;
                pos1 = list1;
                pos2 = list2;
                while (pos2 != null)
                {
                    if (pos1.Value.Power == pos2.Value.Power)
                        sum += pos1.Value.Num + pos2.Value.Num;
                    pos2 = pos2.Next;
                }
                pos.Next = new Node<Monomial>(new Monomial(sum, list1.Value.Power));
                pos = pos.Next;
                list1 = list1.Next;
            }
            return rtnList.Next;
        }

        //Q54P101
        static Node<int[]> Loto(Node<int[]> list)
        {
            Node<int[]> listOfNotQulified = null;
            Node<int[]> pos = listOfNotQulified;
            while (list != null)
            {
                if (Max(list.Value) - Min(list.Value) < 20)
                    pos = new Node<int[]>(list.Value);
                list = list.Next;
            }
            return listOfNotQulified;
        }
        static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        //Q53P100
        static Node<int> LastEvenNum(Node<int> list)
        {
            if (list.HasNext())
            {
                if (list.Next.Value % 2 != 0)
                    return list;
                LastEvenNum(list.Next);
            }
            return null;
        }

        //Q21P286
        static double SumExpressions(Node<Expr> list)
        {
            double sum = 0;
            while (list != null)
            {
                sum += list.Value.Calculate();
                list = list.Next;
            }
            return sum;
        }

        static Node<ZipInfo> Zip(Node<char> list)
        {
            Node<ZipInfo> listOfZips = new Node<ZipInfo>(new ZipInfo(list.Value, 1));
            list = list.Next;
            Node<ZipInfo> pos = listOfZips;
            while (list != null && list.Value == pos.Value.Ch)
            {
                pos.Value.Times++;
                list = list.Next;
            }
            pos = pos.Next;
            while (list != null)
            {
                pos = new Node<ZipInfo>(new ZipInfo(list.Value, 1));
                while (list != null && list.Value == pos.Value.Ch)
                {
                    pos.Value.Times++;
                    list = list.Next;
                }
                pos = pos.Next;
            }
            return listOfZips;
        }

        static Node<char> UnZip(Node<ZipInfo> list)
        {
            Node<char> rtnList = new Node<char>(list.Value.Ch);
            list.Value.Times--;
            Node<char> pos = rtnList;
            while (list != null)
            {
                while (list.Value.Times > 0)
                {
                    pos = new Node<char>(list.Value.Ch);
                    list.Value.Times--;
                    pos = pos.Next;
                }
                list = list.Next;
            }
            return rtnList;
        }
        static void Main(string[] args)
        {
            Node<int> lis = new Node<int>(1, new Node<int>(5));
            Node<Monomial> list1 =
                new Node<Monomial>(new Monomial(1, 5),
                new Node<Monomial>(new Monomial(5, 3),
                new Node<Monomial>(new Monomial(4, 1))));

            Console.WriteLine(list1);
            Node<Monomial> list2 =
                new Node<Monomial>(new Monomial(4, 5),
                new Node<Monomial>(new Monomial(3, 3),
                new Node<Monomial>(new Monomial(6, 1))));
            Console.WriteLine(list2);
            Console.WriteLine(AddPolindroms(list1, list2));
        }
    }
}
