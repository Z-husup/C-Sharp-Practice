namespace C_Sharp_Practice.Data_Types;

/*
 * TOPIC: Data Types
 *
 * TOPIC DEFINITION
 * A data type defines what kind of value a variable can store and what
 * operations can be performed on that value. In C#, every variable has a
 * specific data type such as int, double, bool, or string. The data type
 * determines the size of the value in memory, the range of possible values,
 * and the behavior of operations performed on that value.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * PrimitiveTypes
 * Primitive (built-in) types are the basic data types provided by the C#
 * language. These include numeric types (int, double), logical types (bool),
 * and character types (char). They are used to store simple values and are
 * commonly used as the building blocks for more complex programs.
 *
 * NullableExample
 * Normally, value types such as int or double cannot contain null.
 * Nullable types allow a value type to also represent the absence of a value.
 * In C#, this is written using the ? symbol (for example: int?).
 * The null-coalescing operator (??) can be used to provide a fallback value
 * if the variable is null.
 *
 * DecimalVsDoubleExample
 * Both double and decimal store numbers with fractional parts, but they are
 * designed for different purposes. Double is a floating-point type that is
 * optimized for scientific and performance-critical calculations. Decimal
 * provides higher precision and is commonly used for financial calculations
 * where rounding errors must be minimized.
 *
 * TypeInferenceExample
 * C# supports type inference using the keyword 'var'. When 'var' is used,
 * the compiler automatically determines the variable's data type from the
 * assigned value. The type is still fixed at compile time and cannot change
 * later.
 *
 * EnumExample
 * An enumeration (enum) is a special data type that defines a set of named
 * constant values. Enums are useful for representing a fixed group of related
 * values, such as days of the week, states, or categories. Using enums
 * improves code readability and prevents invalid values.
 *
 * INTERNAL MECHANICS
 * - Each variable stores a value according to its data type.
 * - Value types store their data directly, while reference types store
 *   references to objects in memory.
 * - Nullable types wrap value types to allow a null state.
 * - The compiler determines inferred types when 'var' is used.
 *
 * TERMINOLOGY
 * Data Type: A classification that specifies what kind of value a variable holds.
 * Primitive Type: A basic built-in data type provided by the language.
 * Nullable Type: A value type that can also represent null.
 * Floating-Point Type: A type used to store real numbers with fractional parts.
 * Enumeration (Enum): A data type that represents a set of named constants.
 */

public static class Examples
{
    // Shows declaration of common primitive data types.
    public static void PrimitiveTypes()
    {
        int age = 25;
        double height = 1.82;
        bool isLearning = true;
        char level = 'A';
        Console.WriteLine($"{age}, {height}, {isLearning}, {level}");
    }

    // Demonstrates nullable value handling and fallback values.
    public static void NullableExample()
    {
        int? maybeNumber = null;
        Console.WriteLine(maybeNumber ?? -1);
    }

    // Compares floating-point and decimal precision behavior.
    public static void DecimalVsDoubleExample()
    {
        double d = 0.1 + 0.2;
        decimal m = 0.1m + 0.2m;
        Console.WriteLine($"double={d}, decimal={m}");
    }

    // Shows compile-time type inference with var.
    public static void TypeInferenceExample()
    {
        var count = 12;
        Console.WriteLine(count.GetType().Name);
    }

    // Demonstrates enum declaration and usage.
    public static void EnumExample()
    {
        Day day = Day.Monday;
        Console.WriteLine(day);
    }

    private enum Day { Monday, Tuesday }
}







