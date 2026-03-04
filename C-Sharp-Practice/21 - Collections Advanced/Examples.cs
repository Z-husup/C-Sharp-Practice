namespace C_Sharp_Practice.Collections_Advanced;

/*
 * TOPIC: Advanced Collection Usage
 *
 * TOPIC DEFINITION
 * Advanced collection usage in C# focuses on designing flexible APIs and
 * controlling how collections behave during operations such as sorting,
 * equality comparison, and data transformation.
 *
 * Instead of always working with concrete types like List<T>, many APIs
 * rely on abstraction interfaces such as IEnumerable<T> or
 * IReadOnlyCollection<T>. These interfaces describe how data can be
 * accessed without exposing how it is stored internally.
 *
 * Advanced usage also includes customizing how elements are compared
 * and ordered using comparer objects. These comparers allow developers
 * to define custom sorting rules or equality logic.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * IEnumerableExample
 * Demonstrates the IEnumerable<T> interface. IEnumerable represents a
 * sequence of elements that can be iterated over. It does not guarantee
 * how the data is stored, only that it can be enumerated. This abstraction
 * is widely used in APIs because it allows many different collection
 * types to be passed into a method.
 *
 * ReadOnlyCollectionExample
 * Demonstrates the IReadOnlyCollection<T> interface. This interface allows
 * code to expose a collection for reading without allowing external code
 * to modify the collection. This helps maintain encapsulation while still
 * providing access to the data.
 *
 * CustomComparerExample
 * Demonstrates how custom sorting logic can be implemented using the
 * IComparer<T> interface. A comparer defines how two elements should be
 * ordered relative to each other. This example sorts strings by their
 * length instead of the default alphabetical order.
 *
 * EqualityComparerExample
 * Demonstrates how custom equality rules can be applied to collections
 * such as HashSet<T>. By supplying a custom equality comparer, developers
 * can control how elements are considered equal. In this example,
 * string comparison ignores case differences.
 *
 * ToDictionaryExample
 * Demonstrates converting a sequence of values into a dictionary using
 * the LINQ ToDictionary method. This operation transforms a collection
 * into key-value pairs where each element produces a key and a value.
 *
 * INTERNAL MECHANICS
 * - IEnumerable<T> provides the ability to iterate through a sequence.
 * - IReadOnlyCollection<T> exposes collection data without allowing modification.
 * - Comparer objects determine how elements are ordered or considered equal.
 * - LINQ extension methods allow sequences to be transformed into new
 *   collection types such as dictionaries.
 *
 * TERMINOLOGY
 *
 * IEnumerable
 * An interface that represents a sequence of elements that can be iterated.
 *
 * Read-only Collection
 * A collection that can be read but not modified by external code.
 *
 * Comparer
 * An object that defines how elements are compared for ordering.
 *
 * Equality Comparer
 * An object that defines when two elements should be considered equal.
 *
 * Transformation
 * Converting data from one collection form into another, such as turning
 * a sequence into a dictionary.
 */

public static class Examples
{
    // Demonstrates API design with IEnumerable abstraction.
    public static void IEnumerableExample()
    {
        IEnumerable<int> data = new List<int> { 1, 2, 3 };
        Console.WriteLine(data.Sum());
    }

    // Shows read-only collection exposure.
    public static void ReadOnlyCollectionExample()
    {
        var source = new List<int> { 1, 2, 3 };
        IReadOnlyCollection<int> view = source;
        Console.WriteLine(view.Count);
    }

    // Demonstrates custom sorting comparer.
    public static void CustomComparerExample()
    {
        var words = new List<string> { "bbbb", "a", "ccc" };
        words.Sort(new LengthComparer());
        Console.WriteLine(string.Join(",", words));
    }

    // Shows custom equality comparer in hash set.
    public static void EqualityComparerExample()
    {
        var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "A", "a" };
        Console.WriteLine(set.Count);
    }

    // Demonstrates dictionary initialization from sequence.
    public static void ToDictionaryExample()
    {
        var items = new[] { "x", "y" };
        var dict = items.ToDictionary(k => k, v => v.Length);
        Console.WriteLine(dict["x"]);
    }
}

public class LengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        int lx = x?.Length ?? 0;
        int ly = y?.Length ?? 0;
        return lx.CompareTo(ly);
    }
}






