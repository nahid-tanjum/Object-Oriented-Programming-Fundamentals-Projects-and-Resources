using System;
using System.Collections.Generic;

namespace FileSystemSimulation
{
    public class Folder : Thing
    {
        private List<Thing> contents = new List<Thing>();

        public Folder(string name) : base(name) { }

        public void Add(Thing thing)
        {
            contents.Add(thing);
        }

        public override int Size()
        {
            int totalSize = 0;
            foreach (var thing in contents)
            {
                totalSize += thing.Size();
            }
            return totalSize;
        }

        public override void Print()
        {
            Console.WriteLine($"Folder: {name}, Total Size: {Size()} bytes");
            foreach (var thing in contents)
            {
                thing.Print();
            }
        }
    }
}
