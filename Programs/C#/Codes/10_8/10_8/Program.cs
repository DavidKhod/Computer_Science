using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace _10_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name1 = "Einat", Name2 = "Shfayim";
            MultiCamp Einat = new MultiCamp(Name1);
            MultiCamp Shfayim = new MultiCamp(Name2);
            int age = 0,CountNotPass = -1;
            double DistanceEinat = 0, DistanceShfayim = 0;
            while (age != -999)
            {
                bool Group1 = false, Group2 = false;
                Console.WriteLine("Enter you age");
                age = int.Parse(Console.ReadLine());
                if (age >= 8 && age <= 11)
                {
                    Group1 = true;
                    Console.Write("Enter you distance to Einat: ");
                    DistanceEinat = double.Parse(Console.ReadLine());
                    Console.Write("Enter you distance to Shfayim: ");
                    DistanceShfayim = double.Parse(Console.ReadLine());
                } 
                else if (age >= 12 && age <= 15)
                {
                    Group2 = true;
                    Console.Write("Enter you distance to Einat: ");
                    DistanceEinat = double.Parse(Console.ReadLine());
                    Console.Write("Enter you distance to Shfayim: ");
                    DistanceShfayim = double.Parse(Console.ReadLine());
                }
                else
                {
                    CountNotPass++;
                }

                if (DistanceEinat < DistanceShfayim)
                {
                    if (Einat.GetNum1() + Einat.GetNum2() < 100)
                    {
                        if (Group1)
                        {
                            Einat.Setnum1();
                        }
                        if (Group2)
                        {
                            Einat.GetNum2();
                        }
                    }
                    else if (Shfayim.GetNum1() + Shfayim.GetNum2() < 100)
                    {
                        if (Group1)
                        {
                            Shfayim.Setnum1();
                        }
                        if (Group2)
                        {
                            Shfayim.GetNum2();
                        }
                    }
                    else
                    {
                        age = -999;
                    }

                }
                if (DistanceEinat > DistanceShfayim)
                {
                    if (Shfayim.GetNum1() + Shfayim.GetNum2() < 100)
                    {
                        if (Group1)
                        {
                            Shfayim.Setnum1();
                        }
                        if (Group2)
                        {
                            Shfayim.Setnum2();
                        }
                    }
                    else if (Einat.GetNum1() + Einat.GetNum2() < 100)
                    {
                        if (Group1)
                        {
                            Einat.Setnum1();
                        }
                        if (Group2)
                        {
                            Einat.Setnum2();
                        }
                    }
                    else
                    {
                        age = -999;
                    } 
                }

            }
            Console.WriteLine(Einat);
            Console.WriteLine(Shfayim);
            Console.WriteLine($"The amount of people that didn't pass because of age is {CountNotPass}");

        }
    }
}
