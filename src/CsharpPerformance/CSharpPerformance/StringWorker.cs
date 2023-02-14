using System.Text;

namespace CSharpPerformance;

public class StringWorker
{
    public string BuildStringBadly(string value)
    {
        for (var i = 0; i < 50; i++)
        {
            value += " " + "test";
        }

        return value;
    }
    
    public string BuildStringBetter(string value)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 50; i++)
        {
            sb.Append(" ");
            sb.Append("test");
        }

        return sb.ToString();
    }
}