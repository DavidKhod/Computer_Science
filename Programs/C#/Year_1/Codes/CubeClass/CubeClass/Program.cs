using System;

namespace CubeClass
{
    class Program
    {
        static Random rnd = new Random();
        /// <summary>
        /// Generates a Cube with Randomized side length and color
        /// </summary>
        /// <returns>A randomized Cube</returns>
        static Cube GenerateCube()
        {
            int side = rnd.Next(1, 51);
            int temp = rnd.Next(1, 5);
            string[] colors = new string[] { "Blue", "Red", "Yellow", "Green", "Purple", "Cyan", "Orange" };
            Cube tempC = new Cube(side, colors[rnd.Next(0, 4)]);
            return tempC;
        }

        /// <summary>
        /// The function inputs a Tower and converts it into a new tower so that the tower would have not reapiting cubes with the same color
        /// </summary>
        /// <param name="tower">The tower con</param>
        /// <returns></returns>
        static CubesTower ConvertToSpecialColorsTower(CubesTower tower)
        {
            Cube[] tempcubeList = new Cube[tower.GetCubes().Length];
            int cnt = 0;
            for (int i = 0; i < tower.GetCubes().Length; i++)
            {
                if (tower.GetCubes()[i] != null)
                {
                    tempcubeList[cnt] = tower.GetCubes()[i];
                    cnt++;
                    for (int j = 0; j < tower.GetCubes().Length; j++)
                    {
                        if (tower.GetCubes()[j] != null && i != j)
                        {
                            if (tower.GetCubes()[i].Color == tower.GetCubes()[j].Color)
                            {
                                tower.GetCubes()[j] = null;
                            }
                        }
                    }
                }
            }
            int cubeAmount = 0;
            foreach (Cube cube in tower.GetCubes())
            {
                if (cube != null)
                    cubeAmount++;
            }
            CubesTower returnTower = new CubesTower(cubeAmount);
            foreach (Cube cube in tower.GetCubes())
            {
                if (cube != null)
                    returnTower.Add(cube);
            }
            for (int i = 0; i < tower.GetCubes().Length; i++)
            {
                tower.GetCubes()[i] = null;
            }
            return returnTower;
        }
        static void Main(string[] args)
        {
            Console.Write($"Enter the max amount of cubes in the tower: ");
            int maxAmount = int.Parse(Console.ReadLine());
            CubesTower tower = new CubesTower(maxAmount);
            int desicion = 1;
            while (desicion != 0 && tower.Add(GenerateCube()) && tower.Remove() != null)
            {
                if (desicion == -1)
                {
                    int des = 0;
                    Console.Write($"Randimize -> 1, Manualy -> 2: ");
                    des = int.Parse(Console.ReadLine());
                    if (des == 1)
                    {
                        tower.Add(GenerateCube());
                    }
                    else
                    {
                        Console.Write($"Enter the length of the side of the cube: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write($"Enter the color of the cube: ");
                        string color = Console.ReadLine();
                        Cube cube = new Cube(side, color);
                        tower.Add(cube);
                    }
                }
                if (desicion == -2)
                {
                    tower.Remove();
                }
                Console.WriteLine($"{tower.ToString()}");
                Console.WriteLine("Make a desecion(-1 Add a cube,-2 remove a Cube,0 stop,)");
                desicion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Finished");
            Console.WriteLine($"Convertiong Randomized towers into towers with unique colors only....");
            Console.WriteLine($"---------With-function---------");
            CubesTower tryingTower = new CubesTower(rnd.Next(10, 21));
            while (tryingTower.Add(GenerateCube()) != false)
            {
                tryingTower.Add(GenerateCube());
            }
            Console.WriteLine($"Randomized tower:\n{tryingTower.ToString()}");
            tryingTower = ConvertToSpecialColorsTower(tryingTower);
            Console.WriteLine($"After convertiong:\n{tryingTower.ToString()}");
            Console.WriteLine($"---------With-Class---------");
            CubesTower tryingTower2 = new CubesTower(rnd.Next(10, 21));
            while (tryingTower2.Add(GenerateCube()) != false)
            {
                tryingTower2.Add(GenerateCube());
            }
            Console.WriteLine($"Randomized tower:\n{tryingTower2.ToString()}");
            tryingTower2.ConvertToSpecialColorsTower();
            Console.WriteLine($"After convertiong:\n{tryingTower2.ToString()}");
        }
    }
}
