using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClass
{
    class Carriage
    {
        private static int SerialNum = 0;
        private int currentPassNum;
        private int maxPass;
        private int serialNum;
        public Carriage(int passNum,int maxPass)
        {
            SerialNum++;
            this.serialNum = SerialNum;
            this.currentPassNum = passNum;
            this.maxPass = maxPass;
        }

        public Carriage(Carriage other)
        {
            this.currentPassNum = other.currentPassNum;
            this.maxPass = other.maxPass;
            this.serialNum = other.serialNum;
        }

        public int CurrentPassNum
        {
            get { return this.currentPassNum; }
            set { this.currentPassNum = value; }
        }

        public int MaxPass
        {
            get { return this.maxPass; }
            set { this.maxPass = value; }
        }

        public int GetSerialNumber()
        {
            return this.serialNum;
        }

        public override string ToString()
        {
            return $"Serial Number: {this.serialNum},Current amount of passangers: {this.currentPassNum},Max amount of passangers: {this.maxPass}";
        }
    }
}
