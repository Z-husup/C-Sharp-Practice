namespace C_Sharp_Practice.Questions;

/*
 * TOPIC: C# Types / Struct vs Class
 *
 * TOPIC DEFINITION
 * In C#, struct and class are two ways to define custom data types.
 * Both allow grouping data and behavior together, but they differ
 * fundamentally in how memory is allocated, how values are copied,
 * and how inheritance works.
 *
 * A class defines a reference type, while a struct defines a value type.
 * This distinction affects memory allocation, performance characteristics,
 * and object behavior when passed between methods or assigned to variables.
 *
 *
 * --------------------------------------------------------------------
 * CLASS (REFERENCE TYPE)
 * --------------------------------------------------------------------
 *
 * A class defines a reference type that is allocated on the heap.
 *
 * When a variable of a class type is created, the variable itself
 * stores a reference (memory address) pointing to an object located
 * in the heap.
 *
 * Example:
 *
 * class Person
 * {
 *     public string Name;
 * }
 *
 * Usage:
 *
 * Person p1 = new Person();
 * Person p2 = p1;
 *
 * In this example:
 *
 * - p1 and p2 store references
 * - both references point to the same object
 *
 * If the object is modified through one reference, the change is
 * visible through the other reference.
 *
 *
 * --------------------------------------------------------------------
 * STRUCT (VALUE TYPE)
 * --------------------------------------------------------------------
 *
 * A struct defines a value type.
 *
 * Value types store their data directly in the variable rather
 * than referencing an object on the heap.
 *
 * Struct instances are commonly stored in stack memory when used
 * as local variables.
 *
 * Example:
 *
 * struct Point
 * {
 *     public int X;
 *     public int Y;
 * }
 *
 * Usage:
 *
 * Point p1 = new Point { X = 1, Y = 2 };
 * Point p2 = p1;
 *
 * In this case:
 *
 * - p2 receives a copy of p1
 * - the two variables are completely independent
 *
 * Modifying p2 does not affect p1.
 *
 *
 * --------------------------------------------------------------------
 * MEMORY BEHAVIOR
 *
 * Class objects:
 *
 * Stack
 * → reference variable
 *
 * Heap
 * → actual object data
 *
 * Struct values:
 *
 * Stack
 * → actual struct data (when used locally)
 *
 * If a struct is stored inside a class or array, it may reside
 * inside heap memory as part of that object.
 *
 *
 * --------------------------------------------------------------------
 * ASSIGNMENT BEHAVIOR
 *
 * Class assignment:
 *
 * Person a = new Person();
 * Person b = a;
 *
 * Both variables refer to the same object.
 *
 *
 * Struct assignment:
 *
 * Point a = new Point();
 * Point b = a;
 *
 * The entire value is copied.
 *
 *
 * --------------------------------------------------------------------
 * METHOD PARAMETER BEHAVIOR
 *
 * Class parameters:
 *
 * Passing a class variable to a method passes the reference.
 *
 * The method can modify the object's internal state.
 *
 *
 * Struct parameters:
 *
 * Passing a struct passes a copy of the value unless the
 * parameter is declared with ref or in.
 *
 *
 * --------------------------------------------------------------------
 * INHERITANCE RULES
 *
 * Classes support inheritance.
 *
 * Example:
 *
 * class Animal {}
 * class Dog : Animal {}
 *
 * Structs cannot inherit from other structs or classes.
 *
 * However, structs can implement interfaces.
 *
 * Example:
 *
 * struct Point : IFormattable {}
 *
 *
 * --------------------------------------------------------------------
 * DEFAULT CONSTRUCTORS
 *
 * Classes can define custom constructors and support
 * parameterless constructors.
 *
 * Structs always have an implicit parameterless constructor
 * that initializes all fields to default values.
 *
 *
 * --------------------------------------------------------------------
 * PERFORMANCE CONSIDERATIONS
 *
 * Structs are typically used for:
 *
 * - small data structures
 * - immutable values
 * - performance-sensitive scenarios
 *
 * Classes are used for:
 *
 * - complex objects
 * - large data structures
 * - polymorphic behavior
 *
 *
 * --------------------------------------------------------------------
 * COMMON STRUCT EXAMPLES
 *
 * The .NET runtime includes many built-in structs:
 *
 * int
 * double
 * bool
 * DateTime
 * Guid
 *
 *
 * --------------------------------------------------------------------
 * SUMMARY COMPARISON
 *
 * class
 * → reference type
 * → stored on heap
 * → assignment copies reference
 * → supports inheritance
 *
 * struct
 * → value type
 * → usually stored on stack
 * → assignment copies value
 * → no inheritance
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Value Type
 * A type that stores the actual data directly in the variable.
 *
 * Reference Type
 * A type where variables store references pointing to objects
 * stored elsewhere in memory.
 *
 * Heap
 * Memory region where objects are dynamically allocated.
 *
 * Stack
 * Memory region used for method execution and short-lived values.
 *
 * Copy Semantics
 * Behavior where assigning a variable copies its entire value.
 *
 * Reference Semantics
 * Behavior where assigning a variable copies only the reference
 * to the same object.
 */

