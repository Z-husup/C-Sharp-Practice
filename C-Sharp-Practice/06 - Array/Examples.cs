namespace C_Sharp_Practice.Array;

/*
 * TOPIC: Arrays
 *
 * TOPIC DEFINITION
 * An array is a data structure that stores a fixed number of elements of the
 * same data type. The elements are stored in contiguous memory locations and
 * are accessed using an index. In C#, array indexing starts at 0, meaning the
 * first element is at index 0, the second at index 1, and so on.
 *
 * Arrays are useful when you need to store multiple related values and access
 * them efficiently using their position in the collection.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicExample
 * Demonstrates how to declare and initialize an array and access elements
 * using an index. It also shows the use of the ^ operator, which allows
 * indexing from the end of the array.
 *
 * TraverseExample
 * Shows how to iterate through an array using a for loop. Traversing an array
 * means visiting each element one by one to read or process its value.
 *
 * ResizeWithCopyExample
 * Arrays in C# have a fixed size once they are created. To increase the size
 * of an array, a new larger array must be created and the elements of the
 * original array must be copied into it.
 *
 * SortExample
 * Demonstrates how to sort the elements of an array using the built-in
 * Array.Sort method provided by the .NET framework.
 *
 * SearchExample
 * Demonstrates how to find the position (index) of a specific value inside
 * an array using Array.IndexOf.
 *
 * INTERNAL MECHANICS
 * - Arrays allocate a continuous block of memory to store elements.
 * - Each element can be accessed directly using its index.
 * - The length of the array is fixed after creation.
 * - Built-in methods such as Copy, Sort, and IndexOf provide common
 *   operations for working with arrays.
 *
 * TERMINOLOGY
 * Array: A collection of elements of the same data type stored in order.
 * Index: The position of an element within an array.
 * Length: The number of elements an array can store.
 * Traversal: Accessing each element in a collection sequentially.
 * Copy: Creating a new array and transferring elements from another array.
 */

public static class Examples
{
    // Demonstrates the core usage pattern for this topic.
    public static void BasicExample()
    {
        int[] numbers = { 10, 20, 30, 40 };
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[^1]);
    }

    // Shows sequential traversal and element access.
    public static void TraverseExample()
    {
        int[] numbers = { 1, 2, 3, 4 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    // Demonstrates resizing semantics by copying into a larger array.
    public static void ResizeWithCopyExample()
    {
        int[] source = { 1, 2, 3 };
        int[] resized = new int[5];
        System.Array.Copy(source, resized, source.Length);
        Console.WriteLine(string.Join(",", resized));
    }

    // Shows sorting with the built-in framework API.
    public static void SortExample()
    {
        int[] numbers = { 5, 2, 9, 1 };
        System.Array.Sort(numbers);
        Console.WriteLine(string.Join(",", numbers));
    }

    // Demonstrates finding an element index in a collection.
    public static void SearchExample()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int index = System.Array.IndexOf(numbers, 23);
        Console.WriteLine(index);
    }
}


