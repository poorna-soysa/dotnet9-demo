namespace DotNet9Demo;

/// <summary>
/// This code is taken from Microsoft GitHub
/// </summary>
internal static class LINQCountByMethodDemo
{
    public static void CountByDotNet9()
    {
        string sourceText = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
    Sed non risus. Suspendisse lectus tortor, dignissim sit amet, 
    adipiscing nec, ultricies sed, dolor. Cras elementum ultrices amet diam.
""";

        // Find the most frequent word in the text.
        KeyValuePair<string, int> mostFrequentWord = sourceText
            .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLowerInvariant())
            .CountBy(word => word)
            .MaxBy(pair => pair.Value);

        Console.WriteLine(mostFrequentWord.Key); // amet
    }
}
