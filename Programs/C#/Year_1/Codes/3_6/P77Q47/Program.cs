using System;

namespace P77Q47
{
    class Program
    {
        static Random rnd = new Random();
        static Point CreatePoint()
        {
            int x = rnd.Next(-10, 11);
            int y = rnd.Next(-10, 11);
            Point point = new Point(x, y);
            return point;
        }

        /// <summary>
        /// The function inputs an int array and makes all of his indexes equal to 0
        /// </summary>
        /// <param name="arr">The int array making it's indexes equal to 0</param>
        /// <returns>An int array in the same length as the one inputed with all of its indexe's equal to 0</returns>
        static int[] startIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Point[] points = new Point[11];
            for (int i = 1; i < points.Length; i++)
            {
                points[i] = CreatePoint();
                Console.Write(points[i].ToString());
            }
            Point pointFromMax = points[1];
            Point pointToMax = points[2];
            double MaxDistance = pointFromMax.Distance(pointToMax);
            int[] quarters = new int[5];
            quarters = startIntArray(quarters);
            for (int i = 1; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length - 1; j++)
                {
                    if (points[i].Distance(points[j]) > MaxDistance)
                    {
                        MaxDistance = points[i].Distance(points[j]);
                        pointFromMax = points[i];
                        pointToMax = points[j];
                    }
                }
                if (points[i].GetX() > 0)
                {
                    if (points[i].GetY() > 0)
                    {
                        quarters[1]++;
                    }
                    else if (points[i].GetY() < 0)
                    {
                        quarters[2]++;
                    }
                }
                else
                {
                    if (points[i].GetY() > 0)
                    {
                        quarters[4]++;
                    }
                    else if (points[i].GetY() < 0)
                    {
                        quarters[3]++;
                    }
                }
            }
            Console.WriteLine($"The two point with the biggest distance in between them is: {pointFromMax},{pointToMax}");
            int max = 0, maxPoint = 0;
            for (int i = 1; i < quarters.Length; i++)
            {
                if (quarters[i] > max)
                {
                    max = quarters[i];
                    maxPoint = quarters[i];
                }
            }
            Console.WriteLine($"The quarter with the most amount of points is: {maxPoint}");
        }
    }
}
