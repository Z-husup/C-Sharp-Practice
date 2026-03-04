namespace C_Sharp_Practice.Recursion;

/*
 * TOPIC: Recursion
 *
 * TOPIC DEFINITION
 * Recursion models computation through self-reference over progressively smaller subproblems.
 * This topic covers base-case design, termination guarantees, and recursive function families such as factorial and Fibonacci.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 * - Factorial: Defines operational semantics for Factorial, including valid inputs, internal behavior, and deterministic output expectations.
 * - Fibonacci: Defines operational semantics for Fibonacci, including valid inputs, internal behavior, and deterministic output expectations.
 * - SumToN: Defines operational semantics for Sum To N, including valid inputs, internal behavior, and deterministic output expectations.
 * - Countdown: Defines operational semantics for Countdown, including valid inputs, internal behavior, and deterministic output expectations.
 * - Power: Defines operational semantics for Power, including valid inputs, internal behavior, and deterministic output expectations.
 *
 * INTERNAL MECHANICS
 * - Runtime behavior is governed by explicit language and library contracts.
 * - Boundary and edge-case handling are integral to correctness guarantees.
 *
 * TERMINOLOGY
 * - Definition: Formal statement of topic scope and meaning.
 * - Mechanism: Internal process responsible for observable behavior.
 * - Constraint: Condition limiting valid usage or input.
 * - Guarantee: Property preserved under documented preconditions.
 * - Edge case: Valid but uncommon scenario requiring explicit handling.
 */

public static class Examples
{
    // Computes factorial recursively with a base case.
    public static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // Computes Fibonacci recursively (educational baseline).
    public static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Recursively sums integers from 1 to n.
    public static int SumToN(int n)
    {
        if (n <= 0) return 0;
        return n + SumToN(n - 1);
    }

    // Shows reverse iteration with a for loop.
    public static void Countdown(int n)
    {
        if (n < 0) return;
        Console.WriteLine(n);
        Countdown(n - 1);
    }

    // Computes exponentiation through recursive multiplication.
    public static int Power(int a, int b)
    {
        if (b == 0) return 1;
        return a * Power(a, b - 1);
    }
}







