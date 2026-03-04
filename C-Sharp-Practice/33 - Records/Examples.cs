namespace C_Sharp_Practice.Records;

/*
 * TOPIC: Records
 *
 * TOPIC DEFINITION
 * Records are a special kind of type in C# designed primarily for
 * storing immutable data. They provide a concise syntax for declaring
 * data objects and automatically generate useful functionality such as
 * value-based equality, printing, and deconstruction.
 *
 * Unlike regular classes, records compare objects by their values
 * rather than by reference. This means that two record instances with
 * the same data are considered equal.
 *
 * Records are commonly used in scenarios where objects represent data
 * rather than behavior, such as data transfer objects (DTOs),
 * configuration models, or immutable data structures.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicRecordExample
 * Demonstrates creating a record instance and printing it. Records
 * automatically generate a readable string representation that
 * displays their property values.
 *
 * EqualityExample
 * Demonstrates value-based equality. Two record objects are considered
 * equal if their properties contain the same values.
 *
 * WithExpressionExample
 * Demonstrates the "with" expression. This feature allows a new record
 * to be created from an existing one while changing selected properties.
 * The original object remains unchanged.
 *
 * DeconstructExample
 * Demonstrates record deconstruction. Records can automatically
 * provide a way to extract their values into separate variables.
 *
 * RecordStructExample
 * Demonstrates a record struct. A record struct behaves like a value
 * type (similar to struct) but still provides record features such
 * as value-based equality and concise syntax.
 *
 * INTERNAL MECHANICS
 * - Records automatically generate equality methods.
 * - Records provide built-in support for deconstruction.
 * - With-expressions create modified copies without mutating the original object.
 *
 * TERMINOLOGY
 *
 * Record
 * A data-oriented type that compares objects by their values.
 *
 * Value-Based Equality
 * Equality determined by comparing the values of object properties.
 *
 * Deconstruction
 * Extracting the values of an object into separate variables.
 *
 * Immutable Object
 * An object whose data cannot be changed after it is created.
 */

public static class Examples
{
    // Demonstrates record construction and value printing.
    public static void BasicRecordExample()
    {
        var person = new Person("Ana", 25);
        Console.WriteLine(person);
    }

    // Shows value-based equality between records.
    public static void EqualityExample()
    {
        var a = new Person("Ana", 25);
        var b = new Person("Ana", 25);
        Console.WriteLine(a == b);
    }

    // Demonstrates non-destructive mutation with with-expression.
    public static void WithExpressionExample()
    {
        var p1 = new Person("Ana", 25);
        var p2 = p1 with { Age = 26 };
        Console.WriteLine($"{p1.Age}->{p2.Age}");
    }

    // Shows positional record deconstruction.
    public static void DeconstructExample()
    {
        var person = new Person("Bob", 30);
        var (name, age) = person;
        Console.WriteLine($"{name}:{age}");
    }

    // Demonstrates record struct as value-type record.
    public static void RecordStructExample()
    {
        var point = new Point(3, 4);
        Console.WriteLine(point);
    }
}

public record Person(string Name, int Age);

public readonly record struct Point(int X, int Y);





