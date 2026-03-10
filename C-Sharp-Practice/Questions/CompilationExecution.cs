namespace C_Sharp_Practice.Questions;


/*
 * TOPIC: C# Program Compilation and Execution
 *
 * TOPIC DEFINITION
 * The compilation and execution of a C# program is a multi-stage
 * process in which source code written by a developer is transformed
 * into machine instructions that the computer can execute.
 *
 * Unlike languages that compile directly to machine code,
 * C# uses an intermediate execution model built around the
 * .NET runtime environment.
 *
 * The process includes several major stages:
 *
 * 1. Source code compilation
 * 2. Intermediate Language generation
 * 3. Assembly creation
 * 4. Runtime loading
 * 5. Just-In-Time compilation
 * 6. Execution by the CPU
 *
 * These stages allow the same compiled program to run on different
 * systems that support the .NET runtime.
 *
 *
 * --------------------------------------------------------------------
 * STEP 1: SOURCE CODE
 * --------------------------------------------------------------------
 *
 * The process begins with a developer writing C# source code
 * in files that typically use the ".cs" extension.
 *
 * Example:
 *
 * class Program
 * {
 *     static void Main()
 *     {
 *         Console.WriteLine("Hello");
 *     }
 * }
 *
 * This code is human-readable and must be compiled before execution.
 *
 *
 * --------------------------------------------------------------------
 * STEP 2: C# COMPILATION
 * --------------------------------------------------------------------
 *
 * The C# compiler (csc) translates the source code into an
 * intermediate representation called Intermediate Language (IL).
 *
 * During compilation the compiler performs:
 *
 * Syntax analysis
 * Verifies the code follows C# language grammar.
 *
 * Semantic analysis
 * Ensures variables, types, and method calls are valid.
 *
 * Type checking
 * Ensures operations use compatible types.
 *
 * Metadata generation
 * Produces information about classes, methods, and fields.
 *
 * If errors occur during compilation, the program will not
 * produce an executable assembly.
 *
 *
 * --------------------------------------------------------------------
 * STEP 3: INTERMEDIATE LANGUAGE (IL)
 * --------------------------------------------------------------------
 *
 * The compiler converts C# code into Intermediate Language (IL),
 * also called Microsoft Intermediate Language (MSIL).
 *
 * IL is a low-level, platform-independent instruction set
 * designed for the .NET runtime.
 *
 * IL is not executed directly by the CPU.
 *
 * Instead, it acts as a portable representation of the program
 * that can later be converted into machine code.
 *
 *
 * --------------------------------------------------------------------
 * STEP 4: ASSEMBLY CREATION
 * --------------------------------------------------------------------
 *
 * After compilation the compiler produces an assembly file.
 *
 * Assemblies are typically:
 *
 * .exe (executable)
 * .dll (library)
 *
 * An assembly contains:
 *
 * - IL code
 * - metadata
 * - assembly manifest
 *
 * Metadata describes program structure:
 *
 * - classes
 * - methods
 * - fields
 * - references to other assemblies
 *
 * The assembly manifest describes:
 *
 * - assembly name
 * - version
 * - dependencies
 *
 *
 * --------------------------------------------------------------------
 * STEP 5: PROGRAM STARTUP
 * --------------------------------------------------------------------
 *
 * When the program is executed, the .NET runtime loads the
 * assembly into memory.
 *
 * The runtime responsible for execution is called the
 * Common Language Runtime (CLR).
 *
 * The CLR performs several tasks:
 *
 * - loading assemblies
 * - verifying code safety
 * - resolving dependencies
 * - preparing execution environment
 *
 *
 * --------------------------------------------------------------------
 * STEP 6: JUST-IN-TIME COMPILATION
 * --------------------------------------------------------------------
 *
 * The CLR uses a Just-In-Time (JIT) compiler to convert
 * Intermediate Language into native machine code.
 *
 * This translation happens at runtime when methods
 * are executed for the first time.
 *
 * Execution flow:
 *
 * Method called
 * → CLR locates IL
 * → JIT compiler converts IL to machine code
 * → machine code is cached
 * → CPU executes machine instructions
 *
 * Subsequent calls to the same method reuse the
 * compiled machine code.
 *
 *
 * --------------------------------------------------------------------
 * STEP 7: EXECUTION
 * --------------------------------------------------------------------
 *
 * After JIT compilation the CPU executes the generated
 * machine instructions.
 *
 * During execution the CLR also provides runtime services:
 *
 * Memory management
 * Automatic garbage collection removes unused objects.
 *
 * Exception handling
 * Structured error handling through try/catch.
 *
 * Security verification
 * Ensures code execution follows safety rules.
 *
 * Thread management
 * Supports multithreading and asynchronous execution.
 *
 *
 * --------------------------------------------------------------------
 * COMPLETE EXECUTION PIPELINE
 *
 * The full lifecycle of a C# program is therefore:
 *
 * C# source code
 * → C# compiler (csc)
 * → Intermediate Language (IL)
 * → Assembly (.exe / .dll)
 * → CLR loads assembly
 * → JIT compiles IL to machine code
 * → CPU executes machine instructions
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * C# execution relies on several key runtime components:
 *
 * CLR (Common Language Runtime)
 * The virtual execution environment responsible for running
 * .NET programs.
 *
 * JIT Compiler
 * Converts IL instructions into CPU-specific machine code.
 *
 * Garbage Collector
 * Automatically manages memory allocation and deallocation.
 *
 * Metadata System
 * Stores information about program structure and types.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS OF THE .NET EXECUTION MODEL
 *
 * Platform independence
 * IL can run on different operating systems with a compatible runtime.
 *
 * Security
 * Runtime verification protects against unsafe code execution.
 *
 * Performance
 * JIT compilation allows runtime optimizations.
 *
 * Language interoperability
 * Multiple languages (C#, F#, VB.NET) compile to the same IL.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Compilation
 * The process of translating source code into intermediate code.
 *
 * Intermediate Language (IL)
 * Platform-independent instruction set used by the .NET runtime.
 *
 * Assembly
 * The compiled output containing IL code and metadata.
 *
 * CLR
 * The runtime environment responsible for executing .NET programs.
 *
 * JIT Compiler
 * A runtime compiler that converts IL into machine code.
 *
 * Garbage Collection
 * Automatic memory management mechanism in the CLR.
 */