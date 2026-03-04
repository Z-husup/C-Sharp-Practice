namespace C_Sharp_Practice.Collections.SortedSet;

/*
 * TOPIC: Collections / SortedSet
 *
 * TOPIC DEFINITION
 * SortedSet<T> is a comparer-ordered unique set that preserves sorted iteration at all times.
 * This topic includes range views, min/max retrieval, and set-difference behavior.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - MinMaxExample: Defines operational semantics for Min Max Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - RangeExample: Defines operational semantics for Range Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ExceptExample: Defines state-reduction semantics for Except Example, including post-operation consistency requirements.
 * - ContainsExample: Defines operational semantics for Contains Example, including valid inputs, internal behavior, and deterministic output expectations.
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
    // Demonstrates automatic ordering and deduplication.
    public static void BasicExample()
    {
        var set = new System.Collections.Generic.SortedSet<int>([5, 1, 3, 3]);
        Console.WriteLine(string.Join(",", set));
    }

    // Shows min and max retrieval.
    public static void MinMaxExample()
    {
        var set = new System.Collections.Generic.SortedSet<int>([7, 2, 9]);
        Console.WriteLine($"Min={set.Min}, Max={set.Max}");
    }

    // Demonstrates range extraction.
    public static void RangeExample()
    {
        var set = new System.Collections.Generic.SortedSet<int>([1, 2, 3, 4, 5, 6]);
        var range = set.GetViewBetween(2, 5);
        Console.WriteLine(string.Join(",", range));
    }

    // Demonstrates set difference.
    public static void ExceptExample()
    {
        var set = new System.Collections.Generic.SortedSet<int>([1, 2, 3, 4]);
        set.ExceptWith([2, 4]);
        Console.WriteLine(string.Join(",", set));
    }

    // Demonstrates membership test in sorted set.
    public static void ContainsExample()
    {
        var set = new System.Collections.Generic.SortedSet<int>([10, 20, 30]);
        Console.WriteLine(set.Contains(20));
    }
}






