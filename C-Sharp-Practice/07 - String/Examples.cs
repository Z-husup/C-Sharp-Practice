namespace C_Sharp_Practice.String;

/*
 * TOPIC: Strings
 *
 * TOPIC DEFINITION
 * A string in C# represents a sequence of characters used to store and
 * manipulate text. Strings are widely used for working with names,
 * messages, file paths, and other textual data.
 *
 * In .NET, strings are immutable. This means that once a string object is
 * created, its content cannot be changed. When an operation appears to
 * modify a string (such as replacing text or converting case), a new
 * string object is created instead.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicOperations
 * Demonstrates common string operations such as converting text to
 * uppercase and extracting a portion of a string using Substring.
 *
 * StringBuilderExample
 * Shows how to use the StringBuilder class for efficient text construction.
 * StringBuilder is useful when many modifications to text are required,
 * because it avoids creating many temporary string objects.
 *
 * SplitJoinExample
 * Demonstrates how to split a string into multiple parts using a delimiter
 * (for example, separating values in a comma-separated list), and how to
 * combine those parts back into a single string using Join.
 *
 * ReplaceTrimExample
 * Shows how to clean and modify text by removing whitespace using Trim
 * and replacing parts of a string using Replace.
 *
 * ComparisonExample
 * Demonstrates how to compare strings safely using string.Equals with a
 * specified comparison rule. Using StringComparison allows control over
 * whether the comparison is case-sensitive or case-insensitive.
 *
 * INTERNAL MECHANICS
 * - Strings store characters as a sequence of UTF-16 code units.
 * - Because strings are immutable, modification operations return new strings.
 * - StringBuilder provides a mutable buffer for efficient text construction.
 * - Built-in methods support searching, splitting, replacing, and formatting text.
 *
 * TERMINOLOGY
 * String: A sequence of characters representing text.
 * Immutable: A value that cannot be changed after it is created.
 * Substring: A portion of a string extracted from a larger string.
 * Delimiter: A character used to separate parts of text.
 * StringBuilder: A class used for efficient construction and modification of text.
 */

public static class Examples
{
    // Shows common immutable string transformations.
    public static void BasicOperations()
    {
        string text = "CSharp";
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.Substring(0, 3));
    }

    // Demonstrates efficient mutable text construction.
    public static void StringBuilderExample()
    {
        var sb = new System.Text.StringBuilder();
        sb.Append("Hello").Append(' ').Append("World");
        Console.WriteLine(sb.ToString());
    }

    // Shows splitting and recombining string collections.
    public static void SplitJoinExample()
    {
        string csv = "a,b,c";
        string[] parts = csv.Split(',');
        Console.WriteLine(string.Join("-", parts));
    }

    // Demonstrates cleanup and replacement operations on text.
    public static void ReplaceTrimExample()
    {
        string text = "  hi world  ";
        Console.WriteLine(text.Trim().Replace("world", "C#"));
    }

    // Shows safe string comparison with explicit comparison rules.
    public static void ComparisonExample()
    {
        bool same = string.Equals("abc", "ABC", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(same);
    }
}