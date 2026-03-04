namespace C_Sharp_Practice.Pattern_Matching;

/*
 * TOPIC: Pattern Matching
 *
 * TOPIC DEFINITION
 * Pattern matching is a C# language feature that allows a program to
 * check the structure, type, or value of data and execute different
 * logic depending on what pattern the data matches.
 *
 * Instead of writing long chains of if/else statements, pattern
 * matching provides a more expressive and readable way to perform
 * conditional branching.
 *
 * Pattern matching is commonly used with the "is" keyword and the
 * "switch" expression. It can check types, compare values, inspect
 * object properties, evaluate tuples, and even match array structures.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * TypePatternExample
 * Demonstrates a type pattern. The program checks whether a value
 * is of a specific type and captures the value into a variable if
 * the match succeeds.
 *
 * RelationalPatternExample
 * Demonstrates relational patterns in a switch expression. These
 * patterns compare numeric values using relational operators such
 * as >, <, >=, and <=.
 *
 * PropertyPatternExample
 * Demonstrates property patterns, which inspect object properties
 * to determine whether a condition is satisfied.
 *
 * TuplePatternExample
 * Demonstrates matching patterns against tuples. Tuple patterns
 * allow multiple values to be evaluated together in a single switch
 * expression.
 *
 * ListPatternExample
 * Demonstrates list patterns introduced in modern C#. List patterns
 * allow arrays or collections to be matched based on their structure
 * or starting elements.
 *
 * INTERNAL MECHANICS
 * - Pattern matching evaluates whether a value satisfies a given pattern.
 * - If the pattern matches, the corresponding branch of code is executed.
 * - Patterns can check types, values, object properties, and collection shapes.
 *
 * TERMINOLOGY
 *
 * Pattern
 * A rule that describes what structure or value should match.
 *
 * Type Pattern
 * A pattern that checks whether a value is a specific type.
 *
 * Relational Pattern
 * A pattern that compares values using relational operators.
 *
 * Property Pattern
 * A pattern that checks object properties for specific values.
 *
 * Tuple Pattern
 * A pattern that matches multiple values grouped as a tuple.
 *
 * List Pattern
 * A pattern that matches arrays or collections based on their elements.
 */

public static class Examples
{
    // Demonstrates type pattern with variable capture.
    public static void TypePatternExample(object input)
    {
        if (input is int number)
        {
            Console.WriteLine(number * 2);
        }
    }

    // Shows switch expression with relational patterns.
    public static void RelationalPatternExample(int score)
    {
        string grade = score switch
        {
            >= 90 => "A",
            >= 75 => "B",
            _ => "C"
        };

        Console.WriteLine(grade);
    }

    // Demonstrates property pattern matching.
    public static void PropertyPatternExample(User user)
    {
        string role = user switch
        {
            { IsAdmin: true } => "Admin",
            _ => "User"
        };

        Console.WriteLine(role);
    }

    // Shows tuple pattern matching.
    public static void TuplePatternExample(int x, int y)
    {
        string quadrant = (x, y) switch
        {
            (> 0, > 0) => "Q1",
            (< 0, > 0) => "Q2",
            (< 0, < 0) => "Q3",
            (> 0, < 0) => "Q4",
            _ => "Axis"
        };

        Console.WriteLine(quadrant);
    }

    // Demonstrates list pattern usage.
    public static void ListPatternExample(int[] data)
    {
        string result = data switch
        {
            [1, 2, ..] => "Starts with 1,2",
            _ => "Other"
        };

        Console.WriteLine(result);
    }
}

public class User
{
    public bool IsAdmin { get; set; }
}





