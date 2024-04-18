using System;
using CounterTask;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            // Use the Clock class to display the time
            var clock = new Clock();
            for (int i = 0; i < 86400; i++)
            {
                clock.PrintTime();
                clock.Tick();
            }
        }
    }
}
