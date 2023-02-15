using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class StringComparison
{
    private readonly string _value = "Mussum Ipsum, cacilds vidis litro abertis. Não sou faixa preta cumpadi, sou preto inteiris, inteiris.Paisis, filhis, espiritis santis.A ordem dos tratores não altera o pão duris.Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis.";
    
    [Benchmark()]
    public void EqualityComparison()
    {
        var compare = _value == "Mussum Ipsum, cacilds vidis litro abertis. Paisis, filhis, espiritis santis.Viva Forevis aptent taciti sociosqu ad litora torquent.Si num tem leite então bota uma pinga aí cumpadi!Copo furadis é disculpa de bebadis, arcu quam euismod magna.";
    }
    
    [Benchmark()]
    public void EqualsComparison()
    {
        var compare = _value.Equals("Mussum Ipsum, cacilds vidis litro abertis. Paisis, filhis, espiritis santis.Viva Forevis aptent taciti sociosqu ad litora torquent.Si num tem leite então bota uma pinga aí cumpadi!Copo furadis é disculpa de bebadis, arcu quam euismod magna.");
    }
    
    [Benchmark()]
    public void StringCompareComparison()
    {
        var compare = String.Compare(_value, "Mussum Ipsum, cacilds vidis litro abertis. Paisis, filhis, espiritis santis.Viva Forevis aptent taciti sociosqu ad litora torquent.Si num tem leite então bota uma pinga aí cumpadi!Copo furadis é disculpa de bebadis, arcu quam euismod magna.");
    }
    
    
}