namespace C_Sharp_Practice.Regular_Expression;

/*
 * TOPIC: Regular Expressions
 *
 * TOPIC DEFINITION
 * Regular expressions (often called regex) are a powerful tool used to
 * search, validate, and manipulate text based on patterns. Instead of
 * comparing text character by character manually, a regular expression
 * describes the pattern that the text should match.
 *
 * Regular expressions are commonly used for tasks such as validating
 * user input, extracting specific pieces of information from text,
 * replacing text patterns, and splitting strings using complex rules.
 *
 * In .NET, regular expressions are implemented through the Regex class
 * in the System.Text.RegularExpressions namespace.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * EmailCheck
 * Demonstrates how a regular expression can be used to validate whether
 * a string matches the general structure of an email address. The pattern
 * ensures that the text contains characters before and after the '@'
 * symbol and includes a domain suffix.
 *
 * ExtractNumbersExample
 * Demonstrates how regex can locate all numeric sequences in a string.
 * The pattern \d+ matches one or more digits, allowing numbers to be
 * extracted from larger text.
 *
 * ReplaceWhitespaceExample
 * Demonstrates replacing patterns in text. In this example, the pattern
 * \s+ matches one or more whitespace characters and replaces them with
 * a single space. This is useful for normalizing text formatting.
 *
 * SplitExample
 * Demonstrates splitting a string using multiple delimiters. The pattern
 * "[,;]" tells the regex engine to split whenever it encounters either
 * a comma or a semicolon.
 *
 * NamedGroupExample
 * Demonstrates named capture groups. Named groups allow specific parts
 * of a pattern match to be extracted and accessed using meaningful names.
 * This example parses a date formatted as YYYY-MM-DD.
 *
 * INTERNAL MECHANICS
 * - Regex patterns describe how characters should appear in text.
 * - The Regex engine scans the input text and finds parts that match
 *   the pattern.
 * - Operations such as matching, replacing, or splitting are performed
 *   based on these pattern matches.
 *
 * TERMINOLOGY
 *
 * Pattern
 * A sequence of characters that describes what text should match.
 *
 * Quantifier
 * A symbol that specifies how many times a pattern element may appear.
 * Examples include + (one or more) and * (zero or more).
 *
 * Capture Group
 * A portion of the pattern enclosed in parentheses that allows matched
 * text to be extracted.
 *
 * Named Group
 * A capture group that has a name, allowing matched values to be
 * accessed by name instead of position.
 */

public static class Examples
{
    // Validates email shape with a regular expression pattern.
    public static void EmailCheck(string input)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
    }

    // Extracts numeric tokens from text using regex matches.
    public static void ExtractNumbersExample()
    {
        string text = "Order 123 costs 45 dollars";
        var matches = System.Text.RegularExpressions.Regex.Matches(text, @"\d+")
            .Select(m => m.Value);
        Console.WriteLine(string.Join(",", matches));
    }

    // Normalizes repeated whitespace with regex replacement.
    public static void ReplaceWhitespaceExample()
    {
        string text = "A   B   C";
        Console.WriteLine(System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " "));
    }

    // Splits text using regex-based multi-delimiter rules.
    public static void SplitExample()
    {
        string input = "one,two;three";
        string[] parts = System.Text.RegularExpressions.Regex.Split(input, "[,;]");
        Console.WriteLine(string.Join("|", parts));
    }

    // Demonstrates named capture groups for structured parsing.
    public static void NamedGroupExample()
    {
        string text = "2026-03-04";
        var match = System.Text.RegularExpressions.Regex.Match(
            text,
            @"(?<y>\d{4})-(?<m>\d{2})-(?<d>\d{2})"
        );

        Console.WriteLine($"{match.Groups["d"].Value}/{match.Groups["m"].Value}/{match.Groups["y"].Value}");
    }
}



