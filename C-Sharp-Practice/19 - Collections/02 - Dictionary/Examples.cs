namespace C_Sharp_Practice.Collections.Dictionary;

/*
 * TOPIC: Collections / Dictionary
 *
 * TOPIC DEFINITION
 * Dictionary<TKey, TValue> is a hash-indexed associative container with unique key identity.
 * The topic covers safe lookup, update semantics, key removal, and traversal over key-value entries.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - SafeLookup: Defines operational semantics for Safe Lookup, including valid inputs, internal behavior, and deterministic output expectations.
 * - UpdateValueExample: Defines operational semantics for Update Value Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - RemoveKeyExample: Defines state-reduction semantics for Remove Key Example, including post-operation consistency requirements.
 * - IterateExample: Defines operational semantics for Iterate Example, including valid inputs, internal behavior, and deterministic output expectations.
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
    // Demonstrates the core usage pattern for this topic.
    public static void BasicExample()
    {
        var capitals = new Dictionary<string, string>
        {
            ["France"] = "Paris",
            ["Japan"] = "Tokyo"
        };
        Console.WriteLine(capitals["France"]);
    }

    // Demonstrates safe key lookup with TryGetValue.
    public static void SafeLookup()
    {
        var ages = new Dictionary<string, int> { ["Ana"] = 22, ["Bob"] = 27 };
        if (ages.TryGetValue("Bob", out int age))
        {
            Console.WriteLine(age);
        }
    }

    // Shows in-place value update for an existing key.
    public static void UpdateValueExample()
    {
        var counts = new Dictionary<string, int> { ["x"] = 1 };
        counts["x"]++;
        Console.WriteLine(counts["x"]);
    }

    // Demonstrates removing entries by key.
    public static void RemoveKeyExample()
    {
        var dict = new Dictionary<int, string> { [1] = "one", [2] = "two" };
        dict.Remove(1);
        Console.WriteLine(dict.Count);
    }

    // Demonstrates iterate example.
    public static void IterateExample()
    {
        var scores = new Dictionary<string, int> { ["A"] = 10, ["B"] = 20 };
        foreach (var pair in scores)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}







