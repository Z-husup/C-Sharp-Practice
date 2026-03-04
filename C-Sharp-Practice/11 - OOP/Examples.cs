namespace C_Sharp_Practice.OOP;

/*
 * TOPIC: Object-Oriented Programming (OOP)
 *
 * TOPIC DEFINITION
 * Object-Oriented Programming (OOP) is a programming paradigm that organizes
 * software around objects. An object combines data (fields or properties)
 * and behavior (methods) into a single unit.
 *
 * OOP helps structure programs so they are easier to understand, reuse,
 * and maintain. The main principles of OOP in C# include encapsulation,
 * inheritance, polymorphism, and abstraction.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * InheritanceExample
 * Demonstrates inheritance, where one class derives from another class.
 * The derived class can reuse and extend the behavior of the base class.
 *
 * PolymorphismExample
 * Shows polymorphism, where objects of different classes can be treated
 * as objects of a common base type. The correct method implementation
 * is chosen at runtime.
 *
 * EncapsulationExample
 * Demonstrates encapsulation by protecting internal data and controlling
 * how it is accessed. In this example, the Balance property can only be
 * modified through the Deposit method.
 *
 * InterfaceExample
 * Shows the use of interfaces. An interface defines a contract that classes
 * must implement. Any class implementing the interface must provide the
 * required methods.
 *
 * AbstractionExample
 * Demonstrates abstraction using an abstract class. Abstract classes define
 * common behavior that derived classes must implement.
 *
 * INTERNAL MECHANICS
 * - Classes define the structure and behavior of objects.
 * - Inheritance allows classes to reuse and extend existing code.
 * - Virtual and override methods enable runtime polymorphism.
 * - Interfaces define behavior contracts without providing implementation.
 * - Abstract classes define base functionality while requiring subclasses
 *   to implement specific details.
 *
 * TERMINOLOGY
 * Class: A blueprint used to create objects.
 * Object: An instance of a class containing data and behavior.
 * Encapsulation: Protecting data and exposing it through controlled methods.
 * Inheritance: Creating a new class based on an existing class.
 * Polymorphism: Allowing different objects to respond to the same method call.
 * Interface: A contract that defines methods a class must implement.
 * Abstraction: Hiding implementation details while exposing essential behavior.
 */

public static class Examples
{
    // Demonstrates inheritance and overridden behavior.
    public static void InheritanceExample()
    {
        Animal animal = new Dog();
        animal.Speak();
    }

    // Shows runtime dispatch through a base abstraction.
    public static void PolymorphismExample()
    {
        List<Animal> animals = [new Dog(), new Cat()];
        foreach (var a in animals) a.Speak();
    }

    // Demonstrates protected state access through methods/properties.
    public static void EncapsulationExample()
    {
        var bank = new BankAccount();
        bank.Deposit(100);
        Console.WriteLine(bank.Balance);
    }

    // Shows behavior contracts via interface implementation.
    public static void InterfaceExample()
    {
        IMovable mover = new Car();
        mover.Move();
    }

    // Demonstrates abstract base types and concrete specialization.
    public static void AbstractionExample()
    {
        Shape shape = new Circle(3);
        Console.WriteLine(shape.Area());
    }
}

public class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
}

public class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow");
}

public class BankAccount
{
    public decimal Balance { get; private set; }
    public void Deposit(decimal amount) => Balance += amount;
}

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move() => Console.WriteLine("Car moving");
}

public abstract class Shape
{
    public abstract double Area();
}

public class Circle(double radius) : Shape
{
    public override double Area() => System.Math.PI * radius * radius;
}

