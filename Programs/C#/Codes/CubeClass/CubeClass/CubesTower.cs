namespace CubeClass
{
    public class CubesTower
    {
        private int maxCubes;
        private int CurrentAmount;
        private Cube[] Cubes;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxCubes">The max amount of cubes can be in the tower</param>
        public CubesTower(int maxCubes)
        {
            this.maxCubes = maxCubes;
            this.CurrentAmount = 0;
            this.Cubes = new Cube[maxCubes];
        }

        public int GetMaxAmount()
        {
            return this.maxCubes;
        }

        public void SetMaxAmount(int toSet)
        {
            this.maxCubes = toSet;
        }

        public int GetCurrentAmount()
        {
            return this.CurrentAmount;
        }

        public void SetCurrentAmoun(int toSet)
        {
            this.CurrentAmount = toSet;
        }

        /// <summary>
        /// Gets the Cube Array of the tower
        /// </summary>
        /// <returns>A Cube Array of the tower</returns>
        public Cube[] GetCubes()
        {
            return this.Cubes;
        }

        /// <summary>
        /// Adds a cube to the tower if possible
        /// </summary>
        /// <param name="other">the cube to be added</param>
        /// <returns>True if the cube was added,False if the cube was not added</returns>
        public bool Add(Cube other)
        {
            if (this.CurrentAmount < this.maxCubes)
            {
                Cubes[this.CurrentAmount] = new Cube(other);
                this.CurrentAmount++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes a cube from the top of the tower (the last cube in the Cube Array)
        /// </summary>
        /// <returns>The cube removed</returns>
        public Cube Remove()
        {
            if (this.CurrentAmount > 0)
            {
                Cube toReturn = new Cube(Cubes[this.CurrentAmount - 1]);
                Cubes[CurrentAmount - 1] = null;
                this.CurrentAmount--;
                return toReturn;
            }
            return null;
        }

        /// <summary>
        /// Checks if the color inputed exists in the tower
        /// </summary>
        /// <param name="color">The color looking for</param>
        /// <returns>True if the color appears in the tower,False if not</returns>
        public bool FindColor(string color)
        {
            foreach (Cube cube in this.Cubes)
            {
                if (cube.Color.Equals(color))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the tower is empty
        /// </summary>
        /// <returns>True if the tower is empty,False if not</returns>
        public bool IfEmpty()
        {
            return this.CurrentAmount == 0;
        }

        /// <summary>
        /// Checks if the tower is full
        /// </summary>
        /// <returns>True if the tower is full,False if not</returns>
        public bool IsFull()
        {
            return this.CurrentAmount == this.maxCubes;
        }

        /// <summary>
        /// Checks if the tower inputed is equal to the pointer
        /// </summary>
        /// <param name="other">The tower comparing with</param>
        /// <returns>True if the towers are equal,False if not</returns>
        public bool IsEqual(CubesTower other)
        {
            if (this.CurrentAmount == other.CurrentAmount && this.maxCubes == other.maxCubes)
            {
                for (int i = 0; i < this.maxCubes; i++)
                {
                    if (Cubes[i] != other.GetCubes()[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Converts the pointer tower into a tower with no repeating colors on cubes
        /// </summary>
        public void ConvertToSpecialColorsTower()
        {
            Cube[] tempcubeList = new Cube[this.Cubes.Length];
            int cnt = 0;
            for (int i = 0; i < this.Cubes.Length; i++)
            {
                if (this.Cubes[i] != null)
                {
                    tempcubeList[cnt] = this.Cubes[i];
                    cnt++;
                    for (int j = 0; j < this.Cubes.Length; j++)
                    {
                        if (this.Cubes[j] != null && i != j)
                        {
                            if (this.Cubes[i].Color == this.Cubes[j].Color)
                            {
                                this.Cubes[j] = null;
                            }
                        }
                    }
                }
            }
            this.OrgenizeCubes();
        }

        /// <summary>
        /// Orgenized the tower Cube Array so that the cubes with the values would be closer to zero
        /// </summary>
        private void OrgenizeCubes()
        {
            for (int i = 0; i < this.Cubes.Length; i++)
            {
                if (this.Cubes[i] == null)
                {
                    bool stop = false;
                    for (int j = i; j < this.Cubes.Length && stop == false; j++)
                    {
                        if (this.Cubes[j] != null)
                        {
                            this.Cubes[i] = this.Cubes[j];
                            this.Cubes[j] = null;
                            stop = true;
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            string print = "";
            bool stop = false;
            for (int i = 0; i < this.GetMaxAmount() && stop == false; i++)
            {
                if (this.Cubes[i] != null)
                {
                    print += $"|{Cubes[i].ToString()}|\n";
                }
                else
                {
                    stop = true;
                }
            }
            return print;
        }
    }
}
