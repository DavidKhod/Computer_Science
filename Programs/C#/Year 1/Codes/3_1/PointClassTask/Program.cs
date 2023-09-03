using System;

namespace PointClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Point TestPoint1 = new Point(43, 7);
            Point TestPoint2 = new Point(5, 5);
            Console.WriteLine(TestPoint1.ToString());
            Console.WriteLine(TestPoint2.ToString() + "\n");
            double tempX = TestPoint1.GetX();
            TestPoint1.SetX(TestPoint2.GetX());
            TestPoint2.SetX(tempX);
            Console.WriteLine(TestPoint1.ToString());
            Console.WriteLine(TestPoint2.ToString() + "\n");
            tempX = TestPoint1.GetX();
            TestPoint1.SetX(TestPoint2.GetX());
            TestPoint2.SetX(tempX);
            Console.WriteLine(TestPoint1.Distance(TestPoint2));
            Console.WriteLine(TestPoint1.Middle(TestPoint2));
        }
    }
}
