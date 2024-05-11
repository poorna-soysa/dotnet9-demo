namespace DotNet9Demo;
public static class TimeSpanDemo
{
    public static void BeforeDotNet9()
    {
        TimeSpan timeSpan1 = TimeSpan.FromSeconds(value: 101.832);
        Console.WriteLine($"timeSpan1 (double overload) = {timeSpan1}");
    }

    public static void NewTimeSpanOverloadInDotNet9()
    {
        // New Overloads
        TimeSpan timeSpan2 = TimeSpan.FromSeconds(seconds: 101, milliseconds: 832);
        Console.WriteLine($"timeSpan2 (new long overload) = {timeSpan2}");
    }
}
