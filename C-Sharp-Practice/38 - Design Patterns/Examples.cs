namespace C_Sharp_Practice.Design_Patterns;

/*
 * TOPIC: Design Patterns
 *
 * TOPIC DEFINITION
 * Design patterns are common solutions to recurring problems in
 * software design. They describe proven ways to organize classes
 * and objects so that systems remain flexible and maintainable.
 *
 * Patterns do not provide finished code. Instead, they describe
 * a structure that developers can adapt to their own problems.
 *
 * Many design patterns were originally described in the famous
 * "Gang of Four" (GoF) book on object-oriented design.
 *
 * This file demonstrates several well-known patterns:
 *
 * Strategy
 * Factory
 * Decorator
 * Singleton
 * Adapter
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * StrategyExample
 * Demonstrates the Strategy pattern. A strategy encapsulates a
 * specific algorithm or behavior inside a separate class.
 * The main object can switch strategies without changing its
 * own implementation.
 *
 * FactoryExample
 * Demonstrates the Factory pattern. A factory method creates
 * objects without exposing the creation logic to the client.
 * This helps centralize object creation.
 *
 * DecoratorExample
 * Demonstrates the Decorator pattern. A decorator wraps an
 * existing object and extends its behavior without modifying
 * the original class.
 *
 * SingletonLikeExample
 * Demonstrates the Singleton pattern. A singleton ensures that
 * only one instance of a class exists during the program's
 * lifetime and provides a global access point to it.
 *
 * AdapterExample
 * Demonstrates the Adapter pattern. An adapter converts the
 * interface of an existing class into a different interface
 * expected by the client.
 *
 * INTERNAL MECHANICS
 * - Strategy replaces behavior through interchangeable objects.
 * - Factory centralizes object creation logic.
 * - Decorator adds behavior by wrapping objects.
 * - Singleton restricts instantiation to a single instance.
 * - Adapter bridges incompatible interfaces.
 *
 * TERMINOLOGY
 *
 * Pattern
 * A reusable design solution that solves a common software problem.
 *
 * Client
 * The code that uses a pattern's abstraction.
 *
 * Implementation
 * The concrete class that provides the behavior behind an interface.
 *
 * Wrapper
 * An object that contains another object and extends its behavior.
 */

public static class Examples
{
    // Demonstrates Strategy pattern.
    public static void StrategyExample()
    {
        IPaymentStrategy strategy = new CardPayment();
        var checkout = new Checkout(strategy);
        checkout.Pay(100);
    }

    // Shows Factory method usage.
    public static void FactoryExample()
    {
        ILogger logger = LoggerFactory.Create("console");
        logger.Log("factory created logger");
    }

    // Demonstrates Decorator pattern behavior extension.
    public static void DecoratorExample()
    {
        IMessageSender sender = new TimestampSender(new PlainSender());
        sender.Send("hello");
    }

    // Shows Singleton-like static instance usage.
    public static void SingletonLikeExample()
    {
        Console.WriteLine(AppSettings.Instance.Name);
    }

    // Demonstrates Adapter pattern bridging APIs.
    public static void AdapterExample()
    {
        INotifier notifier = new LegacyNotifierAdapter(new LegacyNotifier());
        notifier.Notify("adapted message");
    }
}

public interface IPaymentStrategy { void Pay(decimal amount); }

public class CardPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Card paid {amount}");
}

public class Checkout(IPaymentStrategy strategy)
{
    public void Pay(decimal amount) => strategy.Pay(amount);
}

public interface ILogger { void Log(string message); }

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

public static class LoggerFactory
{
    public static ILogger Create(string kind) => new ConsoleLogger();
}

public interface IMessageSender { void Send(string message); }

public class PlainSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine(message);
}

public class TimestampSender(IMessageSender inner) : IMessageSender
{
    public void Send(string message)
        => inner.Send($"[{DateTime.UtcNow:O}] {message}");
}

public class AppSettings
{
    public static AppSettings Instance { get; } = new AppSettings();
    public string Name { get; } = "PracticeApp";

    private AppSettings() { }
}

public interface INotifier { void Notify(string message); }

public class LegacyNotifier
{
    public void SendLegacy(string msg) => Console.WriteLine(msg);
}

public class LegacyNotifierAdapter(LegacyNotifier legacy) : INotifier
{
    public void Notify(string message) => legacy.SendLegacy(message);
}



