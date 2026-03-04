namespace C_Sharp_Practice.Architectures.Event_Driven;

/*
 * TOPIC: Architectures / CQRS
 *
 * TOPIC DEFINITION
 * CQRS (Command Query Responsibility Segregation) is an architectural
 * pattern that separates operations that modify system state from
 * operations that read system state.
 *
 * In traditional application design, the same model and service often
 * handle both reading and writing data. While simple, this approach
 * can lead to complex models that try to satisfy conflicting
 * requirements for both queries and updates.
 *
 * CQRS solves this problem by splitting responsibilities into two
 * distinct paths:
 *
 * Commands
 * Operations that change system state.
 *
 * Queries
 * Operations that retrieve data without modifying state.
 *
 * By separating these responsibilities, systems can optimize each
 * side independently.
 *
 *
 * --------------------------------------------------------------------
 * CORE IDEA
 * --------------------------------------------------------------------
 *
 * The key principle of CQRS is that commands and queries represent
 * fundamentally different kinds of operations.
 *
 * Commands
 *
 * - modify system state
 * - represent an intention to perform an action
 * - usually return success/failure
 *
 * Queries
 *
 * - read system state
 * - must not cause side effects
 * - return data to the caller
 *
 * In CQRS systems these two responsibilities are handled by different
 * models and often by different components.
 *
 *
 * --------------------------------------------------------------------
 * COMMAND SIDE
 * --------------------------------------------------------------------
 *
 * Commands represent requests to change the system state.
 *
 * Examples:
 *
 * - CreateProduct
 * - PlaceOrder
 * - UpdateUserEmail
 *
 * A command typically contains only the data necessary to perform the
 * operation.
 *
 * Command workflow
 *
 * Command
 * → Command Handler
 * → Domain logic executed
 * → Data stored in persistence layer
 *
 * Command handlers are responsible for:
 *
 * - validating input
 * - executing domain logic
 * - updating the system state
 *
 * Commands usually return a status result rather than returning the
 * modified entity.
 *
 *
 * --------------------------------------------------------------------
 * QUERY SIDE
 * --------------------------------------------------------------------
 *
 * Queries retrieve information from the system without modifying
 * application state.
 *
 * Examples:
 *
 * - GetProducts
 * - GetOrderHistory
 * - FindUserByEmail
 *
 * Query workflow
 *
 * Query
 * → Query Handler
 * → Read model retrieved
 * → Data returned
 *
 * Query handlers often return specialized read models that are
 * optimized for display or API responses.
 *
 *
 * --------------------------------------------------------------------
 * SEPARATE MODELS
 * --------------------------------------------------------------------
 *
 * In CQRS systems the models used for commands and queries are often
 * different.
 *
 * Write model
 * Represents domain entities used for enforcing business rules.
 *
 * Read model
 * Represents simplified projections optimized for reading and
 * displaying data.
 *
 * Example
 *
 * Command model:
 *
 * Product
 *   - domain behavior
 *   - validation rules
 *
 * Read model:
 *
 * ProductReadModel
 *   - only fields required for display
 *
 * Benefit
 *
 * Read models can be optimized for performance without affecting the
 * domain model.
 *
 *
 * --------------------------------------------------------------------
 * VALIDATION
 * --------------------------------------------------------------------
 *
 * Commands usually require validation before executing business logic.
 *
 * Validation checks may include:
 *
 * - required fields
 * - data constraints
 * - business rule verification
 *
 * If validation fails, the command handler typically returns an error
 * or failure result.
 *
 * This prevents invalid data from entering the system.
 *
 *
 * --------------------------------------------------------------------
 * MEDIATOR STYLE DISPATCH
 * --------------------------------------------------------------------
 *
 * In larger CQRS implementations commands and queries are often
 * dispatched through a mediator component.
 *
 * A mediator routes messages to the correct handler.
 *
 * Example
 *
 * Command → Mediator → Command Handler
 * Query → Mediator → Query Handler
 *
 * This approach removes direct coupling between controllers and
 * handlers and simplifies dependency management.
 *
 * In .NET systems this is commonly implemented using libraries such
 * as MediatR.
 *
 *
 * --------------------------------------------------------------------
 * SYSTEM INTERACTION FLOW
 *
 * Typical CQRS request flow:
 *
 * Client request
 * → Controller receives request
 * → Command or Query object created
 * → Handler executes logic
 * → Persistence or read model accessed
 * → Result returned
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * CQRS systems rely on several structural mechanisms:
 *
 * Message-based interactions
 * Commands and queries act as messages that represent operations.
 *
 * Handler isolation
 * Each command or query has a dedicated handler responsible for
 * executing the operation.
 *
 * Read/write model separation
 * Different models may be used for reading and writing data.
 *
 * Optional asynchronous processing
 * Commands can be processed asynchronously using message queues.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Separation of concerns
 * Reading and writing logic are handled independently.
 *
 * Performance optimization
 * Read models can be optimized without affecting write logic.
 *
 * Scalability
 * Read and write workloads can be scaled independently.
 *
 * Maintainability
 * Handlers isolate business operations into focused components.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Increased complexity
 * The architecture introduces additional components and models.
 *
 * More code
 * Commands, queries, and handlers increase the number of classes.
 *
 * Overhead for simple applications
 * Very small systems may not require CQRS separation.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Command
 * A request to change the system state.
 *
 * Query
 * A request to retrieve information without modifying state.
 *
 * Command Handler
 * A component responsible for executing a command.
 *
 * Query Handler
 * A component responsible for executing a query.
 *
 * Read Model
 * A data structure optimized for retrieving information.
 *
 * Write Model
 * The domain model responsible for enforcing business rules.
 *
 * Mediator
 * A component that dispatches commands and queries to their
 * corresponding handlers.
 */

