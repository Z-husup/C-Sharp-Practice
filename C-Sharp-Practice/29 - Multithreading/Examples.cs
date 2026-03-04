namespace C_Sharp_Practice.Multithreading;

/*
 * TOPIC: Multithreading
 *
 * TOPIC DEFINITION
 * Multithreading is a programming technique that allows a program to
 * perform multiple operations at the same time. Each independent
 * sequence of execution is called a thread.
 *
 * Using multiple threads can improve application performance when tasks
 * can run independently, such as processing data, handling network
 * requests, or performing background computations.
 *
 * However, multithreading introduces challenges because multiple
 * threads may attempt to access the same data at the same time.
 * Without proper synchronization, this can lead to incorrect results
 * or unpredictable program behavior.
 *
 * C# provides several tools for working with multithreading, including
 * the Task Parallel Library, explicit threads, synchronization locks,
 * and atomic operations.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * TaskExample
 * Demonstrates the use of the Task class. Tasks represent asynchronous
 * operations that run on background threads managed by the .NET runtime.
 * Tasks are the recommended modern approach for concurrency in C#.
 *
 * ParallelForExample
 * Demonstrates the Parallel.For method. This method runs loop iterations
 * in parallel across multiple threads, allowing CPU-intensive operations
 * to complete faster on multi-core processors.
 *
 * ThreadExample
 * Demonstrates the creation of a thread manually using the Thread class.
 * This approach gives direct control over thread execution but is less
 * commonly used in modern applications compared to tasks.
 *
 * LockExample
 * Demonstrates the use of a lock statement to protect shared data.
 * When multiple threads attempt to update the same variable, a lock
 * ensures that only one thread can enter the critical section at a time.
 *
 * InterlockedExample
 * Demonstrates atomic operations using the Interlocked class.
 * Atomic operations modify a value safely without requiring a full lock.
 * This approach is typically faster for simple updates such as counters.
 *
 * INTERNAL MECHANICS
 * - Multiple threads may run simultaneously on different CPU cores.
 * - Tasks and parallel loops are managed by the .NET thread pool.
 * - Locks prevent multiple threads from modifying shared data at the same time.
 * - Atomic operations provide thread-safe updates without explicit locking.
 *
 * TERMINOLOGY
 *
 * Thread
 * An independent path of execution within a program.
 *
 * Concurrency
 * The ability of a program to perform multiple operations at the same time.
 *
 * Race Condition
 * A situation where the outcome depends on the unpredictable order
 * in which threads access shared data.
 *
 * Critical Section
 * A portion of code that accesses shared resources and must not be
 * executed by multiple threads simultaneously.
 *
 * Atomic Operation
 * An operation that completes as a single indivisible step.
 */

public static class Examples
{
    // Runs background work using Task-based concurrency.
    public static void TaskExample()
    {
        Task task = Task.Run(() => Console.WriteLine("Running in background task"));
        task.Wait();
    }

    // Demonstrates parallel loop execution for CPU work.
    public static void ParallelForExample()
    {
        Parallel.For(0, 3, i => Console.WriteLine($"Iteration: {i}"));
    }

    // Shows low-level thread creation and synchronization via Join.
    public static void ThreadExample()
    {
        Thread t = new Thread(() => Console.WriteLine("Thread started"));
        t.Start();
        t.Join();
    }

    // Demonstrates critical section protection with lock.
    public static void LockExample()
    {
        int counter = 0;
        object sync = new object();

        Parallel.For(0, 1000, _ =>
        {
            lock (sync)
            {
                counter++;
            }
        });

        Console.WriteLine(counter);
    }

    // Shows atomic updates without coarse-grained locking.
    public static void InterlockedExample()
    {
        int counter = 0;

        Parallel.For(0, 1000, _ => Interlocked.Increment(ref counter));

        Console.WriteLine(counter);
    }
}

