namespace C_Sharp_Practice.Architectures.Layered;

/*
 * TOPIC: Architectures / Layered
 *
 * TOPIC DEFINITION
 * Layered architecture is a common software design structure that
 * organizes a system into multiple logical layers. Each layer has a
 * clearly defined responsibility and interacts only with adjacent
 * layers. This separation helps manage complexity and improves
 * maintainability.
 *
 * In a typical layered system, responsibilities are divided into
 * several tiers such as:
 *
 * Presentation Layer
 * Application Layer
 * Domain Layer
 * Infrastructure Layer
 *
 * Each layer focuses on a different aspect of the system, allowing
 * developers to modify or replace one part without affecting others.
 *
 * Layered architecture is widely used in enterprise applications,
 * web services, and backend systems because it enforces clear
 * boundaries between user interfaces, business logic, and technical
 * infrastructure.
 *
 *
 * --------------------------------------------------------------------
 * LAYER RESPONSIBILITIES
 * --------------------------------------------------------------------
 *
 * PRESENTATION LAYER
 *
 * Purpose
 * The presentation layer is responsible for interacting with the user
 * or external clients. It handles input, displays output, and converts
 * user actions into requests that the application layer can process.
 *
 * Examples
 *
 * - Web controllers
 * - REST API endpoints
 * - UI components
 *
 * Responsibilities
 *
 * - receive user requests
 * - validate basic input
 * - call application services
 * - return responses
 *
 * Important rule
 * The presentation layer should not contain business logic.
 *
 *
 * --------------------------------------------------------------------
 *
 * APPLICATION LAYER
 *
 * Purpose
 * The application layer orchestrates use cases. It coordinates domain
 * objects and infrastructure services to perform specific operations.
 *
 * Responsibilities
 *
 * - execute application workflows
 * - coordinate domain entities
 * - manage transactions
 * - call repositories or external services
 *
 * Example use cases
 *
 * - Place order
 * - Register user
 * - Process payment
 *
 * Important rule
 * The application layer contains orchestration logic but not the
 * detailed business rules themselves.
 *
 *
 * --------------------------------------------------------------------
 *
 * DOMAIN LAYER
 *
 * Purpose
 * The domain layer contains the core business logic of the system.
 * It defines entities, value objects, and business rules that model
 * the problem domain.
 *
 * Example domain concepts
 *
 * - Order
 * - Customer
 * - Payment
 *
 * Responsibilities
 *
 * - enforce business rules
 * - maintain entity state
 * - implement domain behavior
 *
 * Important rule
 * The domain layer should remain independent of infrastructure and
 * user interface concerns.
 *
 *
 * --------------------------------------------------------------------
 *
 * INFRASTRUCTURE LAYER
 *
 * Purpose
 * The infrastructure layer provides technical capabilities such as
 * data storage, messaging systems, and external service integration.
 *
 * Examples
 *
 * - database repositories
 * - file storage
 * - email services
 * - network communication
 *
 * Responsibilities
 *
 * - implement persistence
 * - interact with external systems
 * - provide technical utilities
 *
 * Important rule
 * Infrastructure implements interfaces defined by the domain or
 * application layers.
 *
 *
 * --------------------------------------------------------------------
 *
 * DEPENDENCY FLOW
 *
 * One of the most important principles of layered architecture is
 * dependency direction.
 *
 * Dependencies should always flow inward toward the domain layer.
 *
 * Allowed dependency direction:
 *
 * Presentation → Application → Domain
 * Infrastructure → Domain
 *
 * The domain layer should not depend on infrastructure or UI code.
 *
 * Example
 *
 * Domain defines an interface:
 *
 *   IOrderRepository
 *
 * Infrastructure implements the interface:
 *
 *   InMemoryOrderRepo
 *
 * This approach follows the Dependency Inversion Principle.
 *
 *
 * --------------------------------------------------------------------
 *
 * SEPARATION OF CONCERNS
 *
 * Layered architecture improves maintainability by separating
 * different responsibilities into independent modules.
 *
 * Example workflow
 *
 * User request
 * → Presentation layer receives request
 * → Application layer executes use case
 * → Domain layer enforces business rules
 * → Infrastructure layer persists data
 *
 * Because each layer has a focused responsibility, changes in one
 * area typically do not affect others.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * The layered architecture relies on several structural principles:
 *
 * Dependency boundaries
 * Layers interact through clearly defined interfaces.
 *
 * Encapsulation
 * Internal details of each layer remain hidden from other layers.
 *
 * Inversion of control
 * Infrastructure components are injected into application services
 * through dependency injection.
 *
 * Composition root
 * The application startup code is responsible for wiring together
 * the complete object graph.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Layer
 * A logical separation of responsibilities within a system.
 *
 * Boundary
 * The interface through which two architectural components interact.
 *
 * Dependency Direction
 * The allowed reference flow between components or layers.
 *
 * Policy
 * Core business rules that remain stable over time.
 *
 * Adapter
 * A concrete implementation that connects domain interfaces to
 * external technologies.
 *
 * Composition Root
 * The location in an application where dependencies are assembled
 * and injected into the system.
 */

public static class Examples
{
    // Demonstrates presentation calling application use case.
    public static void PresentationToApplicationExample()
    {
        var service = new OrderAppService(new InMemoryOrderRepo());
        Console.WriteLine(service.PlaceOrder("A-1"));
    }

    // Shows domain entity behavior.
    public static void DomainExample()
    {
        var order = new Order("A-1");
        order.MarkPlaced();
        Console.WriteLine(order.IsPlaced);
    }

    // Demonstrates infrastructure repository implementation.
    public static void InfrastructureExample()
    {
        IOrderRepository repo = new InMemoryOrderRepo();
        repo.Save(new Order("A-2"));
        Console.WriteLine(repo.Count());
    }

    // Shows dependency inversion via interface abstraction.
    public static void DependencyFlowExample()
    {
        var app = new OrderAppService(new InMemoryOrderRepo());
        Console.WriteLine(app.PlaceOrder("A-3"));
    }

    // Demonstrates separation of concerns in flow.
    public static void SeparationExample()
    {
        Console.WriteLine("UI -> App -> Domain -> Infra");
    }
}

public class Order(string id)
{
    public string Id { get; } = id;
    public bool IsPlaced { get; private set; }
    public void MarkPlaced() => IsPlaced = true;
}

public interface IOrderRepository
{
    void Save(Order order);
    int Count();
}

public class InMemoryOrderRepo : IOrderRepository
{
    private readonly List<Order> _orders = [];
    public void Save(Order order) => _orders.Add(order);
    public int Count() => _orders.Count;
}

public class OrderAppService(IOrderRepository repository)
{
    public string PlaceOrder(string id)
    {
        var order = new Order(id);
        order.MarkPlaced();
        repository.Save(order);
        return "Order placed";
    }
}






