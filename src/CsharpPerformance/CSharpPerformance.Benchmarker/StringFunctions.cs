using BenchmarkDotNet.Attributes;

namespace CSharpPerformance.Benchmarker;

public class StringFunctions
{
    [Benchmark()]
    public void BuildStringBadly()
    {
        var x = new StringWorker().BuildStringBadly("test");
    }
    [Benchmark()]
    public void BuildStringBetter()
    {
        var x = new StringWorker().BuildStringBetter("test");
    }
}