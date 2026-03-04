namespace C_Sharp_Practice.Generics;

/*
 * TOPIC: Generics
 *
 * TOPIC DEFINITION
 * Generics allow classes and methods to work with different data types
 * while maintaining compile-time type safety. Instead of writing separate
 * code for each data type, a generic definition uses a type parameter
 * (commonly written as T) that can represent any type.
 *
 * Generics improve code reuse and prevent errors caused by incorrect
 * type conversions.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * GenericMethodExample
 * Demonstrates a generic method that can operate on values of different
 * types. The same method can work with integers, strings, or other types.
 *
 * GenericClassExample
 * Shows how to define and use a generic class. The type parameter allows
 * the class to store and operate on different types of values.
 *
 * ConstraintExample
 * Demonstrates the use of a generic constraint with the where keyword.
 * Constraints restrict which types can be used as type parameters.
 *
 * GenericCollectionExample
 * Shows how generics are used in standard .NET collections such as
 * List<T>. Generics ensure that the collection contains only values
 * of the specified type.
 *
 * SwapExample
 * Demonstrates a generic method that swaps two values regardless of
 * their type using reference parameters.
 *
 * INTERNAL MECHANICS
 * - Generic types are checked at compile time for type safety.
 * - The type parameter (T) acts as a placeholder for the actual type.
 * - Constraints can restrict the allowed types for a generic parameter.
 * - Generic collections store strongly typed elements without casting.
 *
 * TERMINOLOGY
 * Generic: A type or method that works with a placeholder type parameter.
 * Type Parameter: A placeholder type (commonly named T).
 * Constraint: A rule that limits which types can be used in a generic.
 * Strong Typing: Ensuring that only values of the correct type are used.
 */

public static class Examples
{
    // Demonstrates a generic method.
    public static void GenericMethodExample()
    {
        PrintTwice(10);
        PrintTwice("Hi");
    }

    // Shows generic class usage.
    public static void GenericClassExample()
    {
        var box = new Box<string>("book");
        Console.WriteLine(box.Value);
    }

    // Demonstrates where constraint for reference types.
    public static void ConstraintExample()
    {
        Console.WriteLine(IsNull<string>(null));
    }

    // Shows generic collection type safety.
    public static void GenericCollectionExample()
    {
        var list = new List<int> { 1, 2, 3 };
        Console.WriteLine(list.Sum());
    }

    // Demonstrates swap using generic refs.
    public static void SwapExample()
    {
        int a = 1;
        int b = 2;
        Swap(ref a, ref b);
        Console.WriteLine($"{a},{b}");
    }

    private static void PrintTwice<T>(T value)
    {
        Console.WriteLine(value);
        Console.WriteLine(value);
    }

    private static bool IsNull<T>(T? value) where T : class
    {
        return value is null;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        (x, y) = (y, x);
    }
}

public class Box<T>(T value)
{
    public T Value { get; } = value;
}




