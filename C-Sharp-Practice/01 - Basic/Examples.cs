namespace C_Sharp_Practice.Basic;


/*
 * TOPIC: Basic C# Concepts
 *
 * TOPIC DEFINITION
 * Basic C# concepts describe the fundamental elements of the C# programming language.
 * These include variables, constants, data types, type conversion, and simple input/output.
 * Understanding these elements is necessary before working with more advanced topics
 * such as classes, collections, or asynchronous programming.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * VariablesAndOutput
 * A variable is a named storage location used to hold a value in memory.
 * In C#, variables must have a declared data type that determines the kind of
 * data they can store (for example, int, string, or double).
 * Console output allows a program to display information to the user using
 * methods such as Console.WriteLine().
 *
 * TypeConversion
 * Type conversion is the process of converting a value from one data type to another.
 * In this example, a string that represents a number is converted into an integer
 * using int.Parse(). This allows the program to perform numerical operations
 * on values that originally come from text input.
 *
 * ConstantsExample
 * A constant is a value that cannot be changed after it has been assigned.
 * In C#, constants are declared using the keyword 'const'.
 * Constants are commonly used for fixed values such as mathematical constants
 * or configuration values that should never be modified during program execution.
 *
 * StringInterpolationExample
 * String interpolation is a convenient way to insert variable values into a string.
 * It is written using the $ symbol before the string and placing variables
 * inside curly braces {}. This makes formatted output easier to read and write.
 *
 * TryParseExample
 * TryParse is a safe method used to convert text into a numeric value without
 * causing an exception if the conversion fails.
 * Instead of throwing an error, TryParse returns a boolean value:
 * - true if the conversion was successful
 * - false if the text could not be converted
 * The converted value is returned through the 'out' parameter.
 *
 * INTERNAL MECHANICS
 * - Variables store values in memory during program execution.
 * - Methods from the Console class allow programs to interact with the user
 *   through the terminal.
 * - Conversion methods transform data between compatible types.
 * - Error-safe parsing methods such as TryParse prevent runtime exceptions
 *   when input data may be invalid.
 *
 * TERMINOLOGY
 * Variable: A named memory location used to store a value.
 * Data Type: A classification that determines the kind of value a variable can hold.
 * Constant: A value that cannot change during program execution.
 * Type Conversion: Converting a value from one data type to another.
 * Parsing: Interpreting text and converting it into another data type.
 */


public static class Examples
{
    // Shows variable declaration and formatted console output.
    public static void VariablesAndOutput()
    {
        string language = "C#";
        int year = 2026;
        Console.WriteLine($"Learning {language} in {year}");
    }

    // Demonstrates converting string input into numeric values.
    public static void TypeConversion()
    {
        string textNumber = "42";
        int parsed = int.Parse(textNumber);
        Console.WriteLine(parsed + 8);
    }

    // Shows how to define and use immutable constants.
    public static void ConstantsExample()
    {
        const double Pi = 3.14159;
        Console.WriteLine(Pi);
    }

    // Demonstrates string interpolation for readable formatting.
    public static void StringInterpolationExample()
    {
        string name = "Jo";
        int age = 21;
        Console.WriteLine($"{name} is {age}");
    }

    // Shows safe parsing without throwing exceptions.
    public static void TryParseExample()
    {
        bool ok = int.TryParse("100", out int number);
        Console.WriteLine($"{ok} {number}");
    }
}







