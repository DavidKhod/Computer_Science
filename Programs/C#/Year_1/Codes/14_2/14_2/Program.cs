using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Box קלוט נתוני אורך, רוחב וגובה של תיבה וצור עצם מטיפוס המחלקה 
            double length, width, height;
            Console.WriteLine("Enter the length of the box");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the box");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the box");
            height = double.Parse(Console.ReadLine());
            Box Box1 = new Box(length, width, height);

            //  הערה: מכאן ואילך אין להשתמש במשתני הקלט אלא רק בפעולות על העצם שיצרת 


            // הדפס את פרטי התיבה שיצרת
            Console.WriteLine(Box1.ToString());

            // הגדל את אורך התיבה ב-2
            Box1.SetLength(Box1.GetLength()+2);

            // הצג את פרטי התיבה המעודכנים
            Console.WriteLine(Box1.ToString());

            // חשב והדפס מהו הממד הארוך מבין שלושת ממדי התיבה
            if (Box1.GetLength() >= Box1.GetWidth() && Box1.GetLength() >= Box1.GetHeight())
            {
                Console.WriteLine(Box1.GetLength());
            }
            else if (Box1.GetWidth() >= Box1.GetLength() && Box1.GetWidth() >= Box1.GetHeight())
            {
                Console.WriteLine(Box1.GetWidth());
            }
            else if (Box1.GetHeight() >= Box1.GetLength() && Box1.GetHeight() >= Box1.GetWidth())
            {
                Console.WriteLine(Box1.GetHeight());
            }
            // הדפס את נפח התיבה
            Console.WriteLine(Box1.GetVolume());
        }
    }
}
