// Import necessary libraries
using System;
using System.Collections.Generic;
using System.Linq;

// Define the MinMaxSummary class which inherits from SummaryStrategy
public class MinMaxSummary : SummaryStrategy
{
    // Define a private method named Minimum which takes a list of integers as input
    private int Minimum(List<int> numbers)
    {
        // Initialize the minimum value as the first element of the list
        int minimum = numbers[0];
        // Iterate through each element of the list
        foreach (int num in numbers)
        {
            // If the current element is smaller than the current minimum, set the minimum to the current element
            if (num < minimum)
            {
                minimum = num;
            }
        }
        // Return the minimum value
        return minimum;
    }

    // Define a private method named Maximum which takes a list of integers as input
    private int Maximum(List<int> numbers)
    {
        // Initialize the maximum value as the first element of the list
        int maximum = numbers[0];
        // Iterate through each element of the list
        foreach (int num in numbers)
        {
            // If the current element is greater than the current maximum, set the maximum to the current element
            if (num > maximum)
            {
                maximum = num;
            }
        }
        // Return the maximum value
        return maximum;
    }

    // Override the PrintSummary method from the SummaryStrategy class
    public override void PrintSummary(List<int> numbers)
    {
        // Call the Minimum and Maximum methods to get the minimum and maximum values from the list
        int minimum = Minimum(numbers);
        int maximum = Maximum(numbers);

        // Print the minimum and maximum values to the console
        Console.Write("The Minimum we get from the numbers: ");
        Console.WriteLine(minimum);
        Console.Write("The Maximum we get from the numbers: ");
        Console.WriteLine(maximum);
    }
}
