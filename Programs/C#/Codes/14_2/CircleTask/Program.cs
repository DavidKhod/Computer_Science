using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle קלוט את הרדיוס והצבע של מעגל וצור עצם מטיפוס המחלקה 
            double radius;
            string color;
            Console.WriteLine("Enter the radius of the circle");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color of the circle");
            color = Console.ReadLine();
            Circle c1 = new Circle(radius, color);
            //  הערה: מכאן ואילך אין להשתמש במשתני הקלט אלא רק בפעולות על העצם שיצרת 


            // הדפס את פרטי המעגל שיצרת
            Console.WriteLine(c1.ToString());

            // הגדל את רדיוס המעגל ב-1
            c1.IncRadius();

            // 10-הגדל את רדיוס המעגל ב
            c1.SetRadius(c1.GetRadius() + 10);

            // הצג את פרטי המעגל המעודכנים
            Console.WriteLine(c1.ToString());

            // הדפס את צבע המעגל
            Console.WriteLine(c1.GetColor());

            // שנה את צבע המעגל לאדום
            c1.SetColor("Red");
            Console.WriteLine(c1.ToString());
        }
    }
}
