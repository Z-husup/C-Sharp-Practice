namespace C_Sharp_Practice.LINQ;

/*
 * TOPIC: LINQ (Language Integrated Query)
 *
 * TOPIC DEFINITION
 * LINQ (Language Integrated Query) is a feature of C# that allows developers
 * to query and transform collections of data using a consistent syntax.
 * Instead of writing loops to search, filter, or transform data, LINQ
 * provides a set of standard operations that work with sequences of values.
 *
 * LINQ can be used with many data sources including arrays, lists,
 * dictionaries, databases, XML documents, and more. Most LINQ operations
 * work with objects that implement the IEnumerable<T> interface.
 *
 * LINQ makes code more expressive and easier to read by describing
 * *what data is needed* rather than *how to manually iterate through it*.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * FilteringProjection
 * Demonstrates two fundamental LINQ operations:
 * - Filtering (Where): selecting elements that match a condition.
 * - Projection (Select): transforming each element into a new value.
 * This combination is extremely common when processing collections.
 *
 * OrderByExample
 * Demonstrates ordering elements using the OrderBy method.
 * LINQ allows sequences to be sorted based on a key selector
 * such as alphabetical order, numeric value, or computed properties.
 *
 * GroupByExample
 * Demonstrates grouping elements based on a key. The GroupBy
 * operator partitions a collection into groups where all elements
 * in the same group share a common key value.
 *
 * AggregateExample
 * Demonstrates the Aggregate operation. Aggregate performs
 * a custom accumulation across a sequence, combining all elements
 * into a single result value.
 *
 * JoinExample
 * Demonstrates joining two collections based on matching keys.
 * Join operations are similar to database joins and allow related
 * data from multiple sequences to be combined.
 *
 * INTERNAL MECHANICS
 * - Most LINQ operators return a new sequence rather than modifying
 *   the original collection.
 * - LINQ queries often use deferred execution, meaning the query
 *   is not executed until the results are actually enumerated.
 * - Deferred execution allows queries to remain flexible and
 *   automatically reflect changes to the source collection.
 *
 * TERMINOLOGY
 *
 * LINQ
 * A set of query operators built into C# that allow data processing
 * directly in the programming language.
 *
 * Sequence
 * An ordered set of elements that can be enumerated.
 *
 * Filtering
 * Selecting elements that satisfy a specific condition.
 *
 * Projection
 * Transforming each element into a new form.
 *
 * Grouping
 * Partitioning elements into categories based on a key.
 *
 * Aggregation
 * Combining multiple elements into a single value such as
 * a sum, product, or custom result.
 */

public static class Examples
{
    // Demonstrates filtering and projection with LINQ.
    public static void FilteringProjection()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6];
        var query = numbers.Where(n => n % 2 == 0).Select(n => n * n);
        Console.WriteLine(string.Join(",", query));
    }

    // Shows ordering sequences with LINQ sort operators.
    public static void OrderByExample()
    {
        string[] names = ["Mina", "Alex", "John"];
        var ordered = names.OrderBy(n => n);
        Console.WriteLine(string.Join(",", ordered));
    }

    // Demonstrates grouping elements by computed keys.
    public static void GroupByExample()
    {
        int[] nums = [1, 2, 3, 4, 5, 6];
        var groups = nums.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        foreach (var g in groups)
            Console.WriteLine($"{g.Key}:{g.Count()}");
    }

    // Shows custom accumulation with LINQ Aggregate.
    public static void AggregateExample()
    {
        int[] nums = [1, 2, 3, 4];
        int product = nums.Aggregate(1, (acc, n) => acc * n);
        Console.WriteLine(product);
    }

    // Demonstrates joining related sequences on matching keys.
    public static void JoinExample()
    {
        var ids = new[] { 1, 2, 3 };
        var names = new[] { (1, "Ana"), (2, "Bob") };

        var joined = ids.Join(names, i => i, x => x.Item1, (i, x) => x.Item2);

        Console.WriteLine(string.Join(",", joined));
    }
}







