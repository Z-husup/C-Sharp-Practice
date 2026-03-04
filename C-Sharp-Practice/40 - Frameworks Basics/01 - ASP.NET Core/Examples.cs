namespace C_Sharp_Practice.Frameworks_Basics.ASP_NET_Core;

/*
 * TOPIC: Frameworks Basics / ASP.NET Core
 *
 * TOPIC DEFINITION
 * ASP.NET Core is a modern web framework for building HTTP services,
 * APIs, and web applications using .NET. It provides a high-performance
 * request processing pipeline that handles incoming HTTP requests,
 * processes them through middleware components, and returns responses.
 *
 * At its core, ASP.NET Core is built around a configurable request
 * pipeline and a dependency injection system that enables modular,
 * maintainable application design.
 *
 * Typical ASP.NET Core applications are used to build:
 *
 * - REST APIs
 * - web applications
 * - microservices
 * - real-time services
 *
 * The framework provides infrastructure for routing, model binding,
 * dependency injection, middleware pipelines, and HTTP response
 * generation.
 *
 *
 * --------------------------------------------------------------------
 * REQUEST PROCESSING PIPELINE
 * --------------------------------------------------------------------
 *
 * ASP.NET Core processes every HTTP request through a pipeline of
 * components called middleware.
 *
 * Each middleware component can:
 *
 * - inspect the request
 * - modify the request
 * - call the next middleware
 * - terminate the pipeline with a response
 *
 * Example pipeline:
 *
 * Request
 * → Logging middleware
 * → Authentication middleware
 * → Authorization middleware
 * → Endpoint handler
 * → Response
 *
 * Middleware are executed sequentially in the order they are
 * registered in the application startup configuration.
 *
 * This design allows developers to add cross-cutting behavior such as:
 *
 * - logging
 * - authentication
 * - caching
 * - error handling
 *
 *
 * --------------------------------------------------------------------
 * ROUTING
 * --------------------------------------------------------------------
 *
 * Routing determines which endpoint should handle an incoming
 * HTTP request.
 *
 * Each request contains:
 *
 * - HTTP method (GET, POST, PUT, DELETE)
 * - request path (URL)
 *
 * Example request:
 *
 * GET /users
 *
 * The routing system matches this request to a registered endpoint.
 *
 * Example route mapping:
 *
 * GET /users → UsersEndpoint
 *
 * Routing can be defined using:
 *
 * - attribute routing in controllers
 * - minimal API route mapping
 * - conventional route patterns
 *
 *
 * --------------------------------------------------------------------
 * MODEL BINDING
 * --------------------------------------------------------------------
 *
 * Model binding automatically converts HTTP request data into
 * strongly typed parameters for application methods.
 *
 * Data sources that can be bound include:
 *
 * - query string parameters
 * - route parameters
 * - request body JSON
 * - form data
 *
 * Example request:
 *
 * GET /products?page=2
 *
 * ASP.NET Core automatically converts the query parameter "page"
 * into an integer parameter of a controller action.
 *
 * This mechanism removes the need for manual parsing of request data.
 *
 *
 * --------------------------------------------------------------------
 * DEPENDENCY INJECTION
 * --------------------------------------------------------------------
 *
 * ASP.NET Core includes a built-in dependency injection container.
 *
 * Services are registered in the application startup configuration
 * and can be injected into controllers, endpoints, or other services.
 *
 * Example service registration:
 *
 * UserService → registered in DI container
 *
 * When a controller requires UserService, the framework automatically
 * provides an instance.
 *
 * Benefits of dependency injection:
 *
 * - reduces tight coupling
 * - improves testability
 * - centralizes object creation
 *
 *
 * --------------------------------------------------------------------
 * RESULT MAPPING
 * --------------------------------------------------------------------
 *
 * After processing a request, ASP.NET Core returns an HTTP response
 * to the client.
 *
 * Responses include:
 *
 * - status code
 * - response headers
 * - response body
 *
 * Common status codes:
 *
 * 200 OK
 * Request succeeded.
 *
 * 201 Created
 * Resource successfully created.
 *
 * 400 Bad Request
 * Invalid client request.
 *
 * 404 Not Found
 * Requested resource does not exist.
 *
 * 500 Internal Server Error
 * Server encountered an unexpected error.
 *
 * Endpoint handlers map application results into these HTTP responses.
 *
 *
 * --------------------------------------------------------------------
 * REQUEST FLOW
 *
 * A typical ASP.NET Core request lifecycle looks like this:
 *
 * Client sends HTTP request
 * → Middleware pipeline processes request
 * → Routing selects endpoint
 * → Model binding converts request data
 * → Controller or endpoint executes logic
 * → Result mapped to HTTP response
 * → Response returned to client
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * ASP.NET Core relies on several internal mechanisms:
 *
 * Middleware pipeline
 * Sequential processing of requests through registered components.
 *
 * Endpoint routing
 * Efficient lookup of request handlers based on URL patterns.
 *
 * Dependency injection container
 * Automatic construction and lifetime management of services.
 *
 * Model binding system
 * Conversion of HTTP data into strongly typed objects.
 *
 * Result execution
 * Translation of application results into HTTP responses.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Performance
 * ASP.NET Core is optimized for high-throughput web services.
 *
 * Cross-platform support
 * Applications run on Windows, Linux, and macOS.
 *
 * Modular architecture
 * Middleware allows flexible request processing.
 *
 * Built-in dependency injection
 * Simplifies application design and testing.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Learning curve
 * Understanding middleware pipelines and routing requires
 * familiarity with web concepts.
 *
 * Configuration complexity
 * Large applications require careful service registration
 * and pipeline configuration.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Middleware
 * A component that processes HTTP requests within the pipeline.
 *
 * Endpoint
 * A handler responsible for responding to a specific route.
 *
 * Routing
 * The process of mapping HTTP requests to application handlers.
 *
 * Model Binding
 * Automatic conversion of request data into strongly typed objects.
 *
 * Dependency Injection
 * A design technique where object dependencies are supplied by
 * a container rather than constructed directly.
 *
 * HTTP Response
 * The message returned to the client after request processing.
 */

public static class Examples
{
    // Demonstrates request pipeline concept.
    public static void MiddlewarePipelineExample()
    {
        Console.WriteLine("Request -> Logging -> Auth -> Endpoint -> Response");
    }

    // Shows route-to-handler mapping idea.
    public static void RoutingExample()
    {
        var routes = new Dictionary<string, string> { ["GET /users"] = "UsersEndpoint" };
        Console.WriteLine(routes["GET /users"]);
    }

    // Demonstrates model binding concept.
    public static void ModelBindingExample()
    {
        var query = new Dictionary<string, string> { ["page"] = "2" };
        int page = int.Parse(query["page"]);
        Console.WriteLine(page);
    }

    // Shows dependency injection into endpoint/controller.
    public static void DependencyInjectionExample()
    {
        var endpoint = new UsersEndpoint(new UserService());
        Console.WriteLine(endpoint.Get());
    }

    // Demonstrates result mapping to status codes.
    public static void ResultExample()
    {
        bool found = false;
        Console.WriteLine(found ? "200 OK" : "404 Not Found");
    }
}

public class UserService
{
    public List<string> GetUsers() => ["Ana", "Bob"];
}

public class UsersEndpoint(UserService service)
{
    public string Get() => string.Join(",", service.GetUsers());
}






