namespace C_Sharp_Practice.Memory_and_Performance;

/*
 * TOPIC: Memory and Performance
 *
 * TOPIC DEFINITION
 * Memory and performance engineering focuses on how programs allocate,
 * use, and release memory while executing operations efficiently.
 *
 * In many applications performance problems arise not from the algorithm
 * itself but from unnecessary memory allocations, inefficient data
 * structures, or repeated object creation.
 *
 * The .NET runtime includes powerful tools and APIs that allow developers
 * to write high-performance code when needed. These features help reduce
 * memory allocations, reuse existing buffers, and avoid unnecessary
 * copying of data.
 *
 * However, these optimizations should only be applied after measuring
 * performance. Premature optimization can make code harder to read and
 * maintain without providing meaningful benefits.
 *
 * This file demonstrates several important techniques used in
 * performance-sensitive .NET code:
 *
 * Span and stackalloc
 * Span slicing
 * ArrayPool buffer reuse
 * Stopwatch performance measurement
 * StringBuilder allocation-aware string construction
 *
 *
 * --------------------------------------------------------------------
 * TECHNIQUE EXPLANATIONS
 * --------------------------------------------------------------------
 *
 * STACKALLOC AND SPAN
 *
 * Problem
 * Arrays are normally allocated on the managed heap. Heap allocations
 * require memory management by the garbage collector, which may cause
 * additional overhead in performance-critical code.
 *
 * Solution
 * The stackalloc keyword allows allocating small arrays directly on the
 * stack instead of the heap. When combined with Span<T>, these temporary
 * buffers can be used safely without heap allocation.
 *
 * Structure
 *
 * stackalloc → stack memory
 * Span<T> → safe access wrapper
 *
 * Benefit
 * Avoids heap allocations for short-lived buffers.
 *
 * Trade-off
 * Stack memory is limited and cannot be used for large allocations.
 *
 *
 * --------------------------------------------------------------------
 *
 * SPAN SLICING
 *
 * Problem
 * Extracting portions of arrays or strings normally requires creating
 * new objects, which increases memory allocations and copying costs.
 *
 * Solution
 * Span<T> allows working with slices of existing memory without
 * allocating new arrays. A span represents a view over existing memory.
 *
 * Example
 * Instead of copying a subarray, a span can reference a portion of the
 * original array.
 *
 * Benefit
 * Eliminates unnecessary memory allocations and copying.
 *
 * Trade-off
 * Spans have restrictions: they cannot be stored on the heap or used
 * in asynchronous methods.
 *
 *
 * --------------------------------------------------------------------
 *
 * ARRAYPOOL
 *
 * Problem
 * Some applications frequently allocate temporary arrays. Repeated
 * allocations and garbage collection can degrade performance.
 *
 * Solution
 * The ArrayPool<T> class provides a shared pool of reusable arrays.
 * Instead of creating a new array every time, a program rents an array
 * from the pool and returns it when finished.
 *
 * Structure
 *
 * ArrayPool → Rent buffer → Use buffer → Return buffer
 *
 * Benefit
 * Reduces memory allocations and garbage collection pressure.
 *
 * Trade-off
 * Returned arrays may contain leftover data, so they should be cleared
 * when necessary.
 *
 *
 * --------------------------------------------------------------------
 *
 * STOPWATCH PERFORMANCE MEASUREMENT
 *
 * Problem
 * Without measurement it is impossible to know whether an optimization
 * actually improves performance.
 *
 * Solution
 * The Stopwatch class provides a high-resolution timer that can measure
 * execution time of code segments.
 *
 * Structure
 *
 * Start timer → Execute code → Stop timer → Read elapsed time
 *
 * Benefit
 * Allows accurate comparison between different implementations.
 *
 * Trade-off
 * Microbenchmarks should be repeated multiple times to produce reliable
 * results.
 *
 *
 * --------------------------------------------------------------------
 *
 * STRINGBUILDER FOR STRING PERFORMANCE
 *
 * Problem
 * Strings in .NET are immutable. Every concatenation operation creates
 * a new string object, which can lead to excessive memory allocations
 * in loops.
 *
 * Example
 *
 * string text = "";
 * for (...) text += value;
 *
 * Each iteration creates a new string.
 *
 * Solution
 * StringBuilder accumulates string content in a mutable buffer and
 * produces the final string only once when ToString() is called.
 *
 * Structure
 *
 * Append → Append → Append → ToString
 *
 * Benefit
 * Avoids repeated allocations during string concatenation.
 *
 * Trade-off
 * Slightly more verbose than simple string concatenation.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Performance improvements often involve controlling allocation and
 * memory access patterns.
 *
 * Important principles include:
 *
 * - minimizing unnecessary heap allocations
 * - reusing buffers when possible
 * - avoiding unnecessary data copying
 * - measuring performance before optimizing
 *
 * The .NET runtime already performs many optimizations automatically,
 * so manual optimizations should be used only in performance-critical
 * code paths.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Heap
 * The region of memory where dynamically allocated objects are stored
 * and managed by the garbage collector.
 *
 * Stack
 * A region of memory used for short-lived allocations and function
 * call data. Stack allocations are automatically released when a
 * method finishes.
 *
 * Allocation
 * Reserving memory for an object or data structure.
 *
 * Garbage Collection
 * The automatic process that reclaims memory from objects that are
 * no longer referenced.
 *
 * Buffer
 * A temporary memory region used to store data during processing.
 */

public static class Examples
{
    // Demonstrates stack allocation with Span.
    public static void StackallocSpanExample()
    {
        Span<int> values = stackalloc int[3] { 1, 2, 3 };
        Console.WriteLine(values[1]);
    }

    // Shows slicing without creating new arrays.
    public static void SpanSliceExample()
    {
        int[] arr = { 10, 20, 30, 40 };
        Span<int> span = arr.AsSpan(1, 2);
        Console.WriteLine(string.Join(",", span.ToArray()));
    }

    // Demonstrates ArrayPool rent/return workflow.
    public static void ArrayPoolExample()
    {
        var pool = System.Buffers.ArrayPool<int>.Shared;
        int[] rented = pool.Rent(8);
        rented[0] = 99;
        Console.WriteLine(rented[0]);
        pool.Return(rented, clearArray: true);
    }

    // Shows lightweight timing for comparative measurements.
    public static void StopwatchExample()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < 10000; i++) { _ = i * i; }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }

    // Demonstrates avoiding intermediate allocations with StringBuilder.
    public static void StringBuilderPerfExample()
    {
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < 5; i++) sb.Append(i);
        Console.WriteLine(sb.ToString());
    }
}






