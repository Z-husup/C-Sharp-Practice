namespace C_Sharp_Practice.API_and_HTTP;

/*
 * TOPIC: API and HTTP
 *
 * TOPIC DEFINITION
 * HTTP is the primary protocol used for communication between
 * distributed systems on the web. Modern applications frequently
 * interact with external services such as REST APIs, microservices,
 * cloud platforms, and third-party integrations.
 *
 * In .NET applications these interactions are commonly implemented
 * using the HttpClient class. HttpClient allows applications to send
 * HTTP requests and receive responses from remote servers.
 *
 * Proper HTTP integration requires careful handling of request
 * construction, content formatting, response status interpretation,
 * cancellation, and network failure conditions.
 *
 * This section demonstrates fundamental techniques used when building
 * or consuming HTTP APIs:
 *
 * - configuring HttpClient
 * - constructing HTTP requests
 * - sending JSON payloads
 * - handling cancellation and timeouts
 * - interpreting HTTP response status codes
 *
 *
 * --------------------------------------------------------------------
 * CONCEPT EXPLANATIONS
 * --------------------------------------------------------------------
 *
 * HTTP CLIENT CONFIGURATION
 *
 * Problem
 * Applications that communicate with external services need a reliable
 * way to send HTTP requests. Improper client configuration can cause
 * connection exhaustion, timeouts, or inconsistent behavior.
 *
 * Solution
 * HttpClient provides a reusable component responsible for managing
 * connections and sending requests. It can be configured with base
 * addresses, default headers, and timeout settings.
 *
 * Example
 *
 * BaseAddress allows relative URLs to be used when making requests.
 *
 * Benefit
 * Centralizes configuration for outgoing HTTP communication.
 *
 * Trade-off
 * HttpClient should usually be reused rather than created repeatedly
 * to avoid socket exhaustion.
 *
 *
 * --------------------------------------------------------------------
 *
 * HTTP REQUEST MESSAGES
 *
 * Problem
 * Some HTTP operations require additional configuration such as
 * headers, custom methods, or query parameters.
 *
 * Solution
 * The HttpRequestMessage class allows developers to construct a full
 * HTTP request manually, specifying:
 *
 * - HTTP method (GET, POST, PUT, DELETE)
 * - request URI
 * - headers
 * - content body
 *
 * Structure
 *
 * HttpRequestMessage
 *   → Method
 *   → Request URI
 *   → Headers
 *   → Body
 *
 * Benefit
 * Provides full control over outgoing HTTP requests.
 *
 *
 * --------------------------------------------------------------------
 *
 * JSON PAYLOADS
 *
 * Problem
 * Most modern APIs exchange data using JSON. Applications must convert
 * objects into JSON text when sending data to servers.
 *
 * Solution
 * The System.Text.Json library serializes objects into JSON strings.
 * These strings are then placed inside HTTP request bodies using
 * StringContent with the "application/json" media type.
 *
 * Workflow
 *
 * Object → JSON serialization → HTTP request body
 *
 * Benefit
 * Ensures compatibility with REST APIs that expect JSON input.
 *
 * Trade-off
 * Incorrect serialization settings may produce incompatible schemas.
 *
 *
 * --------------------------------------------------------------------
 *
 * CANCELLATION AND TIMEOUTS
 *
 * Problem
 * Network operations may take an unpredictable amount of time.
 * Without cancellation support, requests could block indefinitely.
 *
 * Solution
 * Cancellation tokens allow requests to be canceled when they exceed
 * a time budget or when the caller decides to stop waiting.
 *
 * Workflow
 *
 * Request started → CancellationToken monitored → request canceled
 *
 * Benefit
 * Prevents long-running or stuck network operations from blocking
 * application resources.
 *
 *
 * --------------------------------------------------------------------
 *
 * HTTP STATUS HANDLING
 *
 * Problem
 * HTTP responses contain status codes that indicate the result of
 * a request. Ignoring these codes may hide failures.
 *
 * Common status code groups:
 *
 * 2xx – Success
 * 3xx – Redirection
 * 4xx – Client errors
 * 5xx – Server errors
 *
 * Solution
 * Applications should inspect the response status code and handle
 * failure scenarios appropriately.
 *
 * Example
 *
 * response.IsSuccessStatusCode
 *
 * Benefit
 * Enables robust error handling and retry strategies.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * HTTP communication follows a request-response model:
 *
 * Client sends HTTP request → Server processes request → Server
 * returns HTTP response.
 *
 * Each request contains:
 *
 * - HTTP method
 * - target URI
 * - headers
 * - optional body content
 *
 * Each response contains:
 *
 * - status code
 * - headers
 * - response body
 *
 * Reliable HTTP integration requires explicit handling of:
 *
 * - network failures
 * - timeouts
 * - invalid responses
 * - serialization errors
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * HTTP
 * Hypertext Transfer Protocol, the standard communication protocol
 * used on the web.
 *
 * API
 * Application Programming Interface that exposes functionality through
 * network requests.
 *
 * Endpoint
 * A specific URL where an API can be accessed.
 *
 * Request
 * A message sent by a client to a server.
 *
 * Response
 * A message returned by the server containing the result.
 *
 * Status Code
 * A numeric code indicating the outcome of an HTTP request.
 *
 * JSON
 * JavaScript Object Notation, a text-based format used to exchange
 * structured data between systems.
 */

public static class Examples
{
    // Demonstrates HttpClient instantiation and base address configuration.
    public static void HttpClientSetupExample()
    {
        using var client = new HttpClient { BaseAddress = new Uri("https://example.com") };
        Console.WriteLine(client.BaseAddress);
    }

    // Shows request message construction.
    public static void RequestMessageExample()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com/api/items");
        Console.WriteLine(request.Method);
    }

    // Demonstrates JSON content creation for POST-like requests.
    public static void JsonContentExample()
    {
        var payload = new { Name = "Ana", Score = 10 };
        string json = System.Text.Json.JsonSerializer.Serialize(payload);
        using var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        Console.WriteLine(content.Headers.ContentType?.MediaType);
    }

    // Shows cancellation token usage for outbound call patterns.
    public static async Task CancellationTokenExample()
    {
        using var cts = new CancellationTokenSource(1);
        try
        {
            await Task.Delay(100, cts.Token);
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Request canceled");
        }
    }

    // Demonstrates status code handling logic.
    public static void StatusCodeHandlingExample()
    {
        var response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
        Console.WriteLine(response.IsSuccessStatusCode ? "Success" : $"Failed: {(int)response.StatusCode}");
    }
}






