using System;

namespace Task5_9
{
    class Program
    {
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

        static bool CanConnectToList(Node<Domino> list,Domino dom)
        {
            while (list != null && !list.Value.IsConnectable(dom))
            {
                list = list.Next;
            }
            if (list == null)
                return false;
            return true;
        }

        static Node<Monomial> AddPolindroms(Node<Monomial> list1,Node<Monomial> list2)
        {
            Node<Monomial> pos1 = list1;
            Node<Monomial> pos2 = list2;
            Node<Monomial> rtnList = new Node<Monomial>(new Monomial(0,0));
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


        static void Main(string[] args)
        {
            Node<int> lis = new Node<int>(1, new Node<int>(5));
            Node<Monomial> list1 = 
                new Node<Monomial>(new Monomial(1, 5),
                new Node<Monomial>(new Monomial(5,3),
                new Node<Monomial>(new Monomial(4,1))));

            Console.WriteLine(list1);
            Node<Monomial> list2 =
                new Node<Monomial>(new Monomial(4, 5),
                new Node<Monomial>(new Monomial(3, 3),
                new Node<Monomial>(new Monomial(6, 1))));
            Console.WriteLine(list2);
            Console.WriteLine(AddPolindroms(list1,list2));
        }
    }
}
