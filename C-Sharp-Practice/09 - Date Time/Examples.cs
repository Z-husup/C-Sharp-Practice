namespace C_Sharp_Practice.Date_Time;

/*
 * TOPIC: Date and Time
 *
 * TOPIC DEFINITION
 * Date and time values in C# are represented mainly by the DateTime structure.
 * It allows programs to store, manipulate, and format calendar dates and times.
 * DateTime can represent both local system time and Coordinated Universal Time (UTC).
 *
 * Working with dates and times often involves retrieving the current time,
 * performing date calculations, measuring time intervals, and formatting
 * date values for display or storage.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * NowExample
 * Demonstrates how to retrieve the current local date and time using
 * DateTime.Now and format it into a readable string.
 *
 * UtcExample
 * Shows how to retrieve the current universal time using DateTime.UtcNow.
 * UTC time is often used for storing timestamps in databases or systems
 * that operate across multiple time zones.
 *
 * DateArithmetic
 * Demonstrates how to perform calculations with dates, such as adding
 * days, months, or years using methods like AddDays.
 *
 * DateDiffExample
 * Shows how to calculate the difference between two dates using TimeSpan.
 * A TimeSpan represents a duration of time such as days, hours, or minutes.
 *
 * DateTimeOffsetExample
 * Demonstrates the DateTimeOffset structure, which stores a date and time
 * together with an offset from UTC. This helps represent times accurately
 * across different time zones.
 *
 * INTERNAL MECHANICS
 * - DateTime stores date and time values with precision down to fractions
 *   of a second.
 * - Date arithmetic methods create new DateTime values instead of modifying
 *   the original value.
 * - Subtracting two DateTime values produces a TimeSpan representing
 *   the time interval between them.
 * - DateTimeOffset combines a DateTime value with a time zone offset.
 *
 * TERMINOLOGY
 * DateTime: A structure used to represent a date and time value.
 * UTC (Coordinated Universal Time): A standard global time reference.
 * Local Time: The current time according to the system's time zone.
 * TimeSpan: A structure representing a duration or difference between times.
 * Offset: The difference between a local time and UTC.
 */

public static class Examples
{
    // Shows retrieving and formatting the current local date-time.
    public static void NowExample()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
    }

    // Demonstrates UTC timestamp usage for consistent storage.
    public static void UtcExample()
    {
        DateTime utc = DateTime.UtcNow;
        Console.WriteLine(utc.ToString("O"));
    }

    // Shows date arithmetic using AddDays and related APIs.
    public static void DateArithmetic()
    {
        DateTime start = new DateTime(2026, 1, 1);
        Console.WriteLine(start.AddDays(30).ToString("yyyy-MM-dd"));
    }

    // Computes duration between two dates via TimeSpan.
    public static void DateDiffExample()
    {
        DateTime a = new DateTime(2026, 1, 1);
        DateTime b = new DateTime(2026, 2, 1);
        TimeSpan diff = b - a;
        Console.WriteLine(diff.Days);
    }

    // Demonstrates offset-aware timestamp representation.
    public static void DateTimeOffsetExample()
    {
        DateTimeOffset dto = DateTimeOffset.Now;
        Console.WriteLine(dto.Offset);
    }
}






