using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClass
{
    class Engine
    {
        private int number;
        private int manufactureYear;

        public Engine(int number,int manufacturYear)
        {
            this.number = number;
            this.manufactureYear = manufacturYear;
        }

        public Engine(Engine other)
        {
            this.number = other.number;
            this.manufactureYear = other.manufactureYear;
        }

        public int LicenseNumber
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int ManufactureYear
        {
            get { return this.manufactureYear; }
            set { this.manufactureYear = value; }
        }

        public override string ToString()
        {
            return $"License Number :{this.number}, Manufacture year: {this.manufactureYear}";
        }
    }
}
