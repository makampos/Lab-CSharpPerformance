namespace CSharpPerformance.Tests;

public class StringTests
{
    [Fact]
    public void BuildStringBadly()
    {
        var s = new StringWorker().BuildStringBadly("test");
        Assert.Equal("test test test test test test test test test test",s);
    }
    
    [Fact]
    public void BuildStringBetter()
    {
        var s = new StringWorker().BuildStringBetter("test");
        Assert.Equal("test test test test test test test test test test",s);
    }
    
    [Fact]
    public void NainveSplitName()
    {
        var name = "Behrens, Chris";
        var worker = new StringWorker();
        
        var lastName = worker.NaiveSplitName(name).LastName;
        var firstName = worker.NaiveSplitName(name).FirstName;
        
        Assert.Equal("Behrens",lastName);
        Assert.Equal("Chris",firstName);
    }
    
    [Fact]
    public void SplitSplitName()
    {
        var name = "Behrens, Chris";
        var worker = new StringWorker();
        
        var lastName = worker.SplitSplitName(name).LastName;
        var firstName = worker.SplitSplitName(name).FirstName;
        
        Assert.Equal("Behrens",lastName);
        Assert.Equal("Chris",firstName);
    }
    
    [Fact]
    public void FunctionalAreEquivalent()
    {
        var name = "Behrens, Chris";
        var worker = new StringWorker();
        
        var lastName = worker.SplitSplitName(name).LastName;
        var firstName = worker.SplitSplitName(name).FirstName;
        
        Assert.Equal("Behrens",lastName);
        Assert.Equal("Chris",firstName);
    }
    
    [Fact]
    public void SpanSplitName()
    {
        var name = "Behrens, Chris";
        var worker = new StringWorker();
        
        var lastName = worker.SpanSplitName(name).LastName;
        var firstName = worker.SpanSplitName(name).FirstName;
        
        Assert.Equal("Behrens",lastName);
        Assert.Equal("Chris",firstName);
    }
    
    
}