namespace C_Sharp_Practice.Async_Await;

/*
 * TOPIC: Async and Await
 *
 * TOPIC DEFINITION
 * Async and await are C# language features used to write asynchronous
 * code that does not block program execution while waiting for an
 * operation to complete.
 *
 * Asynchronous programming is commonly used for operations that take
 * time but do not require constant CPU work, such as network requests,
 * file access, or database queries. Instead of blocking the current
 * thread while waiting, the program can continue doing other work and
 * resume execution when the operation finishes.
 *
 * In C#, asynchronous operations are typically represented by the Task
 * or Task<T> types. The async keyword marks a method as asynchronous,
 * and the await keyword suspends execution until the awaited task
 * completes.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicAsyncExample
 * Demonstrates a simple asynchronous method. The method waits
 * asynchronously using Task.Delay and resumes execution afterward.
 * During the delay, the thread is not blocked.
 *
 * AwaitResultExample
 * Demonstrates awaiting a task that returns a value. The awaited
 * operation produces a result that can be used once the task completes.
 *
 * WhenAllExample
 * Demonstrates running multiple asynchronous tasks concurrently.
 * Task.WhenAll waits for all provided tasks to complete before
 * continuing execution.
 *
 * CancellationExample
 * Demonstrates how asynchronous operations can support cancellation
 * using a CancellationToken. Cancellation allows long-running
 * operations to stop early when requested.
 *
 * AsyncExceptionExample
 * Demonstrates how exceptions in asynchronous methods are handled.
 * Exceptions thrown inside awaited tasks propagate normally and can
 * be caught with try/catch.
 *
 * INTERNAL MECHANICS
 * - Async methods usually return Task or Task<T>.
 * - The await keyword pauses execution until the awaited task completes.
 * - While awaiting, the thread can perform other work instead of blocking.
 * - The method continues execution once the awaited task finishes.
 *
 * TERMINOLOGY
 *
 * Asynchronous Operation
 * An operation that runs without blocking the current thread while
 * waiting for completion.
 *
 * Task
 * An object representing an asynchronous operation that may still be running.
 *
 * Await
 * A keyword that suspends execution of an async method until a task completes.
 *
 * Cancellation Token
 * A mechanism used to request cooperative cancellation of asynchronous work.
 */

public static class Examples
{
    // Demonstrates a simple async method returning a Task.
    public static async Task BasicAsyncExample()
    {
        await Task.Delay(10);
        Console.WriteLine("Done");
    }

    // Shows awaiting result-producing tasks.
    public static async Task AwaitResultExample()
    {
        int value = await GetNumberAsync();
        Console.WriteLine(value);
    }

    // Demonstrates running tasks concurrently and awaiting all.
    public static async Task WhenAllExample()
    {
        Task a = Task.Delay(10);
        Task b = Task.Delay(20);

        await Task.WhenAll(a, b);

        Console.WriteLine("All completed");
    }

    // Shows cancellation-aware async operation.
    public static async Task CancellationExample()
    {
        using var cts = new CancellationTokenSource(5);

        try
        {
            await Task.Delay(1000, cts.Token);
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Canceled");
        }
    }

    // Demonstrates async exception handling with try/catch.
    public static async Task AsyncExceptionExample()
    {
        try
        {
            await ThrowAsync();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static async Task<int> GetNumberAsync()
    {
        await Task.Delay(10);
        return 42;
    }

    private static async Task ThrowAsync()
    {
        await Task.Delay(1);
        throw new InvalidOperationException("Async failure");
    }
}





