namespace DotNet9Demo;

/// <summary>
/// This code is taken from Microsoft GitHub
/// </summary>
internal static class TaskWhenEachMethodDemo
{
    public async static Task TaskWhenEach()
    {
        using HttpClient http = new();

        Task<string> dotnet = http.GetStringAsync("http://dot.net");
        Task<string> bing = http.GetStringAsync("http://www.bing.com");
        Task<string> ms = http.GetStringAsync("http://microsoft.com");

        await foreach (Task<string> t in Task.WhenEach(bing, dotnet, ms))
        {
            Console.WriteLine(t.Result);
        }        
    }
}

