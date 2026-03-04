namespace C_Sharp_Practice.Collections.SortedList;

/*
 * TOPIC: Collections / SortedList
 *
 * TOPIC DEFINITION
 * SortedList<TKey, TValue> stores key-value pairs in key order with index-addressable sorted keys and values.
 * This topic covers ordered insertion, key lookup, indexed access, and key existence checks.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - LookupExample: Defines operational semantics for Lookup Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - IndexAccessExample: Defines operational semantics for Index Access Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - RemoveExample: Defines state-reduction semantics for Remove Example, including post-operation consistency requirements.
 * - ContainsKeyExample: Defines operational semantics for Contains Key Example, including valid inputs, internal behavior, and deterministic output expectations.
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
    // Demonstrates sorted insertion by key.
    public static void BasicExample()
    {
        var list = new System.Collections.Generic.SortedList<int, string>
        {
            [3] = "C",
            [1] = "A",
            [2] = "B"
        };
        Console.WriteLine(string.Join(",", list.Keys));
    }

    // Shows key-based retrieval.
    public static void LookupExample()
    {
        var list = new System.Collections.Generic.SortedList<string, int> { ["x"] = 1, ["y"] = 2 };
        Console.WriteLine(list["y"]);
    }

    // Demonstrates index-based access to keys and values.
    public static void IndexAccessExample()
    {
        var list = new System.Collections.Generic.SortedList<int, string> { [2] = "B", [1] = "A" };
        Console.WriteLine($"{list.Keys[0]}:{list.Values[0]}");
    }

    // Demonstrates removal by key.
    public static void RemoveExample()
    {
        var list = new System.Collections.Generic.SortedList<int, string> { [1] = "A", [2] = "B" };
        list.Remove(1);
        Console.WriteLine(list.Count);
    }

    // Shows safe existence checks before retrieval.
    public static void ContainsKeyExample()
    {
        var list = new System.Collections.Generic.SortedList<int, string> { [1] = "A" };
        Console.WriteLine(list.ContainsKey(1));
    }
}






