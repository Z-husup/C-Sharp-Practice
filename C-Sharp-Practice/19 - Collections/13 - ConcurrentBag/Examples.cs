namespace C_Sharp_Practice.Collections.ConcurrentBag;

/*
 * TOPIC: Collections / ConcurrentBag
 *
 * TOPIC DEFINITION
 * ConcurrentBag<T> is a thread-safe unordered accumulation structure optimized for parallel workloads.
 * This topic covers add, take, peek, parallel population, and unordered iteration behavior.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - TryPeekExample: Defines failure-path semantics for Try Peek Example, including error signaling, handling strategy, and recovery boundaries.
 * - CountExample: Defines operational semantics for Count Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ParallelAddExample: Defines state-expansion semantics for Parallel Add Example, including mutation invariants and resulting structure state.
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
    // Demonstrates adding and taking items from a concurrent bag.
    public static void BasicExample()
    {
        var bag = new System.Collections.Concurrent.ConcurrentBag<int>();
        bag.Add(1);
        bag.Add(2);
        bag.TryTake(out int value);
        Console.WriteLine(value);
    }

    // Shows safe item inspection.
    public static void TryPeekExample()
    {
        var bag = new System.Collections.Concurrent.ConcurrentBag<string>();
        bag.Add("A");
        Console.WriteLine(bag.TryPeek(out string? value) ? value : "none");
    }

    // Demonstrates count access.
    public static void CountExample()
    {
        var bag = new System.Collections.Concurrent.ConcurrentBag<int>([1, 2, 3]);
        Console.WriteLine(bag.Count);
    }

    // Demonstrates parallel inserts.
    public static void ParallelAddExample()
    {
        var bag = new System.Collections.Concurrent.ConcurrentBag<int>();
        Parallel.For(0, 100, i => bag.Add(i));
        Console.WriteLine(bag.Count);
    }

    // Demonstrates enumeration of unordered contents.
    public static void IterateExample()
    {
        var bag = new System.Collections.Concurrent.ConcurrentBag<int>([1, 2, 3]);
        Console.WriteLine(string.Join(",", bag));
    }
}






