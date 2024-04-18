// Import required namespaces
using System;
using System.Collections.Generic;

// Declare the OOP_Exam namespace
namespace OOP_Exam
{
    // Define the Program class
    class Program
    {
        // Define the entry point of the program
        static void Main(string[] args)
        {
            // Create a DataAnalyser object with a list of integers representing the individual digits of a student ID number
            Console.WriteLine("The following minimum and maximum number we get from my student ID's number");
            var test = new DataAnalyser(new List<int> { 1, 0, 3, 8, 0, 7, 0, 6, 8 }, new MinMaxSummary());

            // Call the Summarise method to calculate and output the minimum and maximum numbers from the data
            test.Summarise();

            // Add three more numbers to the data analyser
            test.AddNumber(19);
            test.AddNumber(99);
            test.AddNumber(79);
            Console.WriteLine("The Following average number we get by adding three random number 19, 99, 79");

            // Set the summary strategy to the average strategy
            test.Strategy = new AverageSummary();

            // Call the Summarise method again to calculate and output the average of all numbers in the data
            test.Summarise();

            // Wait for user input before closing the program
            Console.ReadKey();
        }
    }
}
