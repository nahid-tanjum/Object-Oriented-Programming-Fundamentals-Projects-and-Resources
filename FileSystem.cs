using System;
using System.Collections.Generic;

namespace FileSystemSimulation
{
    public class FileSystem
    {
        private List<Thing> contents = new List<Thing>();

        public void Add(Thing thing)
        {
            contents.Add(thing);
        }

        public void PrintContents()
        {
            System.Console.WriteLine("File System Contents:");
            foreach (var thing in contents)
            {
                thing.Print();
            }
        }
    }
}
