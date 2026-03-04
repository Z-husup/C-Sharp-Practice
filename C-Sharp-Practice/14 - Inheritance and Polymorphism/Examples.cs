namespace C_Sharp_Practice.Inheritance_and_Polymorphism;

/*
 * TOPIC: Inheritance and Polymorphism
 *
 * TOPIC DEFINITION
 * Inheritance allows one class to reuse and extend the behavior of another class.
 * The class being inherited from is called the base class, and the class that
 * inherits from it is called the derived class.
 *
 * Polymorphism allows objects of different derived classes to be treated as
 * objects of the same base class. When a method is called on the base type,
 * the program executes the version of the method defined in the actual object
 * type at runtime.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * InheritanceExample
 * Demonstrates a simple inheritance relationship where a derived class
 * extends the behavior of a base class.
 *
 * PolymorphismExample
 * Shows polymorphism, where a base class reference refers to a derived
 * object and the correct method implementation is executed at runtime.
 *
 * UpcastingExample
 * Demonstrates upcasting, where a derived class object is treated as
 * its base class type. This happens automatically and is safe because
 * the derived object still contains the base class behavior.
 *
 * DowncastingExample
 * Shows downcasting, where a base class reference is cast back to a
 * derived class type. This is only valid if the object actually belongs
 * to that derived type.
 *
 * SealedOverrideExample
 * Demonstrates the use of the sealed keyword with an overridden method.
 * A sealed override prevents further derived classes from overriding
 * the method again.
 *
 * INTERNAL MECHANICS
 * - Base classes define common behavior shared by derived classes.
 * - The virtual keyword allows methods to be overridden in derived classes.
 * - The override keyword provides a new implementation of a base method.
 * - The runtime chooses which method implementation to execute based on
 *   the actual object type.
 *
 * TERMINOLOGY
 * Base Class: The class whose behavior is inherited.
 * Derived Class: A class that inherits from another class.
 * Inheritance: The mechanism that allows one class to reuse another class.
 * Polymorphism: The ability to treat different objects as the same base type.
 * Upcasting: Converting a derived class reference to its base type.
 * Downcasting: Converting a base class reference back to a derived type.
 */

public static class Examples
{
    // Demonstrates base and derived relationship.
    public static void InheritanceExample()
    {
        var dog = new Dog();
        dog.Speak();
    }

    // Shows runtime polymorphic dispatch.
    public static void PolymorphismExample()
    {
        Animal animal = new Dog();
        animal.Speak();
    }

    // Demonstrates upcasting and method dispatch.
    public static void UpcastingExample()
    {
        Dog dog = new Dog();
        Animal animal = dog;
        animal.Speak();
    }

    // Shows safe downcast with pattern matching.
    public static void DowncastingExample()
    {
        Animal animal = new Dog();
        if (animal is Dog dog)
        {
            dog.Fetch();
        }
    }

    // Demonstrates sealed override behavior.
    public static void SealedOverrideExample()
    {
        Animal pet = new GuardDog();
        pet.Speak();
    }
}

public class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
    public void Fetch() => Console.WriteLine("Fetching...");
}

public class GuardDog : Dog
{
    public sealed override void Speak() => Console.WriteLine("Loud woof");
}

