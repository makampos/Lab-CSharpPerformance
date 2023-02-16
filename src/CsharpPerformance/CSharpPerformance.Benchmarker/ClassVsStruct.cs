using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class ClassVsStruct
{
    public string[] Names => new Loops().Heroes;

    [Benchmark()]
    public void ThousandClasses()
    {
        var classes = Names.Select(x => new HeroClass { Name = x }).ToArray();
        for (int i = 0; i < classes.Count(); i++)
        {
            var x = classes.ElementAt(i).Name;
        }
    }
    
    [Benchmark()]
    public void ThousandStructs()
    {
        var structs = Names.Select(x => new HeroStruct() { Name = x }).ToArray();
        for (int i = 0; i < structs.Count(); i++)
        {
            var x = structs.ElementAt(i).Name;
        }
    }
    
    [Benchmark()]
    public void ThousandHeroRecord()
    {
        var records = Names.Select(x => new HeroRecord (x)).ToArray();
        for (int i = 0; i < records.Count(); i++)
        {
            var x = records.ElementAt(i).Name;
        }
    }
    
    [Benchmark()]
    public void ThousandHeroRecordStruct()
    {
        var recordStructs = Names.Select(x => new HeroRecordStruct(x)).ToArray();
        for (int i = 0; i < recordStructs.Count(); i++)
        {
            var x = recordStructs.ElementAt(i).Name;
        }
    }
}

public struct HeroStruct
{
    public string Name { get; set; }
};

public class HeroClass
{
    public string name;
    public string Name { get; set; }
}

public record HeroRecord(string Name);

public record struct HeroRecordStruct(string Name);