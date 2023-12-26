using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_SelfPractice
{
    class Program
    {
        static Random rnd = new Random();

        static int CalcSumIndex(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    sum += mat[i, j];
                }
            }
            return sum;
        }

        static int FindMaxNum(int[,] mat)
        {
            int max = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] > max)
                        max = mat[i, j];
                }
            }
            return max;
        }

        static string PlacesEqualToMax(int [,] mat)
        {
            int max = FindMaxNum(mat);
            string print = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == max)
                        print += $"Row: {i},Col: {j}";
                }
            }
            return print;
        }

        static string EvenRowsNums(int[,] mat)
        {
            string print = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        print += $"{mat[i, j]}";
                    }
                }
            }
            return print;
        }

        static int SumOddRowsNums(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i % 2 != 0)
                    {
                        sum += mat[i, j];
                    }
                }
            }
            return sum;
        }

        static int SumRow(int[,] mat,int index)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                sum += mat[index, i];
            }
            return sum;
        }

        static void PrintCol(int[,] mat,int col)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum += mat[i, col];
            }
            Console.WriteLine($"The sum of collum {col} is: {sum}");
        }

        static bool Exist(int[,] mat,int val)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == val)
                        return true;
                }
            }
            return false;
        }

        static bool AllPositive(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < 0)
                        return false;
                }
            }
            return true;
        }

        static int Absolute(int[,] mat)
        {
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] != Math.Abs(mat[i, j]))
                    {
                        mat[i, j] = Math.Abs(mat[i, j]);
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.Write($"\n");
            }
        }

        static int[,] BuildMatrix(int n,int m)
        {
            int[,] mat = new int[n, m];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                   mat[i, j] = rnd.Next(1, 10);
                }
            }
            return mat;
        }

        static void Main(string[] args)
        {

            // הגדר מערך דו-ממדי בגודל 4 שורות על 5 עמודות של מספרים שלמים
            int[,] mat = new int[4, 5];

            // הדפס את תוכן תאי המערך הדו-ממדי כך שכל שורה תודפס בנפרד  
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i,j]} ");
                }
                Console.Write($"\n");
            }
            // GetLength(1)- ו GetLength(0) השתמש בפעולות
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.Write($"\n");
            }
            // להחזרת מספר השורות ומספר בעמודות במערך הדו-ממדי בהתאמה 
            Console.WriteLine($"Rows: {mat.GetLength(0)}");
            Console.WriteLine($"Collums: {mat.GetLength(1)}");

            // קלוט לכל התאים ערכים מהמשתמש 
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Enter a number: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // הדפס את תוכן תאי המערך הדו-ממדי כך שכל שורה תודפס בנפרד  
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.Write($"\n");
            }

            // כתוב פעולה חיצונית שתקבל מערך דו-ממדי של מספרים שלמים
            // ותחזיר את סכום כל התאים במערך 
            // והדפס את הסכום sum זמן את הפעולה, השם את התוצאה במשתנה
            Console.WriteLine($"The sum of all the indexes is: {CalcSumIndex(mat)}");

            // כתוב פעולה חיצונית שתקבל מערך דו-ממדי של מספרים שלמים
            // ותחזיר את הערך המקסימלי במערך 
            Console.WriteLine($"Enter biggest number in the matrix is; {FindMaxNum(mat)}");

            // כתוב לולאה שתדפיס את הערך המקסימלי במערך הדו-ממדי
            // ואת מיקומי כל התאים בעלי הערך המקסימלי
            // [,] מיקום = אינדקס השורה ואינדקס העמודה של התא בפורמט 
            // עליך להשתמש בפעולה שכתבת. 
            Console.WriteLine(PlacesEqualToMax(mat));

            // (הדפס את תוכן התאים של השורות הזוגיות בלבד (אינדקס השורה הוא זוגי
            Console.WriteLine(EvenRowsNums(mat));

            // (הדפס את סכום התאים של העמודות האי-זוגיות בלבד (אינדקס העמודה הוא אי-זוגי
            Console.WriteLine($"Sum of odd rows: {SumOddRowsNums(mat)}");

            // (הדפס את כל ערכי המערך בסדר שורות הפוך (כלומר השורה האחרונה תודפס ראשונה והראשונה תודפס אחרונה
            // סדר העמודות ללא שינוי
            for (int i = mat.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.Write($"\n");
            }

            // שתקבל מערך דו-ממדי של מספרים שלמים ואינדקס שורה SumRow כתוב פעולה 
            // ותחזיר את סכום כל התאים בשורה הנתונה
            int sumOfRow = SumRow(mat, 4);
            Console.WriteLine($"Sum of row 5: {sumOfRow}");

            // (הדפס את סכום כל התאים בשורה השלישית בלבד (אינדקס השורה = 2
            // השתמש בפעולה שכתבת
            Console.WriteLine($"Sum of row 3: {SumRow(mat,2)}");

            // שתקבל מערך דו-ממדי של מספרים שלמים ואינדקס עמודה PrintCol כתוב פעולה 
            // ותדפיס את ערכי כל התאים בעמודה הנתונה


            // (הדפס את ערכי כל התאים בעמודה הרביעית בלבד (אינדקס העמודה = 3
            // השתמש בפעולה שכתבת
            PrintCol(mat,3);

            // val שתקבל מערך דו-ממדי של מספרים שלמים ומספר  Exist כתוב פעולה 
            // הפעולה תחזיר אמת אם המספר מופיע במערך או שקר אחרת
            int val = rnd.Next(1, 11);
            if (Exist(mat,val))
            {
                Console.WriteLine($"{val} exist in the matrix");
            }

            // שתקבל מערך דו-ממדי של מספרים שלמים   AllPositive כתוב פעולה 
            // הפעולה תחזיר אמת אם כל המספרים במערך חיוביים או שקר אחרת
            if (AllPositive(mat))
            {
                Console.WriteLine($"All numbers are positive");
            }

            // שתקבל מערך דו-ממדי של מספרים שלמים Absolute כתוב פעולה 
            // הפעולה תציב בכל תא את הערך המוחלט של ערכו המקורי
            // ותחזיר את מספר המספרים הערכים ששונו  


            // זמן את הפעולה ואחר-כך הדפס את המערך
            Console.WriteLine($"Numbers changed: {Absolute(mat)}");
            PrintMatrix(mat);

            // m-ו n שתקבל שנח מספרים שלמים   BuildMatrix כתוב פעולה 
            // nxm הפעולה  תיצור מערך דו-ממדי של מספרים שלמים בגודל 
            // תגריל בכל אחד מהתאים ספרה (0-9) ותחזיר את המערך הדו-ממדי
            PrintMatrix(BuildMatrix(rnd.Next(1, 11), rnd.Next(1, 11)));

            // כתוב קטע קוד שיקלוט את מספר השורות והעמודות
            // (וייצור מערך דו-ממדי של מספרים אקראיים בתחום (0-9
            // שגודלו בהתאם לנתוני הקלט
            // השתמש בפעולה שכתבת
            // לאחר סיום הפעולה, יש להדפיס את המערך החדש שנוצר 

            int n, m;
            Console.Write($"Enter the amount of rows: ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Enter the amount of collums: ");
            m = int.Parse(Console.ReadLine());
            PrintMatrix(BuildMatrix(n,m));
        }
    }
}
