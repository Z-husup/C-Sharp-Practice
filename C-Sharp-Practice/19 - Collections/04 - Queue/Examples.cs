namespace C_Sharp_Practice.Collections.Queue;

/*
 * TOPIC: Collections / Queue
 *
 * TOPIC DEFINITION
 * Queue<T> enforces first-in-first-out order for sequential consumption workflows.
 * This topic covers enqueue, dequeue, peek, emptiness safety, and queue state transitions.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - PeekExample: Defines operational semantics for Peek Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - CountExample: Defines operational semantics for Count Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ClearExample: Defines state-reduction semantics for Clear Example, including post-operation consistency requirements.
 * - SafeDequeueExample: Defines state-reduction semantics for Safe Dequeue Example, including post-operation consistency requirements.
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
    // Demonstrates FIFO insertion/removal order.
    public static void BasicExample()
    {
        var queue = new System.Collections.Generic.Queue<string>();
        queue.Enqueue("A");
        queue.Enqueue("B");
        Console.WriteLine(queue.Dequeue());
    }

    // Shows how to inspect next item without removal.
    public static void PeekExample()
    {
        var queue = new System.Collections.Generic.Queue<int>([10, 20, 30]);
        Console.WriteLine(queue.Peek());
    }

    // Demonstrates queue size tracking.
    public static void CountExample()
    {
        var queue = new System.Collections.Generic.Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine(queue.Count);
    }

    // Shows removing all elements.
    public static void ClearExample()
    {
        var queue = new System.Collections.Generic.Queue<int>([1, 2, 3]);
        queue.Clear();
        Console.WriteLine(queue.Count);
    }

    // Demonstrates safe dequeue by checking availability first.
    public static void SafeDequeueExample()
    {
        var queue = new System.Collections.Generic.Queue<int>();
        if (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }
}






