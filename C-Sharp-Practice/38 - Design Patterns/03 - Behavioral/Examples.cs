namespace C_Sharp_Practice.Design_Patterns.Behavioral;

/*
 * TOPIC: Design Patterns / Behavioral
 *
 * TOPIC DEFINITION
 * Behavioral design patterns focus on how objects communicate and
 * cooperate with each other at runtime. While creational patterns
 * control how objects are created and structural patterns organize
 * objects into larger structures, behavioral patterns define how
 * responsibilities are distributed between objects.
 *
 * As systems grow, direct communication between components can create
 * rigid dependencies. Behavioral patterns solve this by introducing
 * well-defined collaboration structures that allow objects to interact
 * in flexible and maintainable ways.
 *
 * These patterns help:
 *
 * - reduce tight coupling between components
 * - encapsulate algorithms and policies
 * - organize communication between objects
 * - distribute responsibilities clearly
 * - support runtime behavior changes
 *
 * The behavioral patterns demonstrated in this file are:
 *
 * Strategy
 * Observer
 * Command
 * State
 * Chain of Responsibility
 *
 *
 * --------------------------------------------------------------------
 * PATTERN EXPLANATIONS
 * --------------------------------------------------------------------
 *
 * STRATEGY PATTERN
 *
 * Problem
 * A class may need to support multiple algorithms or policies for
 * performing the same task. Embedding all possible algorithms inside
 * the class results in complex conditional logic and makes the system
 * difficult to extend.
 *
 * Example:
 * A tax calculator may apply different tax strategies depending on
 * country, region, or special conditions.
 *
 * Solution
 * The Strategy pattern extracts each algorithm into a separate class
 * implementing a shared interface. The main object receives the
 * strategy as a dependency and delegates the computation to it.
 *
 * Structure
 *
 * Client → Context → Strategy Interface → Concrete Strategy
 *
 * Benefit
 * Algorithms can be replaced at runtime without modifying the context.
 *
 * Trade-off
 * Increases the number of classes in the system.
 *
 *
 * --------------------------------------------------------------------
 *
 * OBSERVER PATTERN
 *
 * Problem
 * Many systems require components to react to changes in another
 * object. Directly coupling these components would create complex
 * dependencies.
 *
 * Example:
 * When a stock price changes, multiple systems such as dashboards,
 * alerts, and trading algorithms may need to react.
 *
 * Solution
 * The Observer pattern allows objects (observers) to subscribe to
 * another object (the subject). When the subject's state changes,
 * it automatically notifies all registered observers.
 *
 * Structure
 *
 * Subject → Event/Notification → Observers
 *
 * Benefit
 * Supports loose coupling between event producers and consumers.
 *
 * Trade-off
 * Large numbers of observers can make debugging event flows difficult.
 *
 *
 * --------------------------------------------------------------------
 *
 * COMMAND PATTERN
 *
 * Problem
 * Sometimes an operation needs to be represented as an object so that
 * it can be queued, logged, stored, or executed later.
 *
 * Example:
 * A graphical application may store user actions such as "save",
 * "undo", or "delete".
 *
 * Solution
 * The Command pattern encapsulates a request as an object containing
 * the logic needed to execute the operation.
 *
 * Structure
 *
 * Client → Command Object → Receiver
 *                 ↑
 *              Invoker
 *
 * Benefit
 * Commands can be queued, logged, or undone.
 *
 * Trade-off
 * Introduces additional classes for each command.
 *
 *
 * --------------------------------------------------------------------
 *
 * STATE PATTERN
 *
 * Problem
 * Objects sometimes change their behavior depending on their internal
 * state. Implementing this using large conditional statements can make
 * the code difficult to maintain.
 *
 * Example:
 * A traffic light behaves differently depending on whether it is in
 * red, green, or yellow state.
 *
 * Solution
 * The State pattern represents each state as a separate object that
 * defines behavior for that state. The context object delegates its
 * behavior to the current state.
 *
 * Structure
 *
 * Context → Current State → State Behavior
 *
 * Benefit
 * Eliminates complex conditional logic and isolates state-specific
 * behavior.
 *
 * Trade-off
 * May increase the number of classes.
 *
 *
 * --------------------------------------------------------------------
 *
 * CHAIN OF RESPONSIBILITY PATTERN
 *
 * Problem
 * A request may be handled by one of several objects, but the sender
 * should not need to know which object will handle it.
 *
 * Example:
 * In an authentication pipeline, requests may pass through multiple
 * handlers such as authentication, validation, and authorization.
 *
 * Solution
 * The Chain of Responsibility pattern organizes handlers into a chain.
 * Each handler decides whether to process the request or pass it to
 * the next handler.
 *
 * Structure
 *
 * Client → Handler → Handler → Handler
 *
 * Benefit
 * Allows flexible request routing and decouples sender from receiver.
 *
 * Trade-off
 * Requests may travel through multiple handlers before being processed.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Behavioral patterns often rely on interfaces and composition to
 * organize interactions between objects.
 *
 * Key principles involved:
 *
 * - separating responsibilities between components
 * - delegating behavior to specialized objects
 * - decoupling senders from receivers
 * - allowing runtime flexibility in behavior selection
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Context
 * The main object that delegates part of its behavior to another object.
 *
 * Strategy
 * A replaceable algorithm used by a context object.
 *
 * Observer
 * An object that receives notifications about changes in another object.
 *
 * Command
 * An object that encapsulates an action to be executed.
 *
 * State
 * An object representing a specific condition of a system.
 *
 * Handler
 * An object responsible for processing or forwarding a request.
 */

