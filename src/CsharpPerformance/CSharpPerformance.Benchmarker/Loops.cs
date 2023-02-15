using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class Loops
{
    string[] heroes = 
    {
        "Spider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler," +
        "Spider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler,pider-Man, Gambit, Wolverine, Cyclops, Storm, Rogue, Nightcrawler, " +
        "Colossus, Iceman, Bishop, Kitty Pryde, Shadowcat, Rogue, Psylocke, Jubilee," +
        " Dazzler, Sunfire, Colossus, Nightcrawler"
    };

    [Benchmark()]
    public void ForLoop()
    {
        var lenght = heroes.Length;
    
        for(var i = 0; i < lenght; i++)
        {
            var x= heroes[i];
        }
    }
    
    [Benchmark()]
    public void ForEachLoop()
    {
        var lenght = heroes.Length;

        foreach (var hero in heroes)
        {
            for(var i = lenght - 1; i >= 0; i--)
            {
                var x= heroes[i];
            }
        }
    }

}