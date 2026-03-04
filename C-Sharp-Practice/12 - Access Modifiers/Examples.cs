namespace C_Sharp_Practice.Access_Modifiers;

/*
 * TOPIC: Access Modifiers
 *
 * TOPIC DEFINITION
 * Access modifiers in C# control the visibility of classes, methods,
 * properties, and other members. They determine where a member can be
 * accessed from within a program.
 *
 * Access modifiers are used to protect data and enforce encapsulation,
 * ensuring that internal implementation details are hidden from parts
 * of the program that should not access them directly.
 *
 * The most commonly used access modifiers in C# are:
 * - public
 * - private
 * - protected
 * - internal
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * PublicExample
 * Demonstrates the use of the public modifier. Public members can be
 * accessed from any part of the program.
 *
 * PrivateExample
 * Shows how private members are restricted to the class in which they
 * are defined. Access to private data is usually provided through
 * public methods.
 *
 * ProtectedExample
 * Demonstrates the protected modifier. Protected members are accessible
 * inside the defining class and in classes that inherit from it.
 *
 * InternalExample
 * Shows the use of the internal modifier. Internal members can be
 * accessed from any code within the same assembly but not from other
 * assemblies.
 *
 * EncapsulationExample
 * Demonstrates how access modifiers support encapsulation by preventing
 * direct modification of internal data and exposing controlled methods
 * instead.
 *
 * INTERNAL MECHANICS
 * - Access modifiers are enforced by the compiler.
 * - They restrict which parts of the program can access certain members.
 * - Proper use of access modifiers helps maintain clear program structure
 *   and prevents unintended data modification.
 *
 * TERMINOLOGY
 * Access Modifier: A keyword that controls the visibility of a member.
 * Public: Accessible from any code.
 * Private: Accessible only within the same class.
 * Protected: Accessible within the class and its derived classes.
 * Internal: Accessible within the same assembly.
 * Encapsulation: Restricting access to internal data and exposing it
 *                through controlled methods or properties.
 */

public static class Examples
{
    // Demonstrates public member access.
    public static void PublicExample()
    {
        var sample = new VisibilitySample();
        Console.WriteLine(sample.PublicValue);
    }

    // Shows private access via public method.
    public static void PrivateExample()
    {
        var sample = new VisibilitySample();
        sample.SetSecret(99);
        Console.WriteLine(sample.GetSecret());
    }

    // Demonstrates protected usage through inheritance.
    public static void ProtectedExample()
    {
        var child = new DerivedVisibility();
        child.ShowProtected();
    }

    // Shows internal member usage within same assembly.
    public static void InternalExample()
    {
        var sample = new VisibilitySample();
        Console.WriteLine(sample.InternalValue);
    }

    // Demonstrates encapsulation by restricting direct mutation.
    public static void EncapsulationExample()
    {
        var sample = new VisibilitySample();
        sample.SetSecret(123);
        Console.WriteLine(sample.GetSecret());
    }
}

public class VisibilitySample
{
    public int PublicValue { get; } = 10;
    internal int InternalValue { get; } = 20;
    private int Secret { get; set; }
    protected int ProtectedValue { get; } = 30;

    public void SetSecret(int value) => Secret = value;
    public int GetSecret() => Secret;
}

public class DerivedVisibility : VisibilitySample
{
    public void ShowProtected() => Console.WriteLine(ProtectedValue);
}


