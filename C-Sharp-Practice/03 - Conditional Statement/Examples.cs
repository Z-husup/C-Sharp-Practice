namespace C_Sharp_Practice.Conditional_Statement;

/*
 * TOPIC: Conditional Statements
 *
 * TOPIC DEFINITION
 * Conditional statements allow a program to make decisions based on conditions.
 * A condition is a boolean expression that evaluates to either true or false.
 * Depending on the result of that evaluation, the program can execute different
 * blocks of code. Conditional logic is a fundamental part of programming because
 * it allows programs to react to input, data, or changing states.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * IfElseExample
 * The if–else statement evaluates a condition and executes a block of code
 * if the condition is true. If the condition is false, the program can evaluate
 * additional conditions using else if, or execute a default block using else.
 * This structure is commonly used when multiple possible outcomes depend on
 * ordered conditions.
 *
 * SwitchExample
 * The switch statement (and switch expression in modern C#) selects one result
 * from several possible options based on the value of an expression. Each case
 * represents a possible match. Switch expressions provide a concise way to map
 * input values to results.
 *
 * TernaryExample
 * The ternary operator (?:) is a compact form of an if–else statement.
 * It evaluates a condition and returns one of two values depending on whether
 * the condition is true or false. It is typically used for short, simple decisions.
 *
 * RelationalPatternExample
 * Relational patterns allow conditions to be expressed directly inside a switch
 * expression using comparison operators such as <, <=, >, or >=. This makes it
 * possible to classify values into ranges in a clear and readable way.
 *
 * NullCheckExample
 * Null checking ensures that a variable does not contain null or an empty value
 * before it is used. This prevents runtime errors and ensures that a program
 * behaves correctly when input data may be missing or invalid.
 *
 * INTERNAL MECHANICS
 * - Conditional expressions evaluate to a boolean value (true or false).
 * - Control flow statements use these results to determine which code block runs.
 * - Switch expressions evaluate a value and select the matching branch.
 * - Pattern matching allows conditions to be expressed directly in switch cases.
 *
 * TERMINOLOGY
 * Condition: A boolean expression that evaluates to true or false.
 * Branch: A possible execution path chosen by a conditional statement.
 * Control Flow: The order in which program instructions are executed.
 * Pattern Matching: A feature that allows conditions to match values or ranges.
 * Null: A special value representing the absence of an object or value.
 */

public static class Examples
{
    // Demonstrates branching with ordered conditional checks.
    public static void IfElseExample(int score)
    {
        if (score >= 90) Console.WriteLine("A");
        else if (score >= 75) Console.WriteLine("B");
        else Console.WriteLine("C");
    }

    // Shows value mapping with a switch expression.
    public static void SwitchExample(string day)
    {
        string message = day switch
        {
            "Saturday" or "Sunday" => "Weekend",
            _ => "Weekday"
        };
        Console.WriteLine(message);
    }

    // Demonstrates concise two-branch selection with ternary operator.
    public static void TernaryExample(int number)
    {
        string result = number % 2 == 0 ? "Even" : "Odd";
        Console.WriteLine(result);
    }

    // Shows relational patterns inside switch expressions.
    public static void RelationalPatternExample(int temp)
    {
        string state = temp switch
        {
            < 0 => "Freezing",
            <= 25 => "Mild",
            _ => "Hot"
        };
        Console.WriteLine(state);
    }

    // Demonstrates null/empty guard checks before use.
    public static void NullCheckExample(string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) Console.WriteLine("Empty");
        else Console.WriteLine(text);
    }
}







