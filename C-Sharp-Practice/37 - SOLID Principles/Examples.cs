namespace C_Sharp_Practice.SOLID_Principles;

/*
 * TOPIC: SOLID Principles
 *
 * TOPIC DEFINITION
 * SOLID is a set of five design principles that help developers write
 * maintainable, flexible, and scalable object-oriented software.
 *
 * These principles guide how classes and dependencies should be
 * structured so that code is easier to extend, test, and modify.
 *
 * SOLID stands for:
 *
 * S – Single Responsibility Principle (SRP)
 * O – Open/Closed Principle (OCP)
 * L – Liskov Substitution Principle (LSP)
 * I – Interface Segregation Principle (ISP)
 * D – Dependency Inversion Principle (DIP)
 *
 * Applying these principles reduces tight coupling and improves
 * modular design.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * SrpExample
 * Demonstrates the Single Responsibility Principle.
 * A class should have only one responsibility or reason to change.
 * In this example, building a report and printing a report are handled
 * by separate classes.
 *
 * OcpExample
 * Demonstrates the Open/Closed Principle.
 * Software entities should be open for extension but closed for
 * modification. New discount types can be added without changing
 * existing code.
 *
 * DipExample
 * Demonstrates the Dependency Inversion Principle.
 * High-level modules should depend on abstractions rather than
 * concrete implementations. The NotificationService depends on
 * the IMessageSender interface instead of a specific sender.
 *
 * IspExample
 * Demonstrates the Interface Segregation Principle.
 * Large interfaces should be split into smaller, focused ones so
 * classes only implement what they actually need.
 *
 * LspExample
 * Demonstrates the Liskov Substitution Principle.
 * Objects of derived classes must be usable wherever the base class
 * is expected without breaking program behavior.
 *
 * INTERNAL MECHANICS
 * - SRP reduces complexity by separating responsibilities.
 * - OCP allows systems to grow without modifying existing logic.
 * - DIP decouples components through abstractions.
 * - ISP prevents classes from depending on unused methods.
 * - LSP ensures derived classes behave correctly when substituted.
 *
 * TERMINOLOGY
 *
 * Responsibility
 * A specific role or task assigned to a class.
 *
 * Abstraction
 * A simplified interface that hides implementation details.
 *
 * Coupling
 * The degree of dependency between components.
 *
 * Substitution
 * Replacing a base class object with a derived class object
 * while maintaining correct behavior.
 */

public static class Examples
{
    // Demonstrates SRP with separate responsibilities.
    public static void SrpExample()
    {
        var report = new ReportBuilder().Build();
        new ReportPrinter().Print(report);
    }

    // Shows OCP by adding new discount strategy without editing consumer.
    public static void OcpExample()
    {
        IDiscount discount = new VipDiscount();
        Console.WriteLine(discount.Apply(100));
    }

    // Demonstrates DIP with abstraction dependency.
    public static void DipExample()
    {
        var service = new NotificationService(new EmailSender());
        service.Send("hello");
    }

    // Shows ISP by splitting large interface.
    public static void IspExample()
    {
        IPrinter printer = new OfficeDevice();
        printer.Print("doc");
    }

    // Demonstrates LSP with subtype substitution.
    public static void LspExample()
    {
        Bird bird = new Sparrow();
        bird.Move();
    }
}

public class ReportBuilder { public string Build() => "Report"; }
public class ReportPrinter { public void Print(string content) => Console.WriteLine(content); }

public interface IDiscount { decimal Apply(decimal total); }
public class VipDiscount : IDiscount { public decimal Apply(decimal total) => total * 0.8m; }

public interface IMessageSender { void Send(string message); }
public class EmailSender : IMessageSender { public void Send(string message) => Console.WriteLine($"Email: {message}"); }
public class NotificationService(IMessageSender sender) { public void Send(string msg) => sender.Send(msg); }

public interface IPrinter { void Print(string text); }
public interface IScanner { void Scan(); }

public class OfficeDevice : IPrinter, IScanner
{
    public void Print(string text) => Console.WriteLine(text);
    public void Scan() => Console.WriteLine("scan");
}

public abstract class Bird { public abstract void Move(); }
public class Sparrow : Bird { public override void Move() => Console.WriteLine("Fly"); }





