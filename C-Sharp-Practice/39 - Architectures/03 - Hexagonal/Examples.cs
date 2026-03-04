namespace C_Sharp_Practice.Architectures.Hexagonal;

/*
 * TOPIC: Architectures / Hexagonal
 *
 * TOPIC DEFINITION
 * Hexagonal Architecture, also known as the Ports and Adapters
 * architecture, is a software design pattern that isolates the
 * application's core business logic from external technologies such
 * as databases, user interfaces, messaging systems, or web frameworks.
 *
 * The architecture was introduced by Alistair Cockburn. Its main goal
 * is to ensure that the core of the application can operate
 * independently of external systems.
 *
 * Instead of organizing the system around technical layers, the system
 * is organized around the application core. External technologies
 * interact with the core through clearly defined interfaces called
 * ports. Concrete implementations of those interfaces are called
 * adapters.
 *
 * The name "hexagonal" comes from diagrams where the application core
 * is drawn in the center and multiple adapters surround it like the
 * sides of a hexagon.
 *
 *
 * --------------------------------------------------------------------
 * CORE IDEA
 * --------------------------------------------------------------------
 *
 * Traditional layered systems often allow infrastructure concerns to
 * leak into business logic. This creates tight coupling between the
 * application core and external technologies.
 *
 * Hexagonal architecture prevents this by introducing ports that act
 * as boundaries between the application core and external systems.
 *
 * External systems communicate with the core only through these ports.
 *
 * This ensures that:
 *
 * - the core business logic remains independent
 * - infrastructure can be replaced without modifying core logic
 * - the application can be tested without external systems
 *
 *
 * --------------------------------------------------------------------
 * PORTS
 * --------------------------------------------------------------------
 *
 * Ports are interfaces that define how the application core interacts
 * with the outside world.
 *
 * There are two types of ports:
 *
 * Driving Ports
 * Interfaces that external actors use to invoke the application core.
 *
 * Driven Ports
 * Interfaces that the application core uses to access external
 * services such as databases or APIs.
 *
 * Ports define the contract of interaction but do not implement the
 * behavior themselves.
 *
 *
 * --------------------------------------------------------------------
 * ADAPTERS
 * --------------------------------------------------------------------
 *
 * Adapters are concrete implementations that connect the application
 * core to external technologies.
 *
 * They translate between the format required by the outside world and
 * the format expected by the application core.
 *
 * Examples of adapters include:
 *
 * - REST controllers
 * - database repositories
 * - message queue consumers
 * - external API clients
 *
 * Adapters can be replaced without affecting the application core as
 * long as they implement the required ports.
 *
 *
 * --------------------------------------------------------------------
 * DRIVING ADAPTERS
 * --------------------------------------------------------------------
 *
 * Driving adapters initiate interactions with the application core.
 *
 * Examples:
 *
 * - HTTP controllers
 * - CLI commands
 * - scheduled jobs
 * - message consumers
 *
 * These components receive input from external actors and call the
 * appropriate application services.
 *
 *
 * --------------------------------------------------------------------
 * DRIVEN ADAPTERS
 * --------------------------------------------------------------------
 *
 * Driven adapters implement ports defined by the application core.
 * They provide access to infrastructure services required by the core.
 *
 * Examples:
 *
 * - database persistence
 * - external API communication
 * - file storage
 * - email services
 *
 * The application core defines the interface, and the adapter provides
 * the implementation.
 *
 *
 * --------------------------------------------------------------------
 * SYSTEM INTERACTION FLOW
 * --------------------------------------------------------------------
 *
 * A typical interaction in hexagonal architecture looks like this:
 *
 * External actor
 * → Driving adapter (e.g., controller)
 * → Application core service
 * → Driven port interface
 * → Infrastructure adapter implementation
 *
 * Example workflow
 *
 * User request
 * → HTTP controller receives request
 * → Controller calls application service
 * → Application service invokes persistence port
 * → Repository adapter stores data
 *
 *
 * --------------------------------------------------------------------
 * CORE INDEPENDENCE
 * --------------------------------------------------------------------
 *
 * The application core must remain independent of external frameworks
 * and technologies.
 *
 * This means that the core should not import or depend on:
 *
 * - web frameworks
 * - database libraries
 * - UI frameworks
 *
 * Instead, it depends only on interfaces (ports).
 *
 * Infrastructure code implements those interfaces externally.
 *
 *
 * --------------------------------------------------------------------
 * PORT MOCKING AND TESTING
 * --------------------------------------------------------------------
 *
 * Because the application core depends only on interfaces, ports can
 * easily be replaced with mock or fake implementations during testing.
 *
 * Example
 *
 * FakePaymentPort can replace the real persistence adapter to test
 * business logic without a database.
 *
 * Benefits:
 *
 * - fast unit tests
 * - no external dependencies
 * - deterministic test results
 *
 *
 * --------------------------------------------------------------------
 * ADAPTER REPLACEMENT
 * --------------------------------------------------------------------
 *
 * One of the key benefits of hexagonal architecture is the ability to
 * replace infrastructure components without modifying business logic.
 *
 * Example replacements:
 *
 * Database adapter
 *   → SQL repository
 *   → NoSQL repository
 *   → In-memory repository
 *
 * Messaging adapter
 *   → RabbitMQ
 *   → Kafka
 *
 * As long as the adapter implements the port interface, the core
 * application remains unchanged.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * The architecture relies on several structural principles:
 *
 * Dependency inversion
 * High-level policy depends on interfaces, not implementations.
 *
 * Boundary isolation
 * Ports act as boundaries separating business logic from infrastructure.
 *
 * Adapter translation
 * Adapters convert external data formats into domain-friendly models.
 *
 * Composition root
 * The application startup process assembles the concrete adapters
 * and injects them into the application core.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Testability
 * The application core can be tested without infrastructure.
 *
 * Flexibility
 * Infrastructure technologies can be replaced easily.
 *
 * Maintainability
 * Business logic remains isolated from framework changes.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Additional complexity
 * The architecture introduces more abstractions and interfaces.
 *
 * Boilerplate code
 * Ports and adapters increase the number of components.
 *
 * Overhead for small systems
 * Very small applications may not require this level of abstraction.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Port
 * An interface that defines how the application core communicates
 * with external systems.
 *
 * Adapter
 * A concrete implementation that connects a port to an external
 * technology.
 *
 * Driving Adapter
 * A component that initiates interactions with the application core.
 *
 * Driven Adapter
 * A component that provides infrastructure services used by the core.
 *
 * Application Core
 * The central part of the system containing business logic and use
 * cases.
 *
 * Composition Root
 * The location where concrete adapters are assembled and injected
 * into the application core.
 */

