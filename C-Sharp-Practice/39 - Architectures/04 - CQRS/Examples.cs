namespace C_Sharp_Practice.Architectures.CQRS;

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
    // Demonstrates command handling for state changes.
    public static void CommandExample()
    {
        var store = new ProductStore();
        ICommandHandler<AddProductCommand> cmd = new AddProductHandler(store);
        cmd.Handle(new AddProductCommand("Pen", 2.5m));
        Console.WriteLine(store.Count());
    }

    // Shows query handling for reads.
    public static void QueryExample()
    {
        var store = new ProductStore();
        store.Add("Notebook", 5m);
        IQueryHandler<GetProductsQuery, List<ProductReadModel>> q = new GetProductsHandler(store);
        Console.WriteLine(q.Handle(new GetProductsQuery()).Count);
    }

    // Demonstrates separated models for write/read.
    public static void SeparateModelsExample()
    {
        Console.WriteLine("Command model != Read model");
    }

    // Shows command validation before persistence.
    public static void ValidationExample()
    {
        var store = new ProductStore();
        var handler = new AddProductHandler(store);
        Console.WriteLine(handler.Handle(new AddProductCommand("", 0)));
    }

    // Demonstrates simple in-memory mediator flow.
    public static void MediatorStyleExample()
    {
        var store = new ProductStore();
        var add = new AddProductHandler(store);
        add.Handle(new AddProductCommand("Pencil", 1m));
        var get = new GetProductsHandler(store);
        Console.WriteLine(get.Handle(new GetProductsQuery()).First().Name);
    }
}

public record AddProductCommand(string Name, decimal Price);
public record GetProductsQuery();
public record ProductReadModel(string Name, decimal Price);

public interface ICommandHandler<TCommand> { string Handle(TCommand command); }
public interface IQueryHandler<TQuery, TResult> { TResult Handle(TQuery query); }

public class ProductStore
{
    private readonly List<ProductReadModel> _products = [];
    public void Add(string name, decimal price) => _products.Add(new ProductReadModel(name, price));
    public List<ProductReadModel> GetAll() => [.._products];
    public int Count() => _products.Count;
}

public class AddProductHandler(ProductStore store) : ICommandHandler<AddProductCommand>
{
    public string Handle(AddProductCommand command)
    {
        if (string.IsNullOrWhiteSpace(command.Name) || command.Price <= 0) return "Invalid";
        store.Add(command.Name, command.Price);
        return "Added";
    }
}

public class GetProductsHandler(ProductStore store) : IQueryHandler<GetProductsQuery, List<ProductReadModel>>
{
    public List<ProductReadModel> Handle(GetProductsQuery query) => store.GetAll();
}






