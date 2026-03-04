namespace C_Sharp_Practice.Collections.LinkedList;

/*
 * TOPIC: Collections / LinkedList
 *
 * TOPIC DEFINITION
 * LinkedList<T> stores elements as linked nodes rather than contiguous memory indexes.
 * This topic explains node-based insertion and removal around known positions and end-point operations.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - AddFirstExample: Defines state-expansion semantics for Add First Example, including mutation invariants and resulting structure state.
 * - AddLastExample: Defines state-expansion semantics for Add Last Example, including mutation invariants and resulting structure state.
 * - AddAfterExample: Defines state-expansion semantics for Add After Example, including mutation invariants and resulting structure state.
 * - RemoveEndsExample: Defines state-reduction semantics for Remove Ends Example, including post-operation consistency requirements.
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
    // Demonstrates creating linked list and traversal.
    public static void BasicExample()
    {
        var list = new System.Collections.Generic.LinkedList<int>([1, 2, 3]);
        Console.WriteLine(string.Join(",", list));
    }

    // Shows insertion at head.
    public static void AddFirstExample()
    {
        var list = new System.Collections.Generic.LinkedList<int>([2, 3]);
        list.AddFirst(1);
        Console.WriteLine(string.Join(",", list));
    }

    // Shows insertion at tail.
    public static void AddLastExample()
    {
        var list = new System.Collections.Generic.LinkedList<int>([1, 2]);
        list.AddLast(3);
        Console.WriteLine(string.Join(",", list));
    }

    // Demonstrates insertion relative to a known node.
    public static void AddAfterExample()
    {
        var list = new System.Collections.Generic.LinkedList<int>([1, 3]);
        var node = list.Find(1);
        if (node is not null) list.AddAfter(node, 2);
        Console.WriteLine(string.Join(",", list));
    }

    // Demonstrates removing first and last nodes.
    public static void RemoveEndsExample()
    {
        var list = new System.Collections.Generic.LinkedList<int>([1, 2, 3, 4]);
        list.RemoveFirst();
        list.RemoveLast();
        Console.WriteLine(string.Join(",", list));
    }
}






