namespace C_Sharp_Practice.Collections.ConcurrentQueue;

/*
 * TOPIC: Collections / ConcurrentQueue
 *
 * TOPIC DEFINITION
 * ConcurrentQueue<T> is a thread-safe FIFO structure for producer-consumer execution contexts.
 * This topic includes TryDequeue, TryPeek, concurrent count observation, and draining.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - TryDequeueExample: Defines failure-path semantics for Try Dequeue Example, including error signaling, handling strategy, and recovery boundaries.
 * - TryPeekExample: Defines failure-path semantics for Try Peek Example, including error signaling, handling strategy, and recovery boundaries.
 * - CountExample: Defines operational semantics for Count Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - DrainExample: Defines state-reduction semantics for Drain Example, including post-operation consistency requirements.
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
    // Demonstrates thread-safe enqueue/dequeue operations.
    public static void BasicExample()
    {
        var queue = new System.Collections.Concurrent.ConcurrentQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.TryDequeue(out int value);
        Console.WriteLine(value);
    }

    // Shows safe dequeue attempt.
    public static void TryDequeueExample()
    {
        var queue = new System.Collections.Concurrent.ConcurrentQueue<string>();
        queue.Enqueue("item");
        Console.WriteLine(queue.TryDequeue(out string? value) ? value : "none");
    }

    // Shows safe peek attempt.
    public static void TryPeekExample()
    {
        var queue = new System.Collections.Concurrent.ConcurrentQueue<int>();
        queue.Enqueue(10);
        Console.WriteLine(queue.TryPeek(out int value) ? value : -1);
    }

    // Demonstrates count observation.
    public static void CountExample()
    {
        var queue = new System.Collections.Concurrent.ConcurrentQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine(queue.Count);
    }

    // Demonstrates draining queued items.
    public static void DrainExample()
    {
        var queue = new System.Collections.Concurrent.ConcurrentQueue<int>([1, 2, 3]);
        while (queue.TryDequeue(out int n))
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}






