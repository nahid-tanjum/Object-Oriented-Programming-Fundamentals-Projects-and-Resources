// Import necessary libraries
using System;
using System.Collections.Generic;

// Define a public class named "DataAnalyser"
public class DataAnalyser
{
    // Define private fields "_numbers" and "_strategy"
    private List<int> _numbers;
    private SummaryStrategy _strategy;

    // Define a default constructor for "DataAnalyser" class which initializes "_numbers" to an empty list and "_strategy" to an instance of "AverageSummary" class
    public DataAnalyser() : this(new List<int>(), new AverageSummary())
    {
    }

    // Define a constructor for "DataAnalyser" class which takes a list of integers as input and initializes "_numbers" to that list and "_strategy" to an instance of "AverageSummary" class
    public DataAnalyser(List<int> numbers) : this(numbers, new AverageSummary())
    {
    }

    // Define a constructor for "DataAnalyser" class which takes a list of integers and a "SummaryStrategy" object as inputs and initializes "_numbers" to the list and "_strategy" to the provided object
    public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
    {
        _numbers = numbers;
        _strategy = strategy;
    }

    // Define a public method "AddNumber" which adds an integer to the "_numbers" list
    public void AddNumber(int num)
    {
        _numbers.Add(num);
    }

    // Define a public method "Summarise" which calls the "PrintSummary" method of "_strategy" object and passes "_numbers" list as input
    public void Summarise()
    {
        _strategy.PrintSummary(_numbers);
    }

    // Define a public property "Strategy" which allows getting and setting the "_strategy" object
    public SummaryStrategy Strategy
    {
        get { return _strategy; }
        set { _strategy = value; }
    }

}
