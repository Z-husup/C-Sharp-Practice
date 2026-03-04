namespace C_Sharp_Practice.Delegates_and_Events;

/*
 * TOPIC: Delegates and Events
 *
 * TOPIC DEFINITION
 * A delegate in C# is a type that represents a reference to a method.
 * It allows methods to be passed as parameters, stored in variables,
 * and invoked dynamically. Delegates are commonly used to implement
 * callbacks and flexible program behavior.
 *
 * Events are built on delegates and are used to implement the
 * publisher–subscriber pattern. An object can publish an event,
 * and other objects can subscribe to be notified when that event occurs.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * DelegateExample
 * Demonstrates creating a custom delegate and assigning a method
 * to it. The delegate can then be invoked like a method.
 *
 * ActionExample
 * Shows the built-in Action delegate type. Action represents a
 * method that does not return a value.
 *
 * FuncExample
 * Shows the built-in Func delegate type. Func represents a method
 * that returns a value.
 *
 * EventExample
 * Demonstrates defining and raising an event. Other code can
 * subscribe to the event and react when it occurs.
 *
 * UnsubscribeExample
 * Shows how to remove an event handler from an event so that
 * it no longer receives notifications.
 *
 * INTERNAL MECHANICS
 * - Delegates store references to methods with matching signatures.
 * - Action and Func are predefined delegate types in .NET.
 * - Events use delegates to notify subscribed handlers.
 * - Multiple handlers can subscribe to the same event.
 *
 * TERMINOLOGY
 * Delegate: A type that represents a reference to a method.
 * Callback: A method that is passed to another method to be invoked later.
 * Event: A mechanism that allows objects to notify others when something happens.
 * Subscriber: An object that listens for an event.
 * Publisher: The object that raises the event.
 */

public static class Examples
{
    // Demonstrates custom delegate assignment and invocation.
    public static void DelegateExample()
    {
        Operation op = Add;
        Console.WriteLine(op(2, 3));
    }

    // Shows Action delegate for void methods.
    public static void ActionExample()
    {
        Action<string> action = message => Console.WriteLine(message);
        action("Hello");
    }

    // Shows Func delegate for value-returning lambdas.
    public static void FuncExample()
    {
        Func<int, int, int> multiply = (a, b) => a * b;
        Console.WriteLine(multiply(4, 5));
    }

    // Demonstrates event subscription and publishing.
    public static void EventExample()
    {
        var timer = new SimpleTimer();
        timer.Tick += (_, msg) => Console.WriteLine(msg);
        timer.RaiseTick();
    }

    // Shows unsubscribing from an event.
    public static void UnsubscribeExample()
    {
        var timer = new SimpleTimer();
        EventHandler<string> handler = (_, msg) => Console.WriteLine(msg);
        timer.Tick += handler;
        timer.Tick -= handler;
        timer.RaiseTick();
    }

    private static int Add(int a, int b) => a + b;
    private delegate int Operation(int a, int b);
}

public class SimpleTimer
{
    public event EventHandler<string>? Tick;

    public void RaiseTick()
    {
        Tick?.Invoke(this, "Tick event fired");
    }
}




