namespace C_Sharp_Practice.Design_Patterns.Structural;

/*
 * TOPIC: Design Patterns / Structural
 *
 * TOPIC DEFINITION
 * Structural design patterns describe how classes and objects are
 * composed together to form larger and more flexible structures.
 *
 * When software systems grow, components often need to interact even
 * when their interfaces were not originally designed to work together.
 * Structural patterns provide techniques for connecting these
 * components while keeping the system maintainable and loosely coupled.
 *
 * These patterns focus on how objects are arranged and how they
 * communicate with each other rather than how they are created
 * (creational patterns) or how they behave (behavioral patterns).
 *
 * Structural patterns are particularly useful when:
 * - integrating legacy systems
 * - simplifying complex subsystems
 * - extending behavior without modifying existing classes
 * - organizing hierarchical object structures
 * - controlling access to expensive or sensitive resources
 *
 * The patterns demonstrated in this file are:
 *
 * Adapter
 * Decorator
 * Facade
 * Composite
 * Proxy
 *
 * PATTERN EXPLANATIONS
 *
 * ADAPTER PATTERN
 *
 * Problem
 * Sometimes a class provides useful functionality but its interface
 * does not match the interface expected by the rest of the system.
 *
 * Example:
 * A system expects an object with method:
 *
 *      Notify(string message)
 *
 * but an existing legacy class only provides:
 *
 *      SendEmail(string body)
 *
 * Because the interfaces differ, the legacy class cannot be used
 * directly.
 *
 * Solution
 * The Adapter pattern introduces a wrapper class that translates one
 * interface into another. The adapter receives calls from the client
 * and converts them into calls that the legacy object understands.
 *
 * Structure
 * Client → Adapter → Legacy object
 *
 * Benefit
 * Existing classes can be reused without modifying their code.
 *
 * Trade-off
 * Adds an extra layer of abstraction.
 *
 *
 * --------------------------------------------------------------------
 *
 * DECORATOR PATTERN
 *
 * Problem
 * Sometimes an object needs additional behavior, but modifying the
 * original class would make the design rigid or violate the
 * Open/Closed Principle.
 *
 * Example:
 * A message object simply returns text, but we want to add features
 * such as timestamps, logging, or encryption.
 *
 * Solution
 * The Decorator pattern wraps an object inside another object that
 * implements the same interface. The decorator forwards calls to the
 * wrapped object while adding extra behavior before or after.
 *
 * Structure
 * Client → Decorator → Original object
 *
 * Benefit
 * Behavior can be extended dynamically without modifying existing
 * classes.
 *
 * Trade-off
 * Many decorators may make the system harder to understand.
 *
 *
 * --------------------------------------------------------------------
 *
 * FACADE PATTERN
 *
 * Problem
 * A subsystem may consist of many interacting classes, making it
 * complicated for clients to use.
 *
 * Example:
 * Placing an order may require several steps:
 *
 * 1. Reserve inventory
 * 2. Process payment
 * 3. Create shipment
 *
 * If every client had to call these components directly, the system
 * would become tightly coupled.
 *
 * Solution
 * The Facade pattern introduces a single simplified interface that
 * performs the complex operations internally.
 *
 * Structure
 * Client → Facade → Subsystem classes
 *
 * Benefit
 * Simplifies usage and reduces coupling between clients and subsystem
 * components.
 *
 * Trade-off
 * The facade may become too large if it tries to cover too many
 * subsystem operations.
 *
 *
 * --------------------------------------------------------------------
 *
 * COMPOSITE PATTERN
 *
 * Problem
 * Some systems need to represent hierarchical structures such as
 * file systems, organizational charts, or graphical scenes.
 *
 * Example:
 * A folder can contain files and other folders.
 *
 * Both should be treated uniformly when performing operations like
 * printing or traversal.
 *
 * Solution
 * The Composite pattern represents both individual objects (leaves)
 * and groups of objects (composites) using a common interface.
 *
 * This allows the client to treat a single object and a group of
 * objects in the same way.
 *
 * Structure
 * Component interface
 *     ↑
 * Leaf objects
 * Composite objects containing children
 *
 * Benefit
 * Simplifies code that works with hierarchical structures.
 *
 * Trade-off
 * The design may allow invalid combinations if constraints are not
 * carefully enforced.
 *
 *
 * --------------------------------------------------------------------
 *
 * PROXY PATTERN
 *
 * Problem
 * Direct access to an object may be expensive, unsafe, or unnecessary.
 *
 * Example:
 * A report may require expensive database operations. Recomputing
 * the report every time it is requested would be inefficient.
 *
 * Solution
 * A proxy object acts as an intermediary between the client and the
 * real object. The proxy can add additional behavior such as:
 *
 * - caching
 * - access control
 * - lazy initialization
 * - logging
 *
 * Structure
 * Client → Proxy → Real object
 *
 * Benefit
 * Allows additional logic to be added transparently without changing
 * the client or the real object.
 *
 * Trade-off
 * Adds an extra layer that may slightly increase complexity.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Structural patterns rely heavily on interfaces and composition.
 * Instead of inheritance alone, objects collaborate by containing
 * references to other objects.
 *
 * Key principles involved:
 *
 * - composition over inheritance
 * - interface-based design
 * - separation of responsibilities
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Component
 * A shared interface implemented by objects participating in a pattern.
 *
 * Wrapper
 * An object that contains another object and modifies its behavior.
 *
 * Subsystem
 * A group of classes that work together to perform a specific function.
 *
 * Hierarchy
 * A structure where objects are arranged in parent–child relationships.
 *
 * Proxy
 * An intermediary object that controls access to another object.
 */

