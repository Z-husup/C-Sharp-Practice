namespace C_Sharp_Practice.Serialization;

/*
 * TOPIC: Serialization
 *
 * TOPIC DEFINITION
 * Serialization is the process of converting an object in memory into
 * a format that can be stored or transmitted, such as JSON or XML.
 *
 * Deserialization is the reverse process: converting serialized data
 * back into an object in memory.
 *
 * Serialization is commonly used when sending data between applications,
 * storing data in files, or communicating with web APIs.
 *
 * In modern .NET applications, JSON serialization is commonly performed
 * using the System.Text.Json library.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * SerializeExample
 * Demonstrates converting an object into a JSON string. The serializer
 * reads the object's properties and generates a text representation
 * that can be stored or transmitted.
 *
 * DeserializeExample
 * Demonstrates converting JSON text back into a typed object. The
 * deserializer reads the JSON structure and populates the object's
 * properties with the corresponding values.
 *
 * OptionsExample
 * Demonstrates using serializer options. Options allow developers
 * to control how JSON is generated, such as enabling indentation
 * for easier readability.
 *
 * NamingPolicyExample
 * Demonstrates property naming policies. A naming policy changes how
 * property names appear in the JSON output, such as converting names
 * to camelCase.
 *
 * DictionarySerializationExample
 * Demonstrates serializing dictionary data. Dictionaries are converted
 * into JSON objects where the keys become property names and the values
 * become property values.
 *
 * INTERNAL MECHANICS
 * - The serializer reads object properties and converts them into JSON text.
 * - The deserializer parses JSON text and reconstructs the corresponding object.
 * - Serializer options control formatting and naming conventions.
 *
 * TERMINOLOGY
 *
 * Serialization
 * Converting an object into a format that can be stored or transmitted.
 *
 * Deserialization
 * Reconstructing an object from serialized data.
 *
 * JSON
 * JavaScript Object Notation, a lightweight text format widely used
 * for data exchange between systems.
 *
 * DTO (Data Transfer Object)
 * A simple object used to transfer structured data between systems.
 */

public static class Examples
{
    // Demonstrates object serialization to JSON.
    public static void SerializeExample()
    {
        var user = new UserDto("Ana", 25);
        string json = System.Text.Json.JsonSerializer.Serialize(user);
        Console.WriteLine(json);
    }

    // Shows JSON deserialization into typed object.
    public static void DeserializeExample()
    {
        string json = "{\"Name\":\"Bob\",\"Age\":30}";
        var user = System.Text.Json.JsonSerializer.Deserialize<UserDto>(json);
        Console.WriteLine(user?.Name);
    }

    // Demonstrates indented JSON output options.
    public static void OptionsExample()
    {
        var obj = new { x = 1, y = 2 };
        var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };

        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(obj, options));
    }

    // Shows property naming policy customization.
    public static void NamingPolicyExample()
    {
        var user = new UserDto("Cem", 20);

        var options = new System.Text.Json.JsonSerializerOptions
        {
            PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
        };

        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(user, options));
    }

    // Demonstrates dictionary serialization.
    public static void DictionarySerializationExample()
    {
        var data = new Dictionary<string, int> { ["a"] = 1, ["b"] = 2 };

        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));
    }
}

public record UserDto(string Name, int Age);