public static class Examples
{
    // Demonstrates driving adapter invoking core service.
    public static void DrivingAdapterExample()
    {
        var service = new PaymentService(new InMemoryPaymentPort());
        Console.WriteLine(service.Pay("INV-1", 10));
    }

    // Shows driven adapter implementation for persistence.
    public static void DrivenAdapterExample()
    {
        IPaymentPort port = new InMemoryPaymentPort();
        port.Store("INV-2", 20);
        Console.WriteLine(port.Total());
    }

    // Demonstrates port-based testability.
    public static void PortMockingExample()
    {
        var fake = new FakePaymentPort();
        var service = new PaymentService(fake);
        service.Pay("INV-3", 30);
        Console.WriteLine(fake.Calls);
    }

    // Shows core logic independent of framework concerns.
    public static void CoreIndependenceExample()
    {
        Console.WriteLine("Core uses IPaymentPort only");
    }

    // Demonstrates adapter replacement without core changes.
    public static void AdapterSwapExample()
    {
        IPaymentPort port = new InMemoryPaymentPort();
        var service = new PaymentService(port);
        Console.WriteLine(service.Pay("INV-4", 40));
    }
}

public interface IPaymentPort
{
    void Store(string invoiceId, decimal amount);
    decimal Total();
}

public class InMemoryPaymentPort : IPaymentPort
{
    private readonly List<decimal> _amounts = [];
    public void Store(string invoiceId, decimal amount) => _amounts.Add(amount);
    public decimal Total() => _amounts.Sum();
}

public class FakePaymentPort : IPaymentPort
{
    public int Calls { get; private set; }
    public void Store(string invoiceId, decimal amount) => Calls++;
    public decimal Total() => 0;
}

public class PaymentService(IPaymentPort port)
{
    public string Pay(string invoiceId, decimal amount)
    {
        if (amount <= 0) return "Invalid amount";
        port.Store(invoiceId, amount);
        return "Paid";
    }
}