public static class Examples
{
    // Demonstrates Adapter for incompatible API.
    public static void AdapterExample()
    {
        INotifier notifier = new EmailAdapter(new LegacyMailer());
        notifier.Notify("hello");
    }

    // Shows Decorator chaining extra behavior.
    public static void DecoratorExample()
    {
        IMessage msg = new TimestampDecorator(new PlainMessage());
        Console.WriteLine(msg.Get("event"));
    }

    // Demonstrates Facade simplification.
    public static void FacadeExample()
    {
        var facade = new OrderFacade();
        Console.WriteLine(facade.PlaceOrder());
    }

    // Shows Composite tree traversal behavior.
    public static void CompositeExample()
    {
        var root = new Folder("root");
        root.Add(new FileLeaf("a.txt"));
        root.Add(new FileLeaf("b.txt"));
        Console.WriteLine(root.Print());
    }

    // Demonstrates Proxy controlling access.
    public static void ProxyExample()
    {
        IReport report = new CachedReportProxy(new SlowReport());
        Console.WriteLine(report.Get());
    }
}

public interface INotifier { void Notify(string message); }
public class LegacyMailer { public void SendEmail(string body) => Console.WriteLine($"Email:{body}"); }
public class EmailAdapter(LegacyMailer mailer) : INotifier
{
    public void Notify(string message) => mailer.SendEmail(message);
}

public interface IMessage { string Get(string content); }
public class PlainMessage : IMessage { public string Get(string content) => content; }
public class TimestampDecorator(IMessage inner) : IMessage
{
    public string Get(string content) => $"[{DateTime.UtcNow:O}] {inner.Get(content)}";
}

public class Inventory { public bool Reserve() => true; }
public class Payment { public bool Charge() => true; }
public class Shipping { public bool Create() => true; }
public class OrderFacade
{
    public string PlaceOrder()
    {
        var ok = new Inventory().Reserve() && new Payment().Charge() && new Shipping().Create();
        return ok ? "Order placed" : "Order failed";
    }
}

public interface INode { string Print(); }
public class FileLeaf(string name) : INode { public string Print() => name; }
public class Folder(string name) : INode
{
    private readonly List<INode> _children = [];
    public void Add(INode node) => _children.Add(node);
    public string Print() => $"{name}:[{string.Join(",", _children.Select(c => c.Print()))}]";
}

public interface IReport { string Get(); }
public class SlowReport : IReport { public string Get() => "Report data"; }
public class CachedReportProxy(IReport real) : IReport
{
    private string? _cache;
    public string Get() => _cache ??= real.Get();
}






