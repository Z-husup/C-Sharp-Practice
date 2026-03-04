namespace C_Sharp_Practice.Architectures.Clean;

/*
 * TOPIC: Architectures / Clean
 *
 * TOPIC DEFINITION
 * Clean Architecture is a software design approach that organizes
 * systems so that the most important business rules remain independent
 * of frameworks, databases, user interfaces, and external technologies.
 *
 * The core idea of Clean Architecture is that dependencies always point
 * inward toward the business logic of the system. This ensures that the
 * most critical policies of the application remain stable even when
 * external technologies change.
 *
 * Clean Architecture was popularized by Robert C. Martin and is widely
 * used in enterprise backend systems because it creates highly
 * maintainable and testable software.
 *
 * The architecture is often visualized as concentric layers:
 *
 *   ┌──────────────────────────┐
 *   │      Frameworks/UI       │
 *   ├──────────────────────────┤
 *   │        Interface         │
 *   │         Adapters         │
 *   ├──────────────────────────┤
 *   │         Use Cases        │
 *   ├──────────────────────────┤
 *   │          Entities        │
 *   └──────────────────────────┘
 *
 * Inner layers contain business policy, while outer layers contain
 * technical implementation details.
 *
 *
 * --------------------------------------------------------------------
 * CORE ARCHITECTURE COMPONENTS
 * --------------------------------------------------------------------
 *
 * ENTITIES
 *
 * Purpose
 * Entities represent the core business objects of the system. They
 * contain business rules that are fundamental to the domain and remain
 * stable over time.
 *
 * Example entities
 *
 * - User
 * - Order
 * - Invoice
 *
 * Responsibilities
 *
 * - maintain domain state
 * - enforce business invariants
 * - provide domain behavior
 *
 * Important property
 * Entities must not depend on frameworks, databases, or UI code.
 *
 *
 * --------------------------------------------------------------------
 *
 * USE CASES (APPLICATION SERVICES)
 *
 * Purpose
 * Use cases implement application-specific business workflows. They
 * orchestrate domain entities and coordinate system behavior in
 * response to requests.
 *
 * Examples
 *
 * - Create user
 * - Place order
 * - Process payment
 *
 * Responsibilities
 *
 * - coordinate domain logic
 * - validate inputs
 * - call gateways or repositories
 * - produce output results
 *
 * Important property
 * Use cases depend only on interfaces defined within the application
 * core, not on infrastructure implementations.
 *
 *
 * --------------------------------------------------------------------
 *
 * GATEWAYS (INTERFACES)
 *
 * Problem
 * Use cases need to access external resources such as databases or
 * external services. Directly referencing these technologies would
 * create unwanted dependencies.
 *
 * Solution
 * Clean Architecture introduces gateway interfaces that define the
 * operations required by the use cases.
 *
 * Example gateway
 *
 * IUserGateway
 *
 * Infrastructure components then implement these interfaces.
 *
 * Benefit
 * The core business logic remains independent from infrastructure.
 *
 *
 * --------------------------------------------------------------------
 *
 * ADAPTERS
 *
 * Purpose
 * Adapters connect the external world to the application core. They
 * translate data formats between outside systems and internal domain
 * models.
 *
 * Common adapters include:
 *
 * - REST controllers
 * - database repositories
 * - message queue handlers
 * - external API clients
 *
 * Example
 *
 * UsersController receives HTTP input and calls a use case.
 *
 * Benefit
 * Adapters isolate infrastructure concerns from business logic.
 *
 *
 * --------------------------------------------------------------------
 *
 * DEPENDENCY RULE
 *
 * The most important rule of Clean Architecture is the dependency rule.
 *
 * All dependencies must point inward toward the core business logic.
 *
 * Allowed dependency direction:
 *
 * Frameworks/UI → Adapters → Use Cases → Entities
 *
 * This means:
 *
 * - Entities know nothing about outer layers.
 * - Use cases know only about entity types and interfaces.
 * - Infrastructure implements interfaces defined by the core.
 *
 * Example
 *
 * Use case depends on:
 *
 *   IUserGateway
 *
 * Infrastructure provides:
 *
 *   InMemoryUserGateway
 *
 * This follows the Dependency Inversion Principle.
 *
 *
 * --------------------------------------------------------------------
 *
 * SYSTEM WORKFLOW
 *
 * A typical request flow in Clean Architecture looks like this:
 *
 * HTTP request
 * → Controller (adapter)
 * → Use case execution
 * → Domain entities enforce rules
 * → Gateway interface invoked
 * → Infrastructure implementation persists data
 * → Response returned
 *
 * Each layer has a clearly defined role and does not leak its
 * responsibilities into other layers.
 *
 *
 * --------------------------------------------------------------------
 *
 * INTERNAL MECHANICS
 *
 * Clean Architecture relies on several important design mechanisms:
 *
 * Interface boundaries
 * Core layers define interfaces that outer layers implement.
 *
 * Dependency inversion
 * High-level policy does not depend on low-level implementation.
 *
 * Composition root
 * The application startup process connects concrete implementations
 * to interfaces using dependency injection.
 *
 * Isolation of policy
 * Business rules remain independent of external frameworks and
 * infrastructure technologies.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Maintainability
 * Core business rules are isolated from technology changes.
 *
 * Testability
 * Use cases can be tested independently using mock gateways.
 *
 * Flexibility
 * Databases, frameworks, or interfaces can be replaced without
 * rewriting business logic.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Additional complexity
 * Clean Architecture introduces more layers and abstractions.
 *
 * More boilerplate
 * Interfaces and adapters increase the amount of code.
 *
 * Overkill for small systems
 * Very small applications may not benefit from the full architecture.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Entity
 * A core business object containing fundamental domain rules.
 *
 * Use Case
 * A unit of application logic representing a business workflow.
 *
 * Gateway
 * An interface used by the application core to access external systems.
 *
 * Adapter
 * A component that translates external inputs and outputs into
 * formats usable by the application core.
 *
 * Dependency Direction
 * The rule that dependencies must always point toward the business
 * logic layers.
 *
 * Composition Root
 * The location where the full object graph of the application is
 * assembled using dependency injection.
 */

