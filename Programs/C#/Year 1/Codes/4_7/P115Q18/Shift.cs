using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P115Q18
{
    class Shift
    {
        private string manager;
        private string worker1;
        private string worker2;

        public Shift()
        {
            this.manager = "";
            this.worker1 = "";
            this.worker2 = "";
        }

        public string Manager
        {
            get { return this.manager; }
            set { this.manager = value; }
        }

        public string Worker1
        {
            get { return this.worker1; }
            set { this.worker1 = value; }
        }

        public string Worker2
        {
            get { return this.worker2; }
            set { this.worker2 = value; }
        }

        /// <summary>
        /// This function sets one of the workers that is equal to "" into the string inputed and returns true,if all are not equal to "" than return true
        /// </summary>
        /// <param name="name">The name changing into</param>
        /// <returns>True if changed,False if not</returns>
        public bool SetWorker(string name)
        {
            if (this.worker1 == "")
            {
                this.worker1 = name;
                return true;
            }
            else if (this.worker2 == "")
            {
                this.worker2 = name;
                return true;
            }
            return false;
        }

        public bool AllNamesDiff()
        {
            return this.worker2 != this.worker1 && this.worker1 != this.manager && this.worker2 != this.manager;
        }

        public override string ToString()
        {
            return $"Manager: {this.manager},Worker 1: {this.worker1}, Worker 2: {this.worker2}";
        }
    }
}
