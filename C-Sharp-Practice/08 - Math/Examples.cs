namespace C_Sharp_Practice.Math;

/*
 * TOPIC: Math Operations
 *
 * TOPIC DEFINITION
 * Mathematical operations in C# are performed using arithmetic operators
 * and methods provided by the System.Math class. These tools allow programs
 * to perform calculations such as absolute values, powers, square roots,
 * rounding numbers, and trigonometric functions.
 *
 * The System.Math class provides many commonly used mathematical functions
 * that operate primarily on numeric types such as int, double, and decimal.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicMath
 * Demonstrates several common mathematical operations using the System.Math
 * class, including calculating absolute values, powers, and square roots.
 *
 * RoundExample
 * Shows how to round numbers to a specific number of decimal places using
 * Math.Round. Rounding is often used when displaying numeric results.
 *
 * MinMaxExample
 * Demonstrates how to determine the smallest or largest value between
 * two numbers using Math.Min and Math.Max.
 *
 * TrigonometryExample
 * Shows how to use trigonometric functions such as Math.Sin. These functions
 * expect angles in radians rather than degrees.
 *
 * ClampExample
 * Demonstrates how to restrict a value to a specific range using Math.Clamp.
 * If the value is outside the allowed range, it is adjusted to the nearest
 * boundary.
 *
 * INTERNAL MECHANICS
 * - Arithmetic operators perform basic calculations such as addition,
 *   subtraction, multiplication, and division.
 * - The System.Math class provides additional mathematical functions.
 * - Most Math methods operate on double values for precision.
 * - Some operations may introduce rounding errors when using floating-point numbers.
 *
 * TERMINOLOGY
 * Arithmetic Operation: A mathematical calculation such as addition or multiplication.
 * Absolute Value: The non-negative value of a number regardless of its sign.
 * Power: A number raised to an exponent (for example, 2^8).
 * Square Root: A number that, when multiplied by itself, produces the original number.
 * Radians: A unit used to measure angles in trigonometric functions.
 * Clamp: Restricting a value so that it stays within a defined minimum and maximum range.
 */

public static class Examples
{
    // Shows core numeric operations from System.Math.
    public static void BasicMath()
    {
        Console.WriteLine(System.Math.Abs(-15));
        Console.WriteLine(System.Math.Pow(2, 8));
        Console.WriteLine(System.Math.Sqrt(81));
    }

    // Demonstrates numeric rounding for presentation/precision.
    public static void RoundExample()
    {
        Console.WriteLine(System.Math.Round(3.14159, 2));
    }

    // Shows boundary selection with min/max operations.
    public static void MinMaxExample()
    {
        Console.WriteLine(System.Math.Min(4, 9));
        Console.WriteLine(System.Math.Max(4, 9));
    }

    // Demonstrates trigonometric function usage.
    public static void TrigonometryExample()
    {
        double angle = System.Math.PI / 2;
        Console.WriteLine(System.Math.Sin(angle));
    }

    // Shows constraining a value into an allowed range.
    public static void ClampExample()
    {
        int value = 150;
        int clamped = System.Math.Clamp(value, 0, 100);
        Console.WriteLine(clamped);
    }
}