namespace C_Sharp_Practice.Collections.List;

/*
 * TOPIC: Collections / List
 *
 * TOPIC DEFINITION
 * List<T> is a dynamic contiguous sequence with indexable storage and ordered iteration.
 * This topic explains append growth, indexed insertion cost, removal shifting semantics, and count/capacity distinction.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - InsertExample: Defines state-expansion semantics for Insert Example, including mutation invariants and resulting structure state.
 * - RemoveExample: Defines state-reduction semantics for Remove Example, including post-operation consistency requirements.
 * - RemoveRangeExample: Defines state-reduction semantics for Remove Range Example, including post-operation consistency requirements.
 * - CountCapacityExample: Defines operational semantics for Count Capacity Example, including valid inputs, internal behavior, and deterministic output expectations.
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
        var numbers = new System.Collections.Generic.List<int> { 1, 2, 3 };
        Console.WriteLine(numbers[0]);
    }

    // Shows insertion at a specific index and element shifting.
    public static void InsertExample()
    {
        var numbers = new System.Collections.Generic.List<int> { 1, 2, 3, 4 };
        numbers.Insert(1, 99);
        Console.WriteLine(string.Join(",", numbers));
    }

    // Demonstrates removal and resulting index compaction.
    public static void RemoveExample()
    {
        var numbers = new System.Collections.Generic.List<int> { 1, 2, 3, 4 };
        numbers.RemoveAt(1);
        Console.WriteLine(string.Join(",", numbers));
    }

    // Shows removing a contiguous block of elements.
    public static void RemoveRangeExample()
    {
        var numbers = new System.Collections.Generic.List<int> { 1, 2, 3, 4, 5, 6, 7 };
        numbers.RemoveRange(1, 3);
        Console.WriteLine(string.Join(",", numbers));
    }

    // Compares logical item count with underlying storage capacity.
    public static void CountCapacityExample()
    {
        var list = new System.Collections.Generic.List<int>(10) { 1, 2, 3 };
        Console.WriteLine($"Count={list.Count}, Capacity={list.Capacity}");
    }
}







