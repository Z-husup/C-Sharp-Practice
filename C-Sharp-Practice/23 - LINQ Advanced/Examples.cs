namespace C_Sharp_Practice.LINQ_Advanced;

/*
 * TOPIC: Advanced LINQ
 *
 * TOPIC DEFINITION
 * Advanced LINQ usage focuses on understanding how queries are executed,
 * how results are produced, and how multiple sequences can be combined
 * or reshaped. While basic LINQ operations focus on filtering and
 * transforming data, advanced LINQ topics explain how queries behave
 * internally and how more complex data transformations are performed.
 *
 * One of the most important concepts in LINQ is deferred execution.
 * Many LINQ queries are not executed immediately when they are defined.
 * Instead, the query is executed later when the results are actually
 * enumerated. This behavior allows queries to remain flexible and
 * automatically reflect changes in the underlying data source.
 *
 * Another important concept is materialization. Materialization forces
 * a query to execute immediately and store the results in a concrete
 * collection such as a List or an array.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * DeferredExecutionExample
 * Demonstrates deferred execution. The query is defined first, but
 * the actual filtering operation does not run until the results are
 * enumerated. Because of this, changes to the original collection
 * can affect the final query results.
 *
 * MaterializationExample
 * Demonstrates materialization using methods such as ToList().
 * Materialization forces the query to execute immediately and store
 * the results in memory. After materialization, changes to the original
 * collection do not affect the result.
 *
 * GroupByProjectionExample
 * Demonstrates grouping elements by a key and then projecting the
 * grouped results into a new form. This is commonly used for
 * summarizing data, such as counting elements per category.
 *
 * JoinExample
 * Demonstrates joining two related sequences based on matching keys.
 * Join operations are similar to database joins and allow information
 * from multiple collections to be combined.
 *
 * SelectManyExample
 * Demonstrates flattening nested collections using SelectMany.
 * SelectMany transforms a sequence of sequences into a single
 * flattened sequence.
 *
 * INTERNAL MECHANICS
 * - LINQ queries typically operate on IEnumerable<T> sequences.
 * - Deferred execution delays query evaluation until enumeration occurs.
 * - Materialization methods such as ToList() or ToArray() execute
 *   the query immediately.
 * - Query operators can transform, combine, group, or flatten data.
 *
 * TERMINOLOGY
 *
 * Deferred Execution
 * A behavior where a LINQ query is not executed until its results
 * are actually requested.
 *
 * Materialization
 * The process of executing a query and storing its results in a
 * concrete collection such as a List.
 *
 * Projection
 * Transforming elements of a sequence into a new form.
 *
 * Join
 * Combining elements from two sequences based on matching keys.
 *
 * Flattening
 * Converting nested collections into a single sequence of elements.
 */

public static class Examples
{
    // Demonstrates deferred execution behavior.
    public static void DeferredExecutionExample()
    {
        var list = new List<int> { 1, 2, 3 };
        var query = list.Where(x => x > 1);
        list.Add(4);
        Console.WriteLine(string.Join(",", query));
    }

    // Shows immediate execution using ToList.
    public static void MaterializationExample()
    {
        var list = new List<int> { 1, 2, 3 };
        var result = list.Where(x => x > 1).ToList();
        list.Add(4);
        Console.WriteLine(string.Join(",", result));
    }

    // Demonstrates GroupBy with projection.
    public static void GroupByProjectionExample()
    {
        var words = new[] { "ant", "apple", "bee" };
        var groups = words.GroupBy(w => w[0])
                          .Select(g => $"{g.Key}:{g.Count()}");
        Console.WriteLine(string.Join(" | ", groups));
    }

    // Shows join between related collections.
    public static void JoinExample()
    {
        var users = new[] { (1, "Ana"), (2, "Bob") };
        var scores = new[] { (1, 90), (2, 80) };

        var result = users.Join(
            scores,
            u => u.Item1,
            s => s.Item1,
            (u, s) => $"{u.Item2}:{s.Item2}"
        );

        Console.WriteLine(string.Join(",", result));
    }

    // Demonstrates SelectMany flattening nested sequences.
    public static void SelectManyExample()
    {
        var data = new[] { new[] { 1, 2 }, new[] { 3, 4 } };
        var flat = data.SelectMany(x => x);
        Console.WriteLine(string.Join(",", flat));
    }
}