public static class Examples
{
    // Demonstrates publishing and handling an event.
    public static void PublishSubscribeExample()
    {
        var bus = new EventBus();
        bus.Subscribe<OrderCreated>(e => Console.WriteLine($"Order:{e.OrderId}"));
        bus.Publish(new OrderCreated("O-1"));
    }

    // Shows multiple subscribers for one event.
    public static void MultipleSubscriberExample()
    {
        var bus = new EventBus();
        bus.Subscribe<OrderCreated>(_ => Console.WriteLine("Billing"));
        bus.Subscribe<OrderCreated>(_ => Console.WriteLine("Shipping"));
        bus.Publish(new OrderCreated("O-2"));
    }

    // Demonstrates event payload design.
    public static void EventPayloadExample()
    {
        var evt = new PaymentCompleted("P-1", 100m);
        Console.WriteLine($"{evt.PaymentId}:{evt.Amount}");
    }

    // Shows decoupled handler registration.
    public static void DecouplingExample()
    {
        var bus = new EventBus();
        bus.Subscribe<PaymentCompleted>(e => Console.WriteLine("Accounting"));
        bus.Publish(new PaymentCompleted("P-2", 200));
    }

    // Demonstrates eventual consistency mindset.
    public static void EventualConsistencyExample()
    {
        Console.WriteLine("Read model may update after event processing");
    }
}

public record OrderCreated(string OrderId);
public record PaymentCompleted(string PaymentId, decimal Amount);

public class EventBus
{
    private readonly Dictionary<Type, List<Delegate>> _handlers = [];

    public void Subscribe<T>(Action<T> handler)
    {
        var type = typeof(T);
        if (!_handlers.TryGetValue(type, out var list))
        {
            list = [];
            _handlers[type] = list;
        }
        list.Add(handler);
    }

    public void Publish<T>(T evt)
    {
        var type = typeof(T);
        if (_handlers.TryGetValue(type, out var list))
        {
            foreach (var handler in list.Cast<Action<T>>())
            {
                handler(evt);
            }
        }
    }
}






