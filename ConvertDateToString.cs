using System.Text;
using BenchmarkDotNet.Attributes;

namespace FastestFilteringMethod;

[MemoryDiagnoser]
public class ConvertDateToString
{
    private DateTime _date = new DateTime(2022,01,01);
    
    [Benchmark]
    public string DateToStringUsingStringInterpolation()
    {
        return $"{_date:yyyy-MM-dd}";
    }
    
    [Benchmark]
    public string DateToStringUsingStringFormat()
    {
        return _date.ToString("yyyy-MM-dd");
    }
    
    [Benchmark]
    public string DateToStringUsingStringConcatenation()
    {
        return _date.Year + "-" + _date.Month + "-" + _date.Day;
    }
    
    [Benchmark]
    public string DateToStringUsingStringBuilder()
    {
        var sb = new StringBuilder();
        sb.Append(_date.Year);
        sb.Append("-");
        sb.Append(_date.Month);
        sb.Append("-");
        sb.Append(_date.Day);
        return sb.ToString();
    }
}