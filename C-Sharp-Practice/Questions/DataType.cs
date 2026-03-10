namespace C_Sharp_Practice.Questions;

/*
 * TOPIC: C# Types / Value Types and Reference Types
 *
 * TOPIC DEFINITION
 * In C#, every type belongs to one of two fundamental categories:
 *
 * - Value Types
 * - Reference Types
 *
 * These categories determine how data is stored in memory,
 * how variables behave during assignment, and how data is
 * passed between methods.
 *
 * Value types store the actual data directly inside the variable.
 * Reference types store a reference that points to an object
 * located elsewhere in memory.
 *
 *
 * --------------------------------------------------------------------
 * VALUE TYPES
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * A value type is a type whose variable directly contains the data.
 *
 * When a value type variable is assigned to another variable,
 * the entire value is copied.
 *
 *
 * MEMORY STORAGE
 *
 * Value types are typically stored on the stack when declared
 * as local variables.
 *
 * However, value types can also exist on the heap when they are
 * fields inside reference types or elements of arrays.
 *
 *
 * ASSIGNMENT BEHAVIOR
 *
 * When assigning value types, the value itself is copied.
 *
 * Example:
 *
 * int a = 5;
 * int b = a;
 *
 * b = 10;
 *
 * The value of a remains 5 because b received its own copy.
 *
 *
 * COMMON VALUE TYPES
 *
 * Built-in value types include:
 *
 * - int
 * - double
 * - float
 * - bool
 * - char
 * - decimal
 * - DateTime
 *
 * Custom value types are defined using:
 *
 * - struct
 * - enum
 *
 *
 * EXAMPLE
 *
 * struct Point
 * {
 *     public int X;
 *     public int Y;
 * }
 *
 *
 * --------------------------------------------------------------------
 * REFERENCE TYPES
 * --------------------------------------------------------------------
 *
 * DEFINITION
 *
 * A reference type stores a reference (memory address) that
 * points to an object located in the heap.
 *
 * The variable itself does not contain the object data directly.
 *
 *
 * MEMORY STORAGE
 *
 * Reference type objects are allocated in heap memory.
 *
 * The variable stored in the stack contains a reference pointing
 * to that object.
 *
 *
 * ASSIGNMENT BEHAVIOR
 *
 * When assigning reference types, the reference is copied,
 * not the object itself.
 *
 * Example:
 *
 * Person p1 = new Person();
 * Person p2 = p1;
 *
 * Both variables refer to the same object in memory.
 *
 * If the object is modified through p2, the change is visible
 * through p1.
 *
 *
 * COMMON REFERENCE TYPES
 *
 * Examples include:
 *
 * - class
 * - string
 * - array
 * - object
 * - delegate
 *
 *
 * EXAMPLE
 *
 * class Person
 * {
 *     public string Name;
 * }
 *
 *
 * --------------------------------------------------------------------
 * MEMORY REPRESENTATION
 *
 * Example code:
 *
 * int x = 10;
 * Person p = new Person();
 *
 *
 * Stack
 *
 * x = 10
 * p → reference to heap object
 *
 *
 * Heap
 *
 * Person object
 *
 *
 * --------------------------------------------------------------------
 * METHOD PARAMETER BEHAVIOR
 *
 * Value types
 *
 * Passed by value by default.
 * A copy of the value is sent to the method.
 *
 *
 * Reference types
 *
 * The reference is copied, but both references point to the same
 * object in memory.
 *
 *
 * --------------------------------------------------------------------
 * PERFORMANCE CONSIDERATIONS
 *
 * Value types
 *
 * - usually faster to allocate
 * - no garbage collection overhead
 * - suitable for small data structures
 *
 *
 * Reference types
 *
 * - support complex object graphs
 * - managed by the garbage collector
 * - allow shared mutable state
 *
 *
 * --------------------------------------------------------------------
 * COMMON MISCONCEPTIONS
 *
 * "Value types are always stored on the stack."
 *
 * Not necessarily. They may also exist on the heap when contained
 * inside reference types.
 *
 *
 * "Reference types store their data on the stack."
 *
 * Incorrect. Only the reference is stored on the stack;
 * the object itself is stored on the heap.
 *
 *
 * --------------------------------------------------------------------
 * SUMMARY
 *
 * VALUE TYPES
 *
 * - store actual data
 * - copied during assignment
 * - commonly stored on stack
 * - examples: int, bool, struct
 *
 *
 * REFERENCE TYPES
 *
 * - store reference to object
 * - assignment copies reference
 * - objects stored on heap
 * - examples: class, string, array
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Value Type
 * A type that stores the actual data directly in the variable.
 *
 * Reference Type
 * A type where variables store references pointing to objects.
 *
 * Heap
 * Memory area used for dynamically allocated objects.
 *
 * Stack
 * Memory used for method execution and short-lived values.
 *
 * Reference
 * A pointer that identifies the memory location of an object.
 */