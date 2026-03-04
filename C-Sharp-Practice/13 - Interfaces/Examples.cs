namespace C_Sharp_Practice.Interfaces;

/*
 * TOPIC: Interfaces
 *
 * TOPIC DEFINITION
 * An interface in C# defines a set of methods or properties that a class
 * must implement. It describes what behavior a class should provide
 * without specifying how that behavior is implemented.
 *
 * Interfaces are commonly used to create flexible and reusable code.
 * Different classes can implement the same interface, allowing them to
 * be used interchangeably through a common abstraction.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BasicExample
 * Demonstrates how a class implements an interface and how an object
 * can be used through the interface type.
 *
 * MultipleInterfaceExample
 * Shows that a class can implement multiple interfaces, allowing it to
 * provide several types of behavior.
 *
 * DependencyExample
 * Demonstrates depending on an interface rather than a specific class.
 * This allows the implementation to be changed without modifying the
 * code that uses it.
 *
 * CollectionExample
 * Shows how multiple objects implementing the same interface can be
 * stored in a collection and used interchangeably.
 *
 * CastExample
 * Demonstrates checking whether an object implements an interface and
 * safely casting it to that interface type.
 *
 * INTERNAL MECHANICS
 * - An interface defines method signatures but no implementation.
 * - Classes that implement an interface must provide implementations
 *   for all its members.
 * - Interface types allow polymorphism by treating different objects
 *   as the same type if they implement the same interface.
 *
 * TERMINOLOGY
 * Interface: A contract that defines required methods or properties.
 * Implementation: The concrete code provided by a class for an interface.
 * Polymorphism: The ability to use different objects through the same interface.
 * Abstraction: Hiding implementation details and exposing only necessary behavior.
 */

public static class Examples
{
    // Demonstrates interface-based polymorphism.
    public static void BasicExample()
    {
        IPrinter printer = new ConsolePrinter();
        printer.Print("hello");
    }

    // Shows multiple interfaces on one class.
    public static void MultipleInterfaceExample()
    {
        var device = new MultiFunctionDevice();
        device.Print("doc");
        device.Scan();
    }

    // Demonstrates dependency on abstraction rather than implementation.
    public static void DependencyExample()
    {
        var service = new ReportService(new ConsolePrinter());
        service.Generate();
    }

    // Shows interface collection for interchangeable implementations.
    public static void CollectionExample()
    {
        List<IPrinter> printers = [new ConsolePrinter(), new UpperPrinter()];
        foreach (var p in printers) p.Print("sample");
    }

    // Demonstrates casting an object to an interface type.
    public static void CastExample()
    {
        object obj = new ConsolePrinter();
        if (obj is IPrinter printer)
        {
            printer.Print("cast success");
        }
    }
}

public interface IPrinter
{
    void Print(string text);
}

public interface IScanner
{
    void Scan();
}

public class ConsolePrinter : IPrinter
{
    public void Print(string text) => Console.WriteLine(text);
}

public class UpperPrinter : IPrinter
{
    public void Print(string text) => Console.WriteLine(text.ToUpperInvariant());
}

public class MultiFunctionDevice : IPrinter, IScanner
{
    public void Print(string text) => Console.WriteLine($"Printing {text}");
    public void Scan() => Console.WriteLine("Scanning...");
}

public class ReportService(IPrinter printer)
{
    public void Generate() => printer.Print("Report generated");
}



