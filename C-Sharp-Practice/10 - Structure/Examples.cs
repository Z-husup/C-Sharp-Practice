namespace C_Sharp_Practice.Structure;

/*
 * TOPIC: Structures (Struct)
 *
 * TOPIC DEFINITION
 * A struct in C# is a value type used to group related data together.
 * Unlike classes, structs use value semantics, meaning that when a struct
 * variable is assigned to another variable, a copy of the data is created.
 *
 * Structs are commonly used for small data objects such as coordinates,
 * colors, measurements, or monetary values. Because they are value types,
 * they are often more efficient for small data structures.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * CreateStructExample
 * Demonstrates how to create a struct instance and access its properties.
 * Structs can contain fields, properties, and methods similar to classes.
 *
 * CopyBehaviorExample
 * Shows how structs are copied when assigned to another variable.
 * Since structs are value types, assigning one struct to another creates
 * a separate copy rather than referencing the same object.
 *
 * ReadonlyStructExample
 * Demonstrates the use of a readonly struct. A readonly struct ensures
 * that its data cannot be modified after it has been created, which
 * helps prevent accidental changes and improves code safety.
 *
 * MethodInsideStructExample
 * Shows that structs can contain methods that operate on their own data.
 * This allows structs to encapsulate both data and behavior.
 *
 * EqualityExample
 * Demonstrates how struct equality works. Two structs with the same
 * field values can be considered equal when compared using Equals.
 *
 * INTERNAL MECHANICS
 * - Structs are value types and are typically stored on the stack.
 * - Assigning a struct variable copies its entire value.
 * - Structs can contain fields, properties, constructors, and methods.
 * - Readonly structs prevent modification of their fields after creation.
 *
 * TERMINOLOGY
 * Struct: A value type used to group related data together.
 * Value Type: A type where variables contain the actual data rather than
 *             a reference to an object.
 * Copy Semantics: Assigning a value creates a new independent copy.
 * Immutable: A value that cannot be changed after it is created.
 * Property: A member that provides controlled access to data.
 */

public static class Examples
{
    // Demonstrates struct instantiation and property access.
    public static void CreateStructExample()
    {
        Point p = new Point(3, 4);
        Console.WriteLine($"X:{p.X},Y:{p.Y}");
    }

    // Shows value-copy semantics when assigning structs.
    public static void CopyBehaviorExample()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;
        Console.WriteLine($"{p1.X},{p2.X}");
    }

    // Demonstrates immutable struct design usage.
    public static void ReadonlyStructExample()
    {
        var money = new Money(10m, "USD");
        Console.WriteLine($"{money.Amount} {money.Currency}");
        Money.Void();
    }

    // Shows behavior methods defined inside struct types.
    public static void MethodInsideStructExample()
    {
        Point p = new Point(6, 8);
        Console.WriteLine(p.DistanceFromOrigin());
    }

    // Demonstrates value-based equality checks for structs.
    public static void EqualityExample()
    {
        Point a = new Point(2, 2);
        Point b = new Point(2, 2);
        Console.WriteLine(a.Equals(b));
    }
}

public readonly struct Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;

    public double DistanceFromOrigin()
    {
        return System.Math.Sqrt(X * X + Y * Y);
    }
}

public readonly struct Money(decimal amount, string currency)
{
    public decimal Amount { get; } = amount;
    public string Currency { get; } = currency;

    public static void Void()
    {
        
    }
}