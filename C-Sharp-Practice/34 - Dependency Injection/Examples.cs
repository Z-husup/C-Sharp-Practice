namespace C_Sharp_Practice.Dependency_Injection;

/*
 * TOPIC: Dependency Injection
 *
 * TOPIC DEFINITION
 * Dependency Injection (DI) is a design technique used to supply
 * required objects (dependencies) to a class instead of letting the
 * class create those objects itself.
 *
 * A dependency is any object that another object needs in order to
 * perform its work. By injecting dependencies from the outside,
 * classes become more flexible, easier to test, and easier to
 * maintain.
 *
 * In most modern C# applications, dependencies are provided through
 * constructor parameters. The class depends on an abstraction
 * (usually an interface) rather than a concrete implementation.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * ConstructorInjectionExample
 * Demonstrates constructor injection. The required dependency
 * (ILogger) is passed to the class through its constructor instead
 * of being created inside the class.
 *
 * ReplaceDependencyExample
 * Demonstrates how different implementations of the same interface
 * can be substituted without modifying the class that uses them.
 * This flexibility is one of the key benefits of dependency injection.
 *
 * CompositionRootExample
 * Demonstrates a composition root. The composition root is the place
 * in the program where dependencies are created and connected
 * together before the application starts running.
 *
 * FakeDependencyExample
 * Demonstrates using a fake implementation of a dependency.
 * Fake or mock objects are often used during testing to observe
 * behavior without relying on real external components.
 *
 * BoundaryExample
 * Demonstrates how multiple classes can collaborate through
 * shared abstractions. Each class performs a single responsibility
 * while depending only on interfaces.
 *
 * INTERNAL MECHANICS
 * - Classes declare required dependencies in their constructors.
 * - Interfaces define the behavior required by the class.
 * - Concrete implementations are created externally and injected.
 * - This separation improves modularity and testability.
 *
 * TERMINOLOGY
 *
 * Dependency
 * An object that another class needs in order to perform its work.
 *
 * Dependency Injection
 * Providing dependencies to a class from the outside instead of
 * creating them inside the class.
 *
 * Interface
 * A contract that defines a set of methods a class must implement.
 *
 * Composition Root
 * The place in the application where objects are created and
 * dependencies are assembled.
 *
 * Fake / Mock
 * A simplified implementation used during testing to simulate
 * behavior of a real dependency.
 */

public static class Examples
{
    // Demonstrates constructor injection.
    public static void ConstructorInjectionExample()
    {
        var service = new MessageService(new ConsoleLogger());
        service.Run();
    }

    // Shows swapping implementation without changing consumer.
    public static void ReplaceDependencyExample()
    {
        var service = new MessageService(new MemoryLogger());
        service.Run();
    }

    // Demonstrates manual composition root style.
    public static void CompositionRootExample()
    {
        ILogger logger = new ConsoleLogger();
        var service = new MessageService(logger);
        service.Run();
    }

    // Shows injecting fake for test-like scenarios.
    public static void FakeDependencyExample()
    {
        var fake = new FakeLogger();
        var service = new MessageService(fake);
        service.Run();
        Console.WriteLine(fake.Messages.Count);
    }

    // Demonstrates single-responsibility collaboration boundaries.
    public static void BoundaryExample()
    {
        var notifier = new Notifier(new ConsoleLogger());
        notifier.Notify("done");
    }
}

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

public class MemoryLogger : ILogger
{
    public readonly List<string> Messages = [];
    public void Log(string message) => Messages.Add(message);
}

public class FakeLogger : ILogger
{
    public readonly List<string> Messages = [];
    public void Log(string message) => Messages.Add(message);
}

public class MessageService(ILogger logger)
{
    public void Run() => logger.Log("MessageService executed");
}

public class Notifier(ILogger logger)
{
    public void Notify(string text) => logger.Log($"Notify: {text}");
}