public static class Examples
{
    // Demonstrates use-case execution through input port.
    public static void UseCaseExample()
    {
        ICreateUserUseCase uc = new CreateUserUseCase(new InMemoryUserGateway());
        Console.WriteLine(uc.Execute("Ana"));
    }

    // Shows gateway abstraction shielding persistence details.
    public static void GatewayExample()
    {
        IUserGateway gateway = new InMemoryUserGateway();
        gateway.Save(new UserEntity("Bob"));
        Console.WriteLine(gateway.Count());
    }

    // Demonstrates entity-focused rule execution.
    public static void EntityExample()
    {
        var entity = new UserEntity("Cem");
        Console.WriteLine(entity.IsValid());
    }

    // Shows outer adapter invoking core use case.
    public static void AdapterExample()
    {
        var controller = new UsersController(new CreateUserUseCase(new InMemoryUserGateway()));
        Console.WriteLine(controller.Post("Dana"));
    }

    // Demonstrates dependency direction statement.
    public static void DependencyRuleExample()
    {
        Console.WriteLine("Dependencies point inward");
    }
}

public class UserEntity(string name)
{
    public string Name { get; } = name;
    public bool IsValid() => !string.IsNullOrWhiteSpace(Name);
}

public interface IUserGateway
{
    void Save(UserEntity user);
    int Count();
}

public class InMemoryUserGateway : IUserGateway
{
    private readonly List<UserEntity> _items = [];
    public void Save(UserEntity user) => _items.Add(user);
    public int Count() => _items.Count;
}

public interface ICreateUserUseCase
{
    string Execute(string name);
}

public class CreateUserUseCase(IUserGateway gateway) : ICreateUserUseCase
{
    public string Execute(string name)
    {
        var user = new UserEntity(name);
        if (!user.IsValid()) return "Invalid";
        gateway.Save(user);
        return "Created";
    }
}

public class UsersController(ICreateUserUseCase useCase)
{
    public string Post(string name) => useCase.Execute(name);
}






