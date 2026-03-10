namespace C_Sharp_Practice.Questions;

/*
 * TOPIC: Object-Oriented Programming / Four Pillars of OOP
 *
 * TOPIC DEFINITION
 * Object-Oriented Programming (OOP) is a programming paradigm
 * based on organizing software into objects that combine data
 * and behavior.
 *
 * Instead of writing programs as sequences of functions,
 * OOP models systems as interacting objects that represent
 * real-world entities.
 *
 * The design of OOP systems is built around four fundamental
 * principles known as the four pillars of OOP:
 *
 * - Encapsulation
 * - Abstraction
 * - Inheritance
 * - Polymorphism
 *
 * These principles help developers create modular,
 * maintainable, and extensible software systems.
 *
 *
 * --------------------------------------------------------------------
 * ENCAPSULATION
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * Encapsulation is the principle of bundling data and the methods
 * that operate on that data inside a single unit (class) while
 * restricting direct access to internal implementation details.
 *
 * The internal state of an object is protected from uncontrolled
 * external modification.
 *
 *
 * PURPOSE
 *
 * Encapsulation protects object integrity and ensures that
 * internal data can only be modified through controlled methods.
 *
 * This prevents inconsistent states and reduces unintended side effects.
 *
 *
 * IMPLEMENTATION IN C#
 *
 * Encapsulation is achieved through access modifiers:
 *
 * - private
 * - protected
 * - public
 * - internal
 *
 * Fields are usually private and accessed through public methods
 * or properties.
 *
 *
 * EXAMPLE
 *
 * class BankAccount
 * {
 *     private decimal balance;
 *
 *     public void Deposit(decimal amount)
 *     {
 *         if (amount > 0)
 *             balance += amount;
 *     }
 *
 *     public decimal GetBalance()
 *     {
 *         return balance;
 *     }
 * }
 *
 * In this example:
 *
 * - the balance field cannot be modified directly
 * - all changes must go through controlled methods
 *
 *
 * --------------------------------------------------------------------
 * ABSTRACTION
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * Abstraction is the principle of exposing only the essential
 * features of an object while hiding unnecessary implementation details.
 *
 * The goal is to simplify interaction with complex systems by
 * focusing only on what an object does rather than how it works internally.
 *
 *
 * PURPOSE
 *
 * Abstraction reduces complexity and allows developers to interact
 * with high-level interfaces instead of low-level implementation logic.
 *
 *
 * IMPLEMENTATION IN C#
 *
 * Abstraction is typically implemented using:
 *
 * - interfaces
 * - abstract classes
 *
 *
 * EXAMPLE
 *
 * interface IPaymentProcessor
 * {
 *     void ProcessPayment(decimal amount);
 * }
 *
 * class CreditCardProcessor : IPaymentProcessor
 * {
 *     public void ProcessPayment(decimal amount)
 *     {
 *         Console.WriteLine("Processing credit card payment");
 *     }
 * }
 *
 * Here the consumer interacts with the interface
 * without knowing how the payment is processed internally.
 *
 *
 * --------------------------------------------------------------------
 * INHERITANCE
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * Inheritance allows one class to acquire the properties and
 * behavior of another class.
 *
 * The class that provides functionality is called the base class
 * (or parent class), while the class that inherits from it is
 * called the derived class (or child class).
 *
 *
 * PURPOSE
 *
 * Inheritance promotes code reuse and establishes hierarchical
 * relationships between types.
 *
 *
 * IMPLEMENTATION IN C#
 *
 * Inheritance is declared using the ":" syntax.
 *
 *
 * EXAMPLE
 *
 * class Animal
 * {
 *     public void Eat()
 *     {
 *         Console.WriteLine("Eating");
 *     }
 * }
 *
 * class Dog : Animal
 * {
 *     public void Bark()
 *     {
 *         Console.WriteLine("Bark");
 *     }
 * }
 *
 * The Dog class inherits the Eat() method from Animal.
 *
 *
 * --------------------------------------------------------------------
 * POLYMORPHISM
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * Polymorphism allows objects of different types to be treated
 * as objects of a common base type while each type provides
 * its own implementation of behavior.
 *
 * The word polymorphism means "many forms".
 *
 *
 * TYPES OF POLYMORPHISM
 *
 * Compile-time polymorphism
 *
 * Achieved through method overloading where multiple methods
 * share the same name but different parameters.
 *
 *
 * Runtime polymorphism
 *
 * Achieved through method overriding using inheritance
 * and virtual methods.
 *
 *
 * EXAMPLE
 *
 * class Animal
 * {
 *     public virtual void Speak()
 *     {
 *         Console.WriteLine("Animal sound");
 *     }
 * }
 *
 * class Dog : Animal
 * {
 *     public override void Speak()
 *     {
 *         Console.WriteLine("Bark");
 *     }
 * }
 *
 * Animal animal = new Dog();
 * animal.Speak();
 *
 * Even though the variable type is Animal,
 * the Dog implementation is executed.
 *
 *
 * --------------------------------------------------------------------
 * SUMMARY OF THE FOUR PILLARS
 *
 * Encapsulation
 * Protects internal data by restricting access.
 *
 * Abstraction
 * Hides implementation details and exposes only essential behavior.
 *
 * Inheritance
 * Allows classes to reuse functionality from other classes.
 *
 * Polymorphism
 * Allows the same interface to represent different underlying behavior.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS OF OOP
 *
 * Modularity
 * Systems are divided into independent components.
 *
 * Maintainability
 * Code changes can be localized within classes.
 *
 * Reusability
 * Classes and behaviors can be reused across systems.
 *
 * Extensibility
 * New functionality can be added with minimal changes
 * to existing code.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Object
 * An instance of a class containing data and behavior.
 *
 * Class
 * A blueprint that defines object structure and behavior.
 *
 * Base Class
 * The parent class from which other classes inherit.
 *
 * Derived Class
 * A class that inherits from another class.
 *
 * Interface
 * A contract that defines behavior without implementation.
 */