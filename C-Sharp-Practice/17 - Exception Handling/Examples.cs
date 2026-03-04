namespace C_Sharp_Practice.Exception_Handling;

/*
 * TOPIC: Exception Handling
 *
 * TOPIC DEFINITION
 * Exception handling in C# is used to detect and manage runtime errors.
 * When a problem occurs during program execution, the runtime throws
 * an exception object that describes the error.
 *
 * By using try, catch, and finally blocks, a program can handle these
 * errors gracefully instead of crashing. Exception handling helps
 * maintain program stability and allows developers to respond to
 * unexpected conditions.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * TryCatchExample
 * Demonstrates the basic use of try and catch. The code inside the
 * try block is executed, and if an exception occurs, the catch block
 * handles the error.
 *
 * MultipleCatchExample
 * Shows how different exception types can be handled separately using
 * multiple catch blocks.
 *
 * FinallyExample
 * Demonstrates the finally block. Code inside finally always runs,
 * whether an exception occurs or not. It is commonly used for cleanup
 * tasks such as closing files or releasing resources.
 *
 * ThrowExample
 * Demonstrates explicitly throwing an exception using the throw keyword.
 * This is often used when validating input or detecting invalid program
 * states.
 *
 * CustomMessageExample
 * Shows how to create an exception with a custom message that explains
 * the reason for the error.
 *
 * INTERNAL MECHANICS
 * - When an error occurs, the runtime creates an exception object.
 * - The program searches for a matching catch block to handle the exception.
 * - If no handler is found, the exception propagates up the call stack.
 * - The finally block runs regardless of whether an exception occurred.
 *
 * TERMINOLOGY
 * Exception: An object that represents a runtime error.
 * Try Block: A section of code that may throw an exception.
 * Catch Block: A block that handles a specific type of exception.
 * Finally Block: Code that always executes after try/catch.
 * Throw: A keyword used to create and raise an exception.
 */

public static class Examples
{
    // Shows basic exception handling with try and catch.
    public static void TryCatchExample()
    {
        try
        {
            Console.WriteLine(10 / int.Parse("0"));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Demonstrates handling different exception types separately.
    public static void MultipleCatchExample()
    {
        try
        {
            _ = int.Parse("abc");
        }
        catch (FormatException)
        {
            Console.WriteLine("Format error");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow error");
        }
    }

    // Shows cleanup logic that always runs via finally.
    public static void FinallyExample()
    {
        try
        {
            Console.WriteLine("Try");
        }
        finally
        {
            Console.WriteLine("Finally always runs");
        }
    }

    // Demonstrates explicit validation and exception throwing.
    public static void ThrowExample()
    {
        try
        {
            ValidateAge(-1);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.ParamName);
        }
    }

    // Shows throwing domain-relevant error messages.
    public static void CustomMessageExample()
    {
        try
        {
            throw new InvalidOperationException("Business rule violated");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ValidateAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(age));
        }
    }
}