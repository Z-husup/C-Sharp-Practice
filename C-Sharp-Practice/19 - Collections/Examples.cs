namespace C_Sharp_Practice.Collections;

/*
 * TOPIC: Collections
 *
 * TOPIC DEFINITION
 * Collections in C# are specialized classes used to store, manage, and
 * manipulate groups of objects. Unlike arrays, most collection types
 * automatically adjust their size as elements are added or removed.
 * This makes them more flexible and convenient for many programming tasks.
 *
 * The .NET framework provides many collection types that are optimized
 * for different usage patterns. Choosing the correct collection depends
 * on how data will be accessed, inserted, removed, or searched.
 *
 * Some collections preserve order, some provide fast key-based lookup,
 * and others enforce uniqueness of elements.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * Overview
 * Introduces the most commonly used collection types in .NET and explains
 * the basic purpose of each structure. This provides context before looking
 * at concrete examples.
 *
 * ListExample
 * Demonstrates the List<T> collection. A List behaves like a dynamic array,
 * meaning that it stores elements in a specific order and automatically
 * grows when new elements are added. List<T> allows indexed access to
 * elements and supports many operations such as adding, removing,
 * sorting, and searching.
 *
 * DictionaryExample
 * Demonstrates the Dictionary<TKey, TValue> collection. A dictionary
 * stores data as key-value pairs. Each key is unique and is used to
 * quickly retrieve its associated value. Dictionaries are commonly used
 * when fast lookup by identifier is required.
 *
 * QueueExample
 * Demonstrates the Queue<T> collection. A queue processes elements in
 * FIFO order (First In, First Out). This means that the first element
 * added to the queue is the first element removed. Queues are commonly
 * used in task scheduling, buffering systems, and message processing.
 *
 * HashSetExample
 * Demonstrates the HashSet<T> collection. A hash set stores unique
 * elements and automatically prevents duplicates. HashSet<T> is useful
 * when the goal is to ensure that each value appears only once.
 *
 * INTERNAL MECHANICS
 * - Most modern .NET collections are generic, meaning they are written
 *   using type parameters such as List<T>. This ensures compile-time
 *   type safety.
 * - Collections manage their own internal storage and resize themselves
 *   automatically when necessary.
 * - Different collection types use different internal data structures
 *   to optimize specific operations such as indexing, lookup, or insertion.
 *
 * TERMINOLOGY
 * Collection
 * A structure used to store and manage multiple values.
 *
 * Generic Collection
 * A collection that uses type parameters to ensure all elements are of
 * a specific type.
 *
 * Key-Value Pair
 * A pair of values where one element (the key) is used to locate the
 * associated value.
 *
 * FIFO (First In, First Out)
 * A processing order where the first element added is the first one removed.
 *
 * Unique Elements
 * A property where duplicate values are not allowed in the collection.
 */

public static class Examples
{
    // Prints the quick comparison of core collection types.
    public static void Overview()
    {
        Console.WriteLine("List: ordered dynamic array");
        Console.WriteLine("Dictionary: key-value hash table");
        Console.WriteLine("Stack: LIFO collection");
    }

    // Shows basic ordered dynamic-array collection usage.
    public static void ListExample()
    {
        var list = new List<int> { 1, 2, 3 };
        Console.WriteLine(list.Count);
    }

    // Shows key-value insertion and retrieval pattern.
    public static void DictionaryExample()
    {
        var dict = new Dictionary<string, int> { ["a"] = 1 };
        Console.WriteLine(dict["a"]);
    }

    // Demonstrates FIFO behavior with enqueue and dequeue.
    public static void QueueExample()
    {
        var queue = new Queue<string>();
        queue.Enqueue("first");
        Console.WriteLine(queue.Dequeue());
    }

    // Shows uniqueness behavior and duplicate elimination.
    public static void HashSetExample()
    {
        var set = new HashSet<int> { 1, 1, 2, 3 };
        Console.WriteLine(set.Count);
    }
}




