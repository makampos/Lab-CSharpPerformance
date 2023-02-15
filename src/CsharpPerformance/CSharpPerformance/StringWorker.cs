using System.Text;

namespace CSharpPerformance;

public class StringWorker
{
    public string BuildStringBadly(string value)
    {
        for (var i = 0; i < 9; i++)
        {
            value += " " + "test";
        }

        return value;
    }
    
    public string BuildStringBetter(string value)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 9; i++)
        {
            sb.Append(" ");
            sb.Append("test");
        }

        return sb.ToString();
    }

    public (string LastName, string FirstName) NaiveSplitName(string name)
    {
        var commaIndex = name.IndexOf(',');
        var lastName = name.Substring(0, commaIndex);
        var firstName = name.Substring(commaIndex + 2).Trim();

        return (lastName, firstName);
    }

    public (string LastName, string FirstName) SplitSplitName(string name)
    {
        var nameArray = name.Split(',');
        return (nameArray[0].Trim(), nameArray[1].Trim());
    }
    
    public (string LastName, string FirstName) SpanSplitName(string name)
    {
        ReadOnlySpan<char> nameSpan = name.AsSpan();
        
        var lastName = nameSpan.Slice(0, nameSpan.IndexOf(',')).ToString();
        var firstName = nameSpan.Slice(nameSpan.IndexOf(',') + 2).ToString().Trim();

        return (lastName, firstName);
    }
}