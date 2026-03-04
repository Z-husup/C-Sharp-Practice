namespace C_Sharp_Practice.Collections.SortedDictionary;

/*
 * TOPIC: Collections / SortedDictionary
 *
 * TOPIC DEFINITION
 * SortedDictionary<TKey, TValue> is an ordered map with comparer-governed key ordering.
 * This topic covers ordered iteration, key-based retrieval, removal, and safe TryGetValue access.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - LookupExample: Defines operational semantics for Lookup Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - IterateExample: Defines operational semantics for Iterate Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - RemoveExample: Defines state-reduction semantics for Remove Example, including post-operation consistency requirements.
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
    // Demonstrates automatic key ordering.
    public static void BasicExample()
    {
        var dict = new System.Collections.Generic.SortedDictionary<int, string>
        {
            [3] = "C",
            [1] = "A",
            [2] = "B"
        };
        Console.WriteLine(string.Join(",", dict.Keys));
    }

    // Shows value lookup by key.
    public static void LookupExample()
    {
        var dict = new System.Collections.Generic.SortedDictionary<string, int> { ["x"] = 1 };
        Console.WriteLine(dict["x"]);
    }

    // Demonstrates ordered iteration.
    public static void IterateExample()
    {
        var dict = new System.Collections.Generic.SortedDictionary<int, string> { [2] = "B", [1] = "A" };
        foreach (var pair in dict) Console.WriteLine($"{pair.Key}:{pair.Value}");
    }

    // Demonstrates removal by key.
    public static void RemoveExample()
    {
        var dict = new System.Collections.Generic.SortedDictionary<int, string> { [1] = "A", [2] = "B" };
        dict.Remove(2);
        Console.WriteLine(dict.Count);
    }

    // Shows safe retrieval pattern.
    public static void TryGetValueExample()
    {
        var dict = new System.Collections.Generic.SortedDictionary<int, string> { [1] = "A" };
        Console.WriteLine(dict.TryGetValue(1, out string? value) ? value : "missing");
    }
}






