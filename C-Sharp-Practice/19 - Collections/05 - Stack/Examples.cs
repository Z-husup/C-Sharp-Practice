namespace C_Sharp_Practice.Collections.Stack;

/*
 * TOPIC: Collections / Stack
 *
 * TOPIC DEFINITION
 * Stack<T> enforces last-in-first-out order for reverse retrieval and nested workflow handling.
 * This topic covers push, pop, peek, count tracking, and clear behavior.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - BasicExample: Defines operational semantics for Basic Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - PeekExample: Defines operational semantics for Peek Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - CountExample: Defines operational semantics for Count Example, including valid inputs, internal behavior, and deterministic output expectations.
 * - ClearExample: Defines state-reduction semantics for Clear Example, including post-operation consistency requirements.
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
    // Demonstrates push/pop behavior.
    public static void BasicExample()
    {
        var stack = new System.Collections.Generic.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Pop());
    }

    // Shows non-destructive top inspection.
    public static void PeekExample()
    {
        var stack = new System.Collections.Generic.Stack<string>(["x", "y"]);
        Console.WriteLine(stack.Peek());
    }

    // Demonstrates stack length inspection.
    public static void CountExample()
    {
        var stack = new System.Collections.Generic.Stack<int>([1, 2, 3]);
        Console.WriteLine(stack.Count);
    }

    // Shows clearing all elements.
    public static void ClearExample()
    {
        var stack = new System.Collections.Generic.Stack<int>([1, 2, 3]);
        stack.Clear();
        Console.WriteLine(stack.Count);
    }

    // Demonstrates membership checking in stack contents.
    public static void ContainsExample()
    {
        var stack = new System.Collections.Generic.Stack<int>([1, 2, 3]);
        Console.WriteLine(stack.Contains(2));
    }
}






