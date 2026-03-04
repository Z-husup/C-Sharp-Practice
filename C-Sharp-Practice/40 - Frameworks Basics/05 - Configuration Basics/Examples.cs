namespace C_Sharp_Practice.Frameworks_Basics.Configuration_Basics;

/*
 * TOPIC: Frameworks Basics / Configuration Basics
 *
 * TOPIC DEFINITION
 * Configuration systems provide a structured way to store and access
 * application settings. Instead of hardcoding values inside the code,
 * applications retrieve configuration values from external sources.
 *
 * These values can include:
 *
 * - database connection strings
 * - API endpoints
 * - feature flags
 * - environment-specific settings
 * - application behavior parameters
 *
 * In modern .NET applications, configuration values are typically
 * aggregated from multiple sources such as:
 *
 * - JSON configuration files
 * - environment variables
 * - command-line arguments
 * - in-memory dictionaries
 * - secret stores
 *
 * The configuration system merges these sources into a single
 * configuration object that the application can read during runtime.
 *
 *
 * --------------------------------------------------------------------
 * CONFIGURATION PROVIDERS
 * --------------------------------------------------------------------
 *
 * A configuration provider is a component responsible for supplying
 * configuration values from a specific source.
 *
 * Common providers include:
 *
 * JSON file provider
 * Reads configuration values from files such as:
 *
 * appsettings.json
 *
 * Environment variable provider
 * Reads values from operating system environment variables.
 *
 * Command line provider
 * Reads values passed to the application at startup.
 *
 * In-memory provider
 * Stores configuration values in a runtime dictionary.
 *
 * The configuration system aggregates all providers into a single
 * hierarchical configuration tree.
 *
 *
 * --------------------------------------------------------------------
 * CONFIGURATION STRUCTURE
 * --------------------------------------------------------------------
 *
 * Configuration values are typically stored as key–value pairs.
 *
 * Keys may represent hierarchical structures.
 *
 * Example configuration structure:
 *
 * App
 *   Name = Practice
 *   TimeoutSeconds = 30
 *
 * This hierarchy can be represented as a key:
 *
 * App:Name
 * App:TimeoutSeconds
 *
 * The colon separator represents nested configuration sections.
 *
 *
 * --------------------------------------------------------------------
 * ENVIRONMENT-SPECIFIC CONFIGURATION
 * --------------------------------------------------------------------
 *
 * Applications often run in multiple environments, such as:
 *
 * Development
 * Testing
 * Production
 *
 * Each environment may require different configuration values.
 *
 * Example:
 *
 * Development
 * Database = local database
 *
 * Production
 * Database = cloud database
 *
 * Environment variables allow applications to override configuration
 * values without modifying source code.
 *
 * This makes deployments safer and more flexible.
 *
 *
 * --------------------------------------------------------------------
 * CONFIGURATION PRECEDENCE
 * --------------------------------------------------------------------
 *
 * When multiple configuration sources provide values for the same key,
 * precedence rules determine which value is used.
 *
 * A typical precedence order is:
 *
 * 1. Command line arguments
 * 2. Environment variables
 * 3. Configuration files (appsettings.json)
 * 4. Default values
 *
 * Higher priority sources override lower priority ones.
 *
 * Example:
 *
 * appsettings.json
 * Timeout = 30
 *
 * Environment variable
 * Timeout = 10
 *
 * Effective value:
 *
 * Timeout = 10
 *
 *
 * --------------------------------------------------------------------
 * OPTIONS BINDING
 * --------------------------------------------------------------------
 *
 * Instead of accessing configuration values directly as strings,
 * applications often bind configuration sections to strongly typed
 * objects.
 *
 * This technique is known as the Options pattern.
 *
 * Example configuration section:
 *
 * App
 *   Name = Practice
 *   TimeoutSeconds = 30
 *
 * Bound object:
 *
 * AppOptions
 *   Name
 *   TimeoutSeconds
 *
 * Benefits of options binding:
 *
 * - type safety
 * - IntelliSense support
 * - centralized configuration access
 *
 *
 * --------------------------------------------------------------------
 * CONFIGURATION VALIDATION
 * --------------------------------------------------------------------
 *
 * Configuration values must sometimes satisfy constraints to ensure
 * correct application behavior.
 *
 * Examples of validation rules:
 *
 * - required values must not be empty
 * - numeric settings must be within valid ranges
 * - URLs must be valid
 *
 * Validation prevents applications from starting with invalid
 * configuration.
 *
 * Example validation rules:
 *
 * Name must not be empty
 * TimeoutSeconds must be greater than zero
 *
 * If validation fails, the application can:
 *
 * - throw an error
 * - log configuration issues
 * - prevent startup
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Configuration systems rely on several internal mechanisms:
 *
 * Provider aggregation
 * Multiple providers contribute values to a unified configuration tree.
 *
 * Hierarchical key resolution
 * Nested configuration sections are represented using key paths.
 *
 * Precedence resolution
 * Later providers override values from earlier providers.
 *
 * Binding
 * Configuration values are converted into strongly typed objects.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Flexibility
 * Settings can change without modifying application code.
 *
 * Environment separation
 * Different environments can use different configuration values.
 *
 * Maintainability
 * Configuration is centralized and easier to manage.
 *
 * Security
 * Sensitive values can be stored outside source code.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Configuration sprawl
 * Large applications may accumulate many configuration values.
 *
 * Misconfiguration risk
 * Incorrect configuration may cause runtime failures.
 *
 * Environment drift
 * Different environments may behave differently if configuration
 * values diverge.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Configuration Provider
 * A component that supplies configuration values from a specific source.
 *
 * Configuration Key
 * A hierarchical identifier representing a configuration value.
 *
 * Options Pattern
 * A technique that binds configuration sections to strongly typed objects.
 *
 * Precedence
 * The rule that determines which configuration source overrides others.
 *
 * Environment Variable
 * An operating system variable used to configure application behavior.
 *
 * Validation
 * The process of verifying that configuration values meet required rules.
 */

public static class Examples
{
    // Demonstrates dictionary-based configuration source.
    public static void InMemoryConfigExample()
    {
        var config = new Dictionary<string, string> { ["App:Name"] = "Practice" };
        Console.WriteLine(config["App:Name"]);
    }

    // Shows environment variable fallback concept.
    public static void EnvironmentFallbackExample()
    {
        string value = Environment.GetEnvironmentVariable("APP_ENV") ?? "Development";
        Console.WriteLine(value);
    }

    // Demonstrates options binding concept.
    public static void OptionsBindingConceptExample()
    {
        var options = new AppOptions { Name = "Practice", TimeoutSeconds = 30 };
        Console.WriteLine($"{options.Name}:{options.TimeoutSeconds}");
    }

    // Shows override precedence concept.
    public static void PrecedenceExample()
    {
        string jsonValue = "A";
        string envValue = "B";
        string effective = string.IsNullOrWhiteSpace(envValue) ? jsonValue : envValue;
        Console.WriteLine(effective == "B");
    }

    // Demonstrates validation concept for options.
    public static void ValidationExample()
    {
        var options = new AppOptions { Name = "", TimeoutSeconds = -1 };
        bool valid = !string.IsNullOrWhiteSpace(options.Name) && options.TimeoutSeconds > 0;
        Console.WriteLine(valid);
    }
}

public class AppOptions
{
    public string Name { get; set; } = string.Empty;
    public int TimeoutSeconds { get; set; }
}






