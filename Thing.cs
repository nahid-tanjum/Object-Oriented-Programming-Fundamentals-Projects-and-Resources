using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemSimulation
{
    public abstract class Thing
    {
        protected string name;

        public Thing(string name)
        {
            this.name = name;
        }

        public abstract int Size();
        public abstract void Print();
    }
}
