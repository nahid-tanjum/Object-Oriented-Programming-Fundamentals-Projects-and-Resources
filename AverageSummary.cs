// Import necessary libraries
using System;
using System.Collections.Generic;


// Define a public class named "AverageSummary" which inherits from a "SummaryStrategy" class
public class AverageSummary : SummaryStrategy
{
    // Define a private method named "Average" which takes a list of integers as input, calculates the average of the numbers, and returns it as a float
    private float Average(List<int> numbers)
    {
        // Initialize a variable "sum" to 0
        int sum = 0;
        // Iterate through the input list of integers and add each integer to "sum"
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average by dividing the sum of the numbers by the count of the numbers and convert it to float
        return (float)sum / numbers.Count;
    }

    // Override the "PrintSummary" method in the parent class
    public override void PrintSummary(List<int> numbers)
    {
        // Call the "Average" method to get the average of the numbers in the input list
        float avg = Average(numbers);

        // Print the calculated average
        Console.Write("The Average we can get from the num: ");
        Console.WriteLine(avg);
    }

}