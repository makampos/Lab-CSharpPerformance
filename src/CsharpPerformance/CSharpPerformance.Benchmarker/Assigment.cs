using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class Assigment
{
    [Benchmark()]
    public void PropertyAssigment()
    {
        foreach (var name in new Loops().Heroes)
        {
            var hero = new HeroClass();
            hero.Name = name;
        }
    }
    
    [Benchmark()]
    public void DirectAssigment()
    {
        foreach (var name in new Loops().Heroes)
        {
            var hero = new HeroClass();
            hero.name = name;
        }
    }
}