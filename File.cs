using System;


namespace FileSystemSimulation
{
    public class File : Thing
    {
        private int size;

        public File(string name, int size) : base(name)
        {
            this.size = size;
        }

        public override int Size()
        {
            return size;
        }

        public override void Print()
        {
            Console.WriteLine($"File '{name}' -- {size} bytes");
        }
    }
}

