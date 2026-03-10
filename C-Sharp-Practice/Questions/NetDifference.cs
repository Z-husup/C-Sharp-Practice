namespace C_Sharp_Practice.Questions;

/*
 * TOPIC: .NET Platform Evolution
 *
 * TOPIC DEFINITION
 * .NET Framework, .NET Core, and modern .NET represent different
 * generations of the Microsoft .NET platform used to build and run
 * applications.
 *
 * Each version reflects a stage in the evolution of the .NET ecosystem,
 * with improvements in portability, performance, and architecture.
 *
 * .NET Framework was the original Windows-only platform.
 * .NET Core introduced cross-platform modular architecture.
 * Modern .NET unified the ecosystem into a single platform.
 *
 * Understanding the differences between these versions is important
 * for maintaining legacy applications and building modern systems.
 *
 *
 * --------------------------------------------------------------------
 * .NET FRAMEWORK
 * --------------------------------------------------------------------
 *
 * .NET Framework was the original implementation of the .NET platform.
 * It was released by Microsoft in 2002 and designed primarily for
 * Windows desktop and enterprise applications.
 *
 * Key characteristics:
 *
 * Windows-only runtime
 * Applications built on .NET Framework run only on Windows.
 *
 * Large monolithic installation
 * The framework was installed globally on the operating system.
 *
 * Tight Windows integration
 * Many APIs depended directly on Windows technologies.
 *
 * Typical application types:
 *
 * - Windows Forms applications
 * - WPF desktop applications
 * - ASP.NET web applications
 * - Windows Services
 *
 * Limitations:
 *
 * - Not cross-platform
 * - Difficult to modernize
 * - Large runtime dependencies
 *
 * Microsoft stopped active feature development after version 4.8.
 *
 *
 * --------------------------------------------------------------------
 * .NET CORE
 * --------------------------------------------------------------------
 *
 * .NET Core was introduced in 2016 as a redesign of the .NET platform.
 *
 * Its main goals were:
 *
 * - cross-platform support
 * - improved performance
 * - modular architecture
 * - cloud readiness
 *
 * Key characteristics:
 *
 * Cross-platform runtime
 * Applications run on Windows, Linux, and macOS.
 *
 * Modular architecture
 * Libraries are distributed as NuGet packages.
 *
 * Side-by-side runtime installation
 * Different applications can use different runtime versions.
 *
 * High performance
 * Optimized runtime for server and cloud workloads.
 *
 * Typical application types:
 *
 * - ASP.NET Core web APIs
 * - microservices
 * - cloud services
 * - console applications
 *
 * .NET Core versions included:
 *
 * - .NET Core 1.x
 * - .NET Core 2.x
 * - .NET Core 3.x
 *
 *
 * --------------------------------------------------------------------
 * MODERN .NET (UNIFIED PLATFORM)
 * --------------------------------------------------------------------
 *
 * In 2020 Microsoft unified the platform under a single name:
 *
 * ".NET"
 *
 * Starting with .NET 5, the platform replaced .NET Core and became
 * the main future development line.
 *
 * Modern .NET includes:
 *
 * - .NET 5
 * - .NET 6 (LTS)
 * - .NET 7
 * - .NET 8 (LTS)
 *
 * Key characteristics:
 *
 * Unified ecosystem
 * One platform replaces .NET Core and most .NET Framework scenarios.
 *
 * Cross-platform support
 * Applications run on Windows, Linux, and macOS.
 *
 * High performance runtime
 * Improved JIT compilation and memory management.
 *
 * Modern development tools
 * Integrated with Visual Studio, CLI tools, and container systems.
 *
 * Supported application types:
 *
 * - web APIs
 * - microservices
 * - desktop apps
 * - cloud applications
 * - mobile applications (via .NET MAUI)
 * - console tools
 *
 *
 * --------------------------------------------------------------------
 * PLATFORM ARCHITECTURE COMPARISON
 *
 * .NET Framework
 * → Windows-only runtime
 * → monolithic installation
 * → legacy enterprise applications
 *
 * .NET Core
 * → cross-platform runtime
 * → modular libraries
 * → modern server applications
 *
 * .NET (5+)
 * → unified cross-platform platform
 * → ongoing active development
 * → preferred platform for new projects
 *
 *
 * --------------------------------------------------------------------
 * DEVELOPMENT MODEL DIFFERENCES
 *
 * Installation model
 *
 * .NET Framework
 * Installed globally with Windows.
 *
 * .NET Core / .NET
 * Installed side-by-side; applications can use different versions.
 *
 *
 * Package management
 *
 * .NET Framework
 * Many libraries built into framework installation.
 *
 * .NET Core / .NET
 * Libraries distributed through NuGet packages.
 *
 *
 * Cross-platform support
 *
 * .NET Framework
 * Windows only.
 *
 * .NET Core / .NET
 * Windows, Linux, macOS.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * All .NET implementations share core runtime concepts:
 *
 * CLR / CoreCLR
 * Executes .NET programs.
 *
 * Intermediate Language (IL)
 * Portable instruction set produced by the compiler.
 *
 * JIT compilation
 * Converts IL to machine code at runtime.
 *
 * Base Class Library (BCL)
 * Provides common functionality such as collections,
 * file access, networking, and threading.
 *
 *
 * --------------------------------------------------------------------
 * CURRENT INDUSTRY PRACTICE
 *
 * For new applications developers should use modern .NET
 * versions such as:
 *
 * - .NET 6 (Long-Term Support)
 * - .NET 8 (Long-Term Support)
 *
 * .NET Framework is mainly used for maintaining legacy
 * enterprise systems.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Runtime
 * The environment responsible for executing applications.
 *
 * Cross-platform
 * Ability to run the same program on multiple operating systems.
 *
 * Modular architecture
 * Software composed of independent packages rather than a
 * single large installation.
 *
 * LTS (Long-Term Support)
 * Versions that receive extended maintenance and security updates.
 */