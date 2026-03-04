namespace C_Sharp_Practice.Collections.PriorityQueue;

/*
 * TOPIC: Collections / PriorityQueue
 *
 * TOPIC DEFINITION
 * PriorityQueue<TElement, TPriority> retrieves elements according to priority ordering, not insertion ordering.
 * This topic covers enqueue priority, dequeue semantics, peeking, and queue clearing.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - CountExample: Defines operational semantics for Count Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - TryDequeueExample: Defines failure-path semantics for Try Dequeue Example, including error signaling, handling strategy, and recovery boundaries.
 * - PeekExample: Defines operational semantics for Peek Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ClearExample: Defines state-reduction semantics for Clear Example, including post-operation consistency requirements.
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
    // Demonstrates priority-based dequeue order.
    public static void BasicExample()
    {
        var pq = new System.Collections.Generic.PriorityQueue<string, int>();
        pq.Enqueue("low", 5);
        pq.Enqueue("high", 1);
        Console.WriteLine(pq.Dequeue());
    }

    // Shows how to inspect current count.
    public static void CountExample()
    {
        var pq = new System.Collections.Generic.PriorityQueue<int, int>();
        pq.Enqueue(1, 10);
        pq.Enqueue(2, 5);
        Console.WriteLine(pq.Count);
    }

    // Demonstrates TryDequeue for safe removal.
    public static void TryDequeueExample()
    {
        var pq = new System.Collections.Generic.PriorityQueue<string, int>();
        pq.Enqueue("task", 2);
        if (pq.TryDequeue(out string? element, out int priority))
        {
            Console.WriteLine($"{element}:{priority}");
        }
    }

    // Demonstrates peeking next prioritized element.
    public static void PeekExample()
    {
        var pq = new System.Collections.Generic.PriorityQueue<string, int>();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 1);
        Console.WriteLine(pq.Peek());
    }

    // Shows clearing all queued items.
    public static void ClearExample()
    {
        var pq = new System.Collections.Generic.PriorityQueue<int, int>();
        pq.Enqueue(1, 1);
        pq.Clear();
        Console.WriteLine(pq.Count);
    }
}






