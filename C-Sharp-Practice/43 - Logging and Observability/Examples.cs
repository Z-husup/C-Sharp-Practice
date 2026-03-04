namespace C_Sharp_Practice.Logging_and_Observability;

/*
 * TOPIC: Logging and Observability
 *
 * TOPIC DEFINITION
 * Logging and observability provide insight into what a program is
 * doing while it runs. In small programs developers can inspect
 * behavior directly using debuggers, but in production systems
 * software often runs on remote servers where direct inspection
 * is not possible.
 *
 * Observability tools allow developers and operators to understand
 * system behavior through runtime information such as logs, metrics,
 * and traces.
 *
 * Logging records important events that occur during execution.
 * Observability extends this concept by providing context about how
 * the system behaves over time.
 *
 * Typical goals of logging and observability include:
 *
 * - understanding what the application is doing
 * - diagnosing errors and failures
 * - measuring system performance
 * - tracing requests through distributed systems
 * - monitoring production environments
 *
 * In modern systems logging usually integrates with centralized
 * monitoring platforms such as ELK, OpenTelemetry, or cloud
 * monitoring services.
 *
 * This file demonstrates several basic observability techniques:
 *
 * Log levels
 * Structured logging
 * Correlation identifiers
 * Performance timing
 * Error logging
 *
 *
 * --------------------------------------------------------------------
 * TECHNIQUE EXPLANATIONS
 * --------------------------------------------------------------------
 *
 * LOG LEVELS
 *
 * Problem
 * Not all log messages have the same importance. Some messages are
 * informational, while others indicate warnings or critical failures.
 *
 * Solution
 * Logging frameworks classify messages using severity levels.
 *
 * Common levels include:
 *
 * TRACE  – extremely detailed diagnostic information
 * DEBUG  – useful information for developers during debugging
 * INFO   – normal application events
 * WARN   – unexpected situations that are not fatal
 * ERROR  – failures that prevent an operation from completing
 * FATAL  – severe errors that may stop the application
 *
 * Benefit
 * Log levels allow filtering messages depending on the environment.
 *
 * Trade-off
 * Incorrect level usage can make logs noisy or hide important issues.
 *
 *
 * --------------------------------------------------------------------
 *
 * STRUCTURED LOGGING
 *
 * Problem
 * Traditional logs store messages as plain text, which can be difficult
 * to search or analyze automatically.
 *
 * Example:
 *
 * "User 42 logged in"
 *
 * The information is embedded inside the string.
 *
 * Solution
 * Structured logging records events using key-value pairs so that
 * machines can parse them easily.
 *
 * Example:
 *
 * level=INFO event=UserLogin userId=42
 *
 * Benefit
 * Log analysis systems can filter, aggregate, and search structured
 * logs more efficiently.
 *
 * Trade-off
 * Requires consistent logging conventions.
 *
 *
 * --------------------------------------------------------------------
 *
 * CORRELATION IDENTIFIERS
 *
 * Problem
 * In distributed systems a single request may travel through multiple
 * services. Without a shared identifier it becomes difficult to trace
 * the request across logs.
 *
 * Solution
 * A correlation ID is a unique identifier attached to a request and
 * propagated through all services involved in handling that request.
 *
 * Example workflow:
 *
 * Client request → correlation ID assigned → services log events
 * including the same correlation ID.
 *
 * Benefit
 * Makes it possible to reconstruct the full request path through logs.
 *
 * Trade-off
 * Requires propagation of the identifier through system components.
 *
 *
 * --------------------------------------------------------------------
 *
 * PERFORMANCE TIMING
 *
 * Problem
 * Slow operations can degrade system performance. Without measurement
 * it is difficult to identify where time is being spent.
 *
 * Solution
 * Timing instrumentation records how long operations take. This is
 * commonly done using timers such as the Stopwatch class.
 *
 * Example:
 *
 * start timer → execute operation → stop timer → log duration
 *
 * Benefit
 * Helps identify performance bottlenecks and latency problems.
 *
 * Trade-off
 * Excessive instrumentation may add overhead if used carelessly.
 *
 *
 * --------------------------------------------------------------------
 *
 * ERROR LOGGING
 *
 * Problem
 * When an exception occurs in production, the cause may not be visible
 * without diagnostic information.
 *
 * Solution
 * Error logging records exception details such as:
 *
 * - error message
 * - stack trace
 * - contextual information
 *
 * This information helps developers identify the root cause of failures.
 *
 * Benefit
 * Enables faster debugging and incident investigation.
 *
 * Trade-off
 * Sensitive data must not be exposed in logs.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Observability systems typically combine three types of runtime data:
 *
 * Logs
 * Records of discrete events occurring during execution.
 *
 * Metrics
 * Numerical measurements collected over time such as request counts
 * or latency.
 *
 * Traces
 * Detailed records showing the flow of a request across multiple
 * components.
 *
 * Together these signals provide a comprehensive view of system health
 * and behavior.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Log Entry
 * A recorded event describing something that happened during program
 * execution.
 *
 * Log Level
 * A classification indicating the severity or importance of a log
 * message.
 *
 * Structured Logging
 * A logging format where events are recorded as key-value pairs.
 *
 * Correlation ID
 * A unique identifier used to track a request across multiple system
 * components.
 *
 * Observability
 * The ability to understand a system's internal state using external
 * runtime signals such as logs, metrics, and traces.
 */

public static class Examples
{
    // Demonstrates simple level-based logging.
    public static void LogLevelExample()
    {
        Log("INFO", "Application started");
    }

    // Shows structured message style using key-value content.
    public static void StructuredLogExample()
    {
        Console.WriteLine("level=INFO event=UserLogin userId=42");
    }

    // Demonstrates correlation ID propagation concept.
    public static void CorrelationIdExample()
    {
        string correlationId = Guid.NewGuid().ToString();
        Console.WriteLine($"correlationId={correlationId}");
    }

    // Shows basic duration measurement for observability.
    public static void TimingExample()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        Task.Delay(10).Wait();
        sw.Stop();
        Console.WriteLine($"durationMs={sw.ElapsedMilliseconds}");
    }

    // Demonstrates error logging with exception context.
    public static void ErrorLogExample()
    {
        try
        {
            throw new InvalidOperationException("Sample failure");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"level=ERROR message={ex.Message}");
        }
    }

    private static void Log(string level, string message)
    {
        Console.WriteLine($"level={level} message={message}");
    }
}






