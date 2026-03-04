namespace C_Sharp_Practice.Collections.HashSet;

/*
 * TOPIC: Collections / HashSet
 *
 * TOPIC DEFINITION
 * HashSet<T> is a uniqueness-focused hash container for membership and set algebra operations.
 * This topic includes union, intersection, membership testing, and uniqueness invariants under insertion.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ContainsExample: Defines operational semantics for Contains Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - UnionExample: Defines operational semantics for Union Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - IntersectExample: Defines state-reduction semantics for Intersect Example, including post-operation consistency requirements.
 * - RemoveExample: Defines state-reduction semantics for Remove Example, including post-operation consistency requirements.
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
    // Demonstrates add behavior and duplicate rejection.
    public static void BasicExample()
    {
        var set = new System.Collections.Generic.HashSet<int> { 1, 2, 2, 3 };
        Console.WriteLine(set.Count);
    }

    // Shows fast membership test with Contains.
    public static void ContainsExample()
    {
        var set = new System.Collections.Generic.HashSet<string> { "a", "b", "c" };
        Console.WriteLine(set.Contains("b"));
    }

    // Demonstrates union of two sets.
    public static void UnionExample()
    {
        var a = new System.Collections.Generic.HashSet<int> { 1, 2, 3 };
        a.UnionWith([3, 4, 5]);
        Console.WriteLine(string.Join(",", a.OrderBy(x => x)));
    }

    // Demonstrates intersection of two sets.
    public static void IntersectExample()
    {
        var a = new System.Collections.Generic.HashSet<int> { 1, 2, 3 };
        a.IntersectWith([2, 3, 4]);
        Console.WriteLine(string.Join(",", a));
    }

    // Demonstrates removal of values from a set.
    public static void RemoveExample()
    {
        var set = new System.Collections.Generic.HashSet<int> { 1, 2, 3 };
        set.Remove(2);
        Console.WriteLine(string.Join(",", set));
    }
}






