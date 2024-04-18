using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Abstract class for summarizing data.
public abstract class SummaryStrategy
{
    public abstract void PrintSummary(List<int> numbers);
}