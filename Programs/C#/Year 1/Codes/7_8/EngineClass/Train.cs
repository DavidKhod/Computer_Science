using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClass
{
    class Train
    {
        private Engine engine;
        private Carriage[] carriages;
        private int currentCarriageAmount;
        private const int N = 40;

        public Train(Engine engine)
        {
            this.engine = new Engine(engine);
            this.currentCarriageAmount = 0;
            this.carriages = new Carriage [N];
        }

        public Engine GetEngine()
        {
            Engine engine = new Engine(this.engine);
            return engine;
        }

        public int CurrentAmountCarriage
        {
            get { return this.currentCarriageAmount; }
            set { this.currentCarriageAmount = value; }
        }

        public void ChangeEngine(Engine other)
        {
            Engine newEngine = new Engine(other);
            this.engine = newEngine;
        }

        public bool AddCarriage(Carriage newCarriage)
        {
            if (this.currentCarriageAmount < N)
            {
                Carriage addCarriage = new Carriage(newCarriage);
                this.carriages[currentCarriageAmount] = addCarriage;
                this.currentCarriageAmount++;
                return true;
            }
            return false;
        }

        public int GetMaxPassAmount()
        {
            int num = 0;
            for (int i = 0; i < this.currentCarriageAmount; i++)
            {
                num += this.carriages[i].MaxPass;
            }
            return num;
        }

        public double AveragePassAmount()
        {
            double num = 0;
            for (int i = 0; i < this.currentCarriageAmount; i++)
            {
                num += this.carriages[i].CurrentPassNum;
            }
            num = num / this.currentCarriageAmount;
            return num;
        }


        public int GetLength()
        {
            return N;
        }
        public override string ToString()
        {
            string print = $"Engine: ({this.engine.ToString()})\n";
            for (int i = 0; i < this.currentCarriageAmount; i++)
            {
                print += $"{i+1}|{carriages[i].ToString()}|\n";
            }
            return print;
        }


    }
}
