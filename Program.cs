using System;

namespace HelloWorld
{
    class Program
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)

        {
            Message[] messages =
                {
                new Message("Welcome back"),
                new Message("What a lovely name"),
                new Message("Great name"),
                new Message("Oh hi!"),
                new Message("That is a silly name")
            };
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (name.ToLower() == "afra")
            {
                messages[0].Print();
            }
            else if (name.ToLower() == "eli")
            {
                messages[1].Print();
            }
            else if (name.ToLower() == "emily")
            {
                messages[2].Print();
            }
            else if (name.ToLower() == "ramya")
            {
                messages[3].Print();
            }
            else
            {
                messages[4].Print();
            }

            Console.ReadLine();
        }
    }
}