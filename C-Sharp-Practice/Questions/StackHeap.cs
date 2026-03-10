namespace C_Sharp_Practice.Questions;

/*
 * TOPIC: Memory Management / Stack and Heap
 *
 * TOPIC DEFINITION
 * Stack and heap are two primary memory regions used by the .NET
 * runtime to store data during program execution.
 *
 * The stack is used for short-lived data such as method calls,
 * parameters, and value types. The heap is used for dynamically
 * allocated objects whose lifetime may extend beyond a single
 * method call.
 *
 * Understanding the difference between stack and heap memory
 * is essential for reasoning about performance, memory allocation,
 * and garbage collection behavior in C# applications.
 *
 *
 * --------------------------------------------------------------------
 * STACK MEMORY
 * --------------------------------------------------------------------
 *
 * The stack is a region of memory used to store execution context
 * for method calls.
 *
 * Each time a method is called, a new stack frame is created.
 *
 * A stack frame typically contains:
 *
 * - method parameters
 * - local variables
 * - return address
 * - temporary values used during execution
 *
 * Stack memory follows a Last-In-First-Out (LIFO) structure.
 *
 * Example:
 *
 * Main()
 *   calls MethodA()
 *       calls MethodB()
 *
 * The stack frames are created in this order:
 *
 * Main → MethodA → MethodB
 *
 * When MethodB finishes execution, its stack frame is removed.
 * Then MethodA continues execution.
 *
 *
 * --------------------------------------------------------------------
 * STACK CHARACTERISTICS
 * --------------------------------------------------------------------
 *
 * Automatic memory management
 *
 * Stack memory is automatically allocated and released when
 * methods are entered and exited.
 *
 * Very fast allocation
 *
 * Allocation simply moves the stack pointer to a new position.
 *
 * Limited size
 *
 * The stack is relatively small compared to heap memory.
 *
 * Value types storage
 *
 * Value types such as int, double, and struct are typically stored
 * directly in the stack frame when declared as local variables.
 *
 *
 * --------------------------------------------------------------------
 * HEAP MEMORY
 * --------------------------------------------------------------------
 *
 * The heap is a large memory region used for dynamic memory allocation.
 *
 * Objects created with the "new" keyword are allocated on the heap.
 *
 * Example:
 *
 * var user = new User();
 *
 * The object instance is stored on the heap, while the reference
 * to that object is stored in the stack.
 *
 *
 * --------------------------------------------------------------------
 * HEAP CHARACTERISTICS
 * --------------------------------------------------------------------
 *
 * Dynamic allocation
 *
 * Objects can be created and destroyed during program execution.
 *
 * Larger memory space
 *
 * The heap typically contains much more memory than the stack.
 *
 * Garbage collection
 *
 * Memory is automatically reclaimed by the .NET garbage collector
 * when objects are no longer referenced.
 *
 * Reference types storage
 *
 * Classes, arrays, strings, and objects are allocated on the heap.
 *
 *
 * --------------------------------------------------------------------
 * STACK VS HEAP STORAGE MODEL
 *
 * Example:
 *
 * int number = 5;
 * Person person = new Person();
 *
 * Stack memory:
 *
 * number = 5
 * person → reference address
 *
 * Heap memory:
 *
 * Person object
 *
 * The variable "person" stored on the stack contains a reference
 * pointing to the object stored on the heap.
 *
 *
 * --------------------------------------------------------------------
 * GARBAGE COLLECTION
 * --------------------------------------------------------------------
 *
 * The heap is managed by the .NET garbage collector.
 *
 * When objects are no longer referenced, the garbage collector
 * eventually frees their memory.
 *
 * The garbage collector runs periodically and performs tasks such as:
 *
 * - identifying unreachable objects
 * - reclaiming memory
 * - compacting heap memory
 *
 * Stack memory does not require garbage collection because
 * stack frames are automatically removed when methods return.
 *
 *
 * --------------------------------------------------------------------
 * PERFORMANCE CONSIDERATIONS
 *
 * Stack allocation is extremely fast because it only involves
 * moving a pointer.
 *
 * Heap allocation is slower because memory must be managed
 * by the runtime and garbage collector.
 *
 * Frequent heap allocations can increase garbage collection
 * overhead.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Stack pointer
 *
 * A pointer indicating the top of the current stack frame.
 *
 * Stack frames
 *
 * Data structures representing active method calls.
 *
 * Heap segments
 *
 * The heap is divided into regions used by the garbage collector.
 *
 * Object references
 *
 * Stack variables may contain references pointing to objects
 * stored in heap memory.
 *
 *
 * --------------------------------------------------------------------
 * COMMON MISCONCEPTIONS
 *
 * Value types are always stored on the stack.
 *
 * Not always. Value types can also exist on the heap when they
 * are fields of reference types or elements of arrays.
 *
 * Reference types are stored on the stack.
 *
 * Incorrect. Only references are stored on the stack. The actual
 * object lives on the heap.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Stack
 * Memory region used for method execution context and
 * short-lived variables.
 *
 * Heap
 * Memory region used for dynamically allocated objects.
 *
 * Stack Frame
 * Data structure representing a single method call.
 *
 * Reference
 * A pointer that refers to the memory location of an object.
 *
 * Garbage Collection
 * Automatic memory management system used to reclaim heap memory.
 */