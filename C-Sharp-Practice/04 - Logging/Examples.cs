namespace C_Sharp_Practice.Frameworks_Basics.Logging_Frameworks;

public static class Examples
{
    // Demonstrates level-based logging behavior.
    public static void LevelExample()
    {
        Log("INFO", "Started");
    }

    // Shows structured logging style.
    public static void StructuredExample()
    {
        Console.WriteLine("level=INFO event=OrderPlaced orderId=1");
    }

    // Demonstrates context enrichment idea.
    public static void EnrichmentExample()
    {
        string correlationId = Guid.NewGuid().ToString();
        Console.WriteLine($"corr={correlationId} message=Processing");
    }

    // Shows filtering behavior concept.
    public static void FilteringExample()
    {
        string level = "Debug";
        bool allowed = level != "Debug";
        Console.WriteLine(allowed ? "Logged" : "Filtered");
    }

    // Demonstrates multiple sink concept.
    public static void SinkConceptExample()
    {
        Console.WriteLine("Console + File sinks configured");
    }

    private static void Log(string level, string message)
    {
        Console.WriteLine($"{level}:{message}");
    }
}






