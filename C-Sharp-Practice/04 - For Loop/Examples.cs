namespace C_Sharp_Practice.For_Loop;

/*
 * TOPIC: For Loop
 *
 * TOPIC DEFINITION
 * A for loop is a control flow statement used to repeat a block of code a
 * specific number of times. It is commonly used when the number of iterations
 * is known in advance. A for loop consists of three main parts:
 * initialization, condition, and iteration step.
 *
 * The general structure is:
 * for (initialization; condition; iteration)
 * {
 *     // code executed each loop
 * }
 *
 * - Initialization runs once at the beginning.
 * - The condition is evaluated before each iteration.
 * - The iteration step runs after each loop cycle.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * CountUp
 * Demonstrates a basic for loop that counts upward from a starting value
 * to an ending value. This is the most common use of a for loop.
 *
 * CountDown
 * Shows how a for loop can count backwards by decreasing the loop variable
 * on each iteration.
 *
 * StepByTwo
 * Demonstrates how the iteration step can change by more than one unit.
 * This example increments the loop variable by 2 each time.
 *
 * NestedLoopExample
 * A nested loop is a loop placed inside another loop. The inner loop
 * completes all of its iterations for every iteration of the outer loop.
 * Nested loops are often used for working with tables, grids, or matrices.
 *
 * BreakContinueExample
 * The break and continue statements modify loop execution:
 * - break immediately stops the loop.
 * - continue skips the rest of the current iteration and moves to the next one.
 *
 * INTERNAL MECHANICS
 * - The initialization statement runs once before the loop starts.
 * - The condition determines whether the loop continues running.
 * - After each iteration, the iteration step updates the loop variable.
 * - The loop stops when the condition becomes false.
 *
 * TERMINOLOGY
 * Loop: A structure that repeats a block of code multiple times.
 * Iteration: One execution cycle of a loop.
 * Loop Variable: A variable that controls how many times the loop runs.
 * Nested Loop: A loop placed inside another loop.
 * Break: A statement that immediately terminates the loop.
 * Continue: A statement that skips the remainder of the current iteration.
 */

public static class Examples
{
    // Shows forward iteration with a for loop.
    public static void CountUp()
    {
        for (int i = 1; i <= 5; i++) Console.WriteLine(i);
    }

    // Shows reverse iteration with a for loop.
    public static void CountDown()
    {
        for (int i = 5; i >= 1; i--) Console.WriteLine(i);
    }

    // Demonstrates custom step increments in loop iteration.
    public static void StepByTwo()
    {
        for (int i = 0; i <= 10; i += 2) Console.WriteLine(i);
    }

    // Shows nested loops for grid/table-style traversal.
    public static void NestedLoopExample()
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"({i},{j}) ");
            }
            Console.WriteLine();
        }
    }

    // Demonstrates loop flow control with break and continue.
    public static void BreakContinueExample()
    {
        for (int i = 1; i <= 6; i++)
        {
            if (i == 2) continue;
            if (i == 5) break;
            Console.WriteLine(i);
        }
    }
}







