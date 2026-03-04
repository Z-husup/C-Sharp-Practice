namespace C_Sharp_Practice.Collections.ConcurrentDictionary;

/*
 * TOPIC: Collections / ConcurrentDictionary
 *
 * TOPIC DEFINITION
 * ConcurrentDictionary<TKey, TValue> provides thread-safe associative storage with atomic update APIs.
 * This topic includes GetOrAdd, AddOrUpdate, TryRemove, and lock-free read patterns.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - GetOrAddExample: Defines state-expansion semantics for Get Or Add Example, including mutation invariants and resulting structure state.
 * - AddOrUpdateExample: Defines state-expansion semantics for Add Or Update Example, including mutation invariants and resulting structure state.
 * - TryRemoveExample: Defines failure-path semantics for Try Remove Example, including error signaling, handling strategy, and recovery boundaries.
 * - TryGetValueExample: Defines failure-path semantics for Try Get Value Example, including error signaling, handling strategy, and recovery boundaries.
 *
 * INTERNAL MECHANICS
 * - Operation complexity is determined by the selected storage model and mutation pattern.
 * - Equality and ordering comparers directly influence correctness and retrieval behavior.
 * - Mutation operations must preserve structure-specific invariants after every update.
 *
 * TERMINOLOGY
 * - Invariant: Condition that remains true after each valid operation.
 * - Amortized complexity: Average cost across many operations where occasional expensive steps are distributed.
 * - Comparer: Object that defines equality or ordering semantics.
 * - Rehash: Redistribution of hashed entries into a resized bucket structure.
 * - Enumeration contract: Rules for traversal order and behavior under mutation.
 */

public static class Examples
{
    // Demonstrates thread-safe insertion and retrieval.
    public static void BasicExample()
    {
        var dict = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();
        dict["a"] = 1;
        Console.WriteLine(dict["a"]);
    }

    // Shows GetOrAdd for atomic initialize-if-missing.
    public static void GetOrAddExample()
    {
        var dict = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();
        int value = dict.GetOrAdd("hits", 0);
        Console.WriteLine(value);
    }

    // Demonstrates AddOrUpdate for atomic write logic.
    public static void AddOrUpdateExample()
    {
        var dict = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();
        dict.AddOrUpdate("count", 1, (_, old) => old + 1);
        dict.AddOrUpdate("count", 1, (_, old) => old + 1);
        Console.WriteLine(dict["count"]);
    }

    // Demonstrates thread-safe removal pattern.
    public static void TryRemoveExample()
    {
        var dict = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();
        dict["x"] = 5;
        Console.WriteLine(dict.TryRemove("x", out int removed) ? removed : -1);
    }

    // Shows safe lookup without exceptions.
    public static void TryGetValueExample()
    {
        var dict = new System.Collections.Concurrent.ConcurrentDictionary<int, string>();
        dict[1] = "one";
        Console.WriteLine(dict.TryGetValue(1, out string? value) ? value : "missing");
    }
}






