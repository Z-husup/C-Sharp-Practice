namespace C_Sharp_Practice.Design_Patterns.Creational;

/*
 * TOPIC: Design Patterns / Creational
 *
 * TOPIC DEFINITION
 * Creational design patterns focus on how objects are created and
 * initialized. In many simple programs objects are created directly
 * using the "new" keyword. However, as software systems grow larger,
 * object creation can become complex and tightly coupled to specific
 * implementations.
 *
 * Creational patterns solve this problem by separating the process of
 * object creation from the rest of the system. Instead of constructing
 * objects directly, the program delegates creation to specialized
 * components such as factories or builders.
 *
 * This approach improves flexibility because the rest of the program
 * depends on abstractions rather than concrete classes.
 *
 * Benefits of creational patterns include:
 *
 * - reducing coupling between components
 * - improving flexibility when introducing new object types
 * - centralizing complex creation logic
 * - simplifying configuration of complex objects
 *
 * The creational patterns demonstrated in this file are:
 *
 * Factory Method
 * Abstract Factory
 * Builder
 * Prototype
 * Singleton
 *
 *
 * PATTERN EXPLANATIONS
 *
 * FACTORY METHOD PATTERN
 *
 * Problem
 * Code often needs to create objects of different types depending on
 * runtime conditions. If object creation is scattered throughout the
 * codebase, it becomes difficult to change or extend later.
 *
 * Example:
 * A logistics system may deliver goods using trucks or ships depending
 * on the transport mode. If every part of the program creates these
 * objects directly, the system becomes tightly coupled to specific
 * classes.
 *
 * Solution
 * The Factory Method pattern moves the responsibility for object
 * creation into a dedicated factory method. The client code requests
 * an object from the factory without needing to know which concrete
 * class is instantiated.
 *
 * Structure
 *
 * Client → Factory → Concrete Product
 *
 * Benefit
 * Centralizes creation logic and makes it easy to introduce new
 * implementations.
 *
 * Trade-off
 * Adds an extra layer of abstraction.
 *
 * 
 *
 * ABSTRACT FACTORY PATTERN
 *
 * Problem
 * Some systems need to create groups of related objects that must work
 * together. For example, a user interface toolkit may support both
 * light and dark themes, each requiring matching buttons, menus, and
 * widgets.
 *
 * Creating these objects individually risks mixing incompatible
 * components.
 *
 * Solution
 * The Abstract Factory pattern defines an interface for creating
 * families of related objects. Concrete factories implement this
 * interface to produce compatible sets of components.
 *
 * Structure
 *
 * Client → Abstract Factory → Concrete Factory
 *                                ↓
 *                       Family of related objects
 *
 * Benefit
 * Ensures consistent creation of related components.
 *
 * Trade-off
 * Adding a new type of product may require modifying all factories.
 *
 *
 *
 * BUILDER PATTERN
 *
 * Problem
 * Some objects require many configuration parameters. Constructors
 * with many parameters become difficult to read and maintain.
 *
 * Example:
 * A user account may have optional properties such as name, role,
 * permissions, and settings.
 *
 * Solution
 * The Builder pattern constructs an object step by step using a
 * dedicated builder object. Each step configures part of the object,
 * and a final Build method returns the completed instance.
 *
 * Structure
 *
 * Client → Builder → Product
 *
 * Benefit
 * Improves readability and flexibility when creating complex objects.
 *
 * Trade-off
 * Introduces additional classes.
 *
 *
 *
 * PROTOTYPE PATTERN
 *
 * Problem
 * Creating objects from scratch may be expensive or complicated.
 * Sometimes it is easier to duplicate an existing object instead.
 *
 * Example:
 * An invoice template may already contain most required fields.
 * Creating a new invoice can be done by copying an existing one.
 *
 * Solution
 * The Prototype pattern creates new objects by cloning an existing
 * instance. The prototype object provides a Clone method that returns
 * a copy of itself.
 *
 * Structure
 *
 * Client → Prototype → Clone → New object
 *
 * Benefit
 * Efficient when object creation is expensive.
 *
 * Trade-off
 * Deep cloning complex objects can be difficult to implement.
 *
 *
 *
 * SINGLETON PATTERN
 *
 * Problem
 * Some classes should only have one instance during the lifetime of
 * the application.
 *
 * Example:
 * Application configuration, logging systems, or system clocks should
 * typically exist only once.
 *
 * Solution
 * The Singleton pattern restricts the class so that only one instance
 * can be created. The instance is stored in a static property that is
 * accessible globally.
 *
 * Structure
 *
 * Client → Singleton Instance
 *
 * Benefit
 * Guarantees a single shared instance.
 *
 * Trade-off
 * Global state can make testing and maintenance more difficult if
 * overused.
 *
 *
 * INTERNAL MECHANICS
 *
 * Creational patterns often rely on abstraction and delegation.
 * Instead of constructing objects directly, the system delegates
 * creation responsibilities to factories, builders, or prototypes.
 *
 * This helps isolate the rest of the program from changes in
 * implementation.
 *
 * Key design principles involved:
 *
 * - programming to interfaces rather than implementations
 * - encapsulating object creation logic
 * - separating configuration from usage
 *
 *
 * TERMINOLOGY
 *
 * Object Creation
 * The process of allocating and initializing a new instance of a class.
 *
 * Factory
 * A component responsible for creating objects.
 *
 * Builder
 * A helper object that constructs a complex object step by step.
 *
 * Prototype
 * An object that can create copies of itself through cloning.
 *
 * Singleton
 * A class designed to have exactly one instance during the lifetime
 * of the application.
 */

