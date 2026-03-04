namespace C_Sharp_Practice.Function;

/*
 * TOPIC: Methods (Functions)
 *
 * TOPIC DEFINITION
 * A method (also called a function in many programming languages) is a block
 * of code that performs a specific task. Methods allow programs to organize
 * logic into reusable units, making code easier to read, maintain, and reuse.
 *
 * A method can:
 * - receive input values through parameters
 * - perform some operations
 * - optionally return a result
 *
 * Methods are defined once and can be called many times from different parts
 * of a program.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * Add
 * A method that takes two integer parameters and returns their sum.
 * This demonstrates how methods can perform calculations and return values.
 *
 * Greeting
 * Demonstrates a method with an optional parameter. If the caller does not
 * provide a value for the parameter, the default value will be used.
 *
 * Multiply
 * A method that returns the product of two integers. It shows how methods
 * can be used to encapsulate simple mathematical operations.
 *
 * RefExample
 * Demonstrates passing arguments by reference using the 'ref' keyword.
 * When a parameter is passed by reference, the method can modify the
 * original variable that was passed to it.
 *
 * OutExample
 * Demonstrates the use of 'out' parameters. Out parameters allow a method
 * to return multiple values. The method must assign values to the out
 * parameters before it finishes execution.
 *
 * INTERNAL MECHANICS
 * - When a method is called, control temporarily transfers to that method.
 * - Parameters receive the values passed by the caller.
 * - The method executes its instructions.
 * - If the method has a return value, it sends the result back to the caller.
 *
 * TERMINOLOGY
 * Method: A named block of code that performs a specific task.
 * Parameter: A variable used to receive input values in a method.
 * Argument: The actual value passed to a method when it is called.
 * Return Value: The result produced by a method.
 * Pass by Reference (ref): Allows a method to modify the caller's variable.
 * Out Parameter: A parameter used to return additional values from a method.
 */

public static class Examples
{
    // Returns the arithmetic sum of two integers.
    public static int Add(int a, int b) => a + b;

    // Shows optional parameters and simple method calls.
    public static void Greeting(string name = "Student")
    {
        Console.WriteLine($"Hello, {name}");
    }

    // Returns the arithmetic product of two integers.
    public static int Multiply(int a, int b) => a * b;

    // Demonstrates pass-by-reference mutation with ref.
    public static void RefExample()
    {
        int value = 10;
        Increment(ref value);
        Console.WriteLine(value);
    }

    // Demonstrates multi-value output using out parameters.
    public static void OutExample()
    {
        CreatePoint(out int x, out int y);
        Console.WriteLine($"{x},{y}");
    }

    private static void Increment(ref int number) => number++;

    private static void CreatePoint(out int x, out int y)
    {
        x = 3;
        y = 4;
    }
}