public static class Examples
{
    // Demonstrates Strategy algorithm swapping.
    public static void StrategyExample()
    {
        var calc = new TaxCalculator(new FlatTax());
        Console.WriteLine(calc.Calculate(100));
    }

    // Shows Observer notification pattern.
    public static void ObserverExample()
    {
        var stock = new StockTicker();
        stock.PriceChanged += (_, p) => Console.WriteLine($"Price:{p}");
        stock.SetPrice(120m);
    }

    // Demonstrates Command execution encapsulation.
    public static void CommandExample()
    {
        ICommand command = new SaveCommand();
        new Invoker().Run(command);
    }

    // Shows State-based behavior transitions.
    public static void StateExample()
    {
        var traffic = new TrafficLight();
        Console.WriteLine(traffic.Current());
        traffic.Next();
        Console.WriteLine(traffic.Current());
    }

    // Demonstrates Chain of Responsibility handling flow.
    public static void ChainExample()
    {
        var auth = new AuthHandler();
        var validation = new ValidationHandler();
        auth.SetNext(validation);
        Console.WriteLine(auth.Handle("token"));
    }
}

public interface ITaxStrategy { decimal Apply(decimal total); }
public class FlatTax : ITaxStrategy { public decimal Apply(decimal total) => total * 0.1m; }
public class ReducedTax : ITaxStrategy { public decimal Apply(decimal total) => total * 0.05m; }
public class TaxCalculator(ITaxStrategy strategy) { public decimal Calculate(decimal total) => total + strategy.Apply(total); }

public class StockTicker
{
    public event EventHandler<decimal>? PriceChanged;
    public void SetPrice(decimal price) => PriceChanged?.Invoke(this, price);
}

public interface ICommand { void Execute(); }
public class SaveCommand : ICommand { public void Execute() => Console.WriteLine("Saved"); }
public class Invoker { public void Run(ICommand command) => command.Execute(); }

public class TrafficLight
{
    private int _index;
    private readonly string[] _states = ["Red", "Green", "Yellow"];
    public void Next() => _index = (_index + 1) % _states.Length;
    public string Current() => _states[_index];
}

public abstract class Handler
{
    private Handler? _next;
    public void SetNext(Handler next) => _next = next;
    public virtual string Handle(string request) => _next?.Handle(request) ?? "Unhandled";
}
public class AuthHandler : Handler
{
    public override string Handle(string request)
    {
        if (request == "token") return base.Handle(request);
        return "Unauthorized";
    }
}
public class ValidationHandler : Handler
{
    public override string Handle(string request) => request.Length > 0 ? "Processed" : "Invalid";
}






