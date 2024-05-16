namespace DotNet9Demo;

/// <summary>
/// This code is taken from Microsoft GitHub
/// </summary>
internal class LINQAggregateByMethodDemo
{
    public static void AggregateByDotNet9()
    {
        (string id, int score)[] data =
    [
        ("0", 42),
        ("1", 5),
        ("2", 4),
        ("1", 10),
        ("0", 25),
    ];

        var aggregatedData =
            data.AggregateBy(
                keySelector: entry => entry.id,
                seed: 0,
                (totalScore, curr) => totalScore + curr.score
                );

        foreach (var item in aggregatedData)
        {
            Console.WriteLine(item);
        }
        
    }
}