public static class Examples
{
    // Demonstrates Factory Method selection by input.
    public static void FactoryMethodExample()
    {
        ITransport transport = TransportFactory.Create("truck");
        Console.WriteLine(transport.Deliver());
    }

    // Shows Abstract Factory for related UI families.
    public static void AbstractFactoryExample()
    {
        IUiFactory factory = new DarkUiFactory();
        Console.WriteLine(factory.CreateButton().Render());
    }

    // Demonstrates Builder for multi-step object assembly.
    public static void BuilderExample()
    {
        var user = new UserBuilder().WithName("Ana").WithRole("Admin").Build();
        Console.WriteLine($"{user.Name}:{user.Role}");
    }

    // Shows Prototype cloning usage.
    public static void PrototypeExample()
    {
        var original = new Invoice(10, "USD");
        var copy = original.Clone();
        Console.WriteLine($"{copy.Amount} {copy.Currency}");
    }

    // Demonstrates Singleton access pattern.
    public static void SingletonExample()
    {
        Console.WriteLine(AppClock.Instance.Now.Year >= 2000);
    }
}

public interface ITransport { string Deliver(); }

public class Truck : ITransport
{
    public string Deliver() => "Truck delivery";
}

public class Ship : ITransport
{
    public string Deliver() => "Ship delivery";
}

public static class TransportFactory
{
    public static ITransport Create(string mode)
        => mode == "truck" ? new Truck() : new Ship();
}

public interface IButton { string Render(); }
public interface IUiFactory { IButton CreateButton(); }

public class DarkButton : IButton
{
    public string Render() => "Dark button";
}

public class LightButton : IButton
{
    public string Render() => "Light button";
}

public class DarkUiFactory : IUiFactory
{
    public IButton CreateButton() => new DarkButton();
}

public class LightUiFactory : IUiFactory
{
    public IButton CreateButton() => new LightButton();
}

public class User(string name, string role)
{
    public string Name { get; } = name;
    public string Role { get; } = role;
}

public class UserBuilder
{
    private string _name = "Unknown";
    private string _role = "User";

    public UserBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public UserBuilder WithRole(string role)
    {
        _role = role;
        return this;
    }

    public User Build() => new User(_name, _role);
}

public class Invoice(decimal amount, string currency)
{
    public decimal Amount { get; } = amount;
    public string Currency { get; } = currency;

    public Invoice Clone() => new Invoice(Amount, Currency);
}

public class AppClock
{
    public static AppClock Instance { get; } = new AppClock();

    public DateTime Now => DateTime.UtcNow;

    private AppClock() { }
}




