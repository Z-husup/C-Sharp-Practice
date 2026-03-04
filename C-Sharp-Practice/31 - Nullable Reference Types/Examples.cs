namespace C_Sharp_Practice.Nullable_Reference_Types;

/*
 * TOPIC: Nullable Reference Types
 *
 * TOPIC DEFINITION
 * Nullable reference types are a feature introduced in modern C#
 * to help developers avoid null reference errors.
 *
 * Traditionally, reference variables in C# could contain either an
 * object reference or the value null. This sometimes led to runtime
 * exceptions when code attempted to access members of a null object.
 *
 * Nullable reference types add compile-time checks that warn the
 * developer when a variable might be null. Developers can explicitly
 * indicate whether a reference variable is allowed to be null by using
 * nullable annotations.
 *
 * A type declared with ? (for example string?) indicates that the
 * variable may contain null. A reference type declared without ?
 * indicates that it is expected to always contain a valid object.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * NullableDeclarationExample
 * Demonstrates declaring a nullable reference type. The variable
 * can contain either a string value or null.
 *
 * GuardClauseExample
 * Demonstrates a guard clause that validates input before continuing
 * execution. Guard clauses are commonly used to ensure that values
 * are not null before accessing their members.
 *
 * NullCoalescingExample
 * Demonstrates the null-coalescing operator (??). This operator
 * provides a fallback value when a variable is null.
 *
 * NullConditionalExample
 * Demonstrates the null-conditional operator (?.). This operator
 * safely accesses members of an object only if the object is not null.
 * If the object is null, the expression returns null instead of
 * throwing an exception.
 *
 * NullForgivingExample
 * Demonstrates the null-forgiving operator (!). This operator tells
 * the compiler that the developer is certain the value is not null,
 * even if the compiler cannot prove it.
 *
 * INTERNAL MECHANICS
 * - Nullable reference types enable additional compiler warnings.
 * - These checks occur at compile time and do not change runtime behavior.
 * - Developers use operators such as ?? and ?. to safely work with
 *   possibly null values.
 *
 * TERMINOLOGY
 *
 * Nullable Reference
 * A reference type that is explicitly allowed to contain null.
 *
 * Null Reference
 * A reference that does not point to any object.
 *
 * Guard Clause
 * A conditional check that exits a method early when invalid input
 * is detected.
 *
 * Null-Coalescing Operator (??)
 * An operator that provides a default value when a variable is null.
 *
 * Null-Conditional Operator (?.)
 * An operator that safely accesses members of an object that may be null.
 */

public static class Examples
{
    // Demonstrates nullable reference declaration.
    public static void NullableDeclarationExample()
    {
        string? name = null;
        Console.WriteLine(name ?? "unknown");
    }

    // Shows guard clause for non-null enforcement.
    public static void GuardClauseExample()
    {
        Console.WriteLine(GetLength("abc"));
    }

    // Demonstrates null-coalescing operator usage.
    public static void NullCoalescingExample()
    {
        string? text = null;
        string output = text ?? "fallback";
        Console.WriteLine(output);
    }

    // Shows null-conditional access.
    public static void NullConditionalExample()
    {
        Person? person = null;
        Console.WriteLine(person?.Name ?? "none");
    }

    // Demonstrates null-forgiving operator in controlled cases.
    public static void NullForgivingExample()
    {
        string? value = "safe";
        Console.WriteLine(value!.Length);
    }

    private static int GetLength(string? value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        return value.Length;
    }
}

public class Person
{
    public string Name { get; set; } = "Ana";
}






