namespace C_Sharp_Practice.Testing;

/*
 * TOPIC: Testing
 *
 * TOPIC DEFINITION
 * Software testing is the process of verifying that code behaves as
 * expected. Tests help detect bugs, ensure correctness, and prevent
 * regressions when code changes in the future.
 *
 * A unit test focuses on a small part of a program, such as a single
 * method or class. The test executes the code and verifies that the
 * result matches the expected outcome.
 *
 * In real projects, testing is usually performed with frameworks such
 * as xUnit, NUnit, or MSTest. This file demonstrates the core ideas
 * behind testing using simple helper methods.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * AssertionExample
 * Demonstrates a basic assertion. An assertion checks whether a value
 * produced by the program matches the expected value. If the values
 * do not match, the test fails.
 *
 * ArrangeActAssertExample
 * Demonstrates the Arrange–Act–Assert pattern, a common structure for
 * writing unit tests:
 *   Arrange – prepare the input data.
 *   Act – execute the code being tested.
 *   Assert – verify that the result is correct.
 *
 * ExceptionTestExample
 * Demonstrates how tests can verify that a method throws an expected
 * exception. This is useful when validating error handling behavior.
 *
 * TableDrivenExample
 * Demonstrates table-driven testing. Instead of writing many similar
 * tests, a collection of input/output cases is defined and executed
 * in a loop.
 *
 * FakeExample
 * Demonstrates the use of a fake dependency. A fake object replaces
 * a real dependency and allows tests to observe behavior without
 * relying on external systems.
 *
 * INTERNAL MECHANICS
 * - Tests execute code and compare the result with an expected value.
 * - If the result differs, the test fails.
 * - Repeated automated testing helps maintain software reliability.
 *
 * TERMINOLOGY
 *
 * Unit Test
 * A small automated test that verifies the behavior of a single unit
 * of code, such as a method.
 *
 * Assertion
 * A check that verifies whether an expected condition is true.
 *
 * Arrange–Act–Assert
 * A common structure used to organize unit tests.
 *
 * Fake
 * A simplified implementation used to replace real dependencies
 * during testing.
 */

public static class Examples
{
    // Demonstrates simple assertion helper.
    public static void AssertionExample()
    {
        AssertEqual(4, Add(2, 2));
        Console.WriteLine("Assertion passed");
    }

    // Shows Arrange/Act/Assert test structure.
    public static void ArrangeActAssertExample()
    {
        int a = 3;
        int b = 4;

        int result = Add(a, b);

        AssertEqual(7, result);
        Console.WriteLine("AAA passed");
    }

    // Demonstrates exception testing pattern.
    public static void ExceptionTestExample()
    {
        bool threw = false;

        try
        {
            Divide(10, 0);
        }
        catch (DivideByZeroException)
        {
            threw = true;
        }

        AssertEqual(true, threw);
    }

    // Shows table-driven test approach.
    public static void TableDrivenExample()
    {
        var cases = new[] { (1, 2, 3), (2, 3, 5), (5, 5, 10) };

        foreach (var c in cases)
            AssertEqual(c.Item3, Add(c.Item1, c.Item2));

        Console.WriteLine("Table tests passed");
    }

    // Demonstrates fake dependency style verification.
    public static void FakeExample()
    {
        var fake = new CounterFake();
        fake.Increment();

        AssertEqual(1, fake.Count);
    }

    private static int Add(int x, int y) => x + y;

    private static int Divide(int x, int y) => x / y;

    private static void AssertEqual<T>(T expected, T actual)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
        {
            throw new Exception($"Expected {expected}, got {actual}");
        }
    }
}

public class CounterFake
{
    public int Count { get; private set; }

    public void Increment() => Count++;
}




