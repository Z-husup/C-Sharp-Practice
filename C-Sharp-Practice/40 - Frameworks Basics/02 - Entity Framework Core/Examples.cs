namespace C_Sharp_Practice.Frameworks_Basics.Entity_Framework_Core;

/*
 * TOPIC: Frameworks Basics / Entity Framework Core
 *
 * TOPIC DEFINITION
 * Entity Framework Core (EF Core) is an Object–Relational Mapper (ORM)
 * for .NET that allows developers to work with relational databases
 * using strongly typed C# objects instead of writing raw SQL queries.
 *
 * EF Core translates LINQ queries into SQL commands and executes them
 * against the configured database provider. It also tracks changes to
 * entity objects and persists those changes back to the database.
 *
 * Typical databases used with EF Core include:
 *
 * - SQL Server
 * - PostgreSQL
 * - SQLite
 * - MySQL
 *
 * EF Core simplifies data access by allowing developers to interact
 * with database tables as if they were in-memory collections of
 * objects.
 *
 *
 * --------------------------------------------------------------------
 * ENTITY MODELS
 * --------------------------------------------------------------------
 *
 * Entities represent tables in the database. Each instance of an
 * entity class corresponds to a row in a table.
 *
 * Example entity:
 *
 * User
 *   Id
 *   Name
 *
 * Mapping concept:
 *
 * C# class → database table
 * property → database column
 *
 * Example:
 *
 * class User
 * {
 *     int Id
 *     string Name
 * }
 *
 * Database table:
 *
 * Users
 * +----+------+
 * | Id | Name |
 * +----+------+
 * | 1  | Ana  |
 *
 * Entity classes usually have:
 *
 * - a primary key property
 * - simple properties mapped to columns
 * - navigation properties for relationships
 *
 *
 * --------------------------------------------------------------------
 * LINQ QUERIES
 * --------------------------------------------------------------------
 *
 * EF Core uses LINQ (Language Integrated Query) to express database
 * queries in C#.
 *
 * Example query:
 *
 * context.Users
 *     .Where(u => u.Id > 1)
 *     .Select(u => u.Name)
 *
 * EF Core translates this LINQ expression into SQL.
 *
 * Example generated SQL (conceptually):
 *
 * SELECT Name
 * FROM Users
 * WHERE Id > 1
 *
 * Benefits:
 *
 * - type safety
 * - compile-time checking
 * - IntelliSense support
 *
 *
 * --------------------------------------------------------------------
 * CHANGE TRACKING
 * --------------------------------------------------------------------
 *
 * One of the most important features of EF Core is change tracking.
 *
 * When entities are loaded from the database, the DbContext tracks
 * their state.
 *
 * Possible entity states include:
 *
 * Added
 * Entity should be inserted into the database.
 *
 * Modified
 * Entity was changed and needs updating.
 *
 * Deleted
 * Entity should be removed from the database.
 *
 * Unchanged
 * Entity matches the database state.
 *
 * When SaveChanges() is called, EF Core analyzes these tracked states
 * and generates the appropriate SQL commands.
 *
 *
 * --------------------------------------------------------------------
 * SAVE CHANGES WORKFLOW
 * --------------------------------------------------------------------
 *
 * The persistence workflow typically follows these steps:
 *
 * 1. Create or load entities
 * 2. Modify entity properties
 * 3. Call SaveChanges()
 *
 * Example flow:
 *
 * context.Add(entity)
 * → EF marks entity as "Added"
 *
 * context.SaveChanges()
 * → EF generates INSERT statement
 * → database stores new row
 *
 * EF Core automatically batches and executes the necessary SQL
 * operations based on tracked entity state.
 *
 *
 * --------------------------------------------------------------------
 * TRACKING VS NO-TRACKING QUERIES
 * --------------------------------------------------------------------
 *
 * By default, EF Core tracks entities retrieved from the database.
 *
 * Tracking queries
 *
 * - enable change detection
 * - allow updates through SaveChanges()
 *
 * No-tracking queries
 *
 * - disable tracking
 * - improve read performance
 * - useful for read-only scenarios
 *
 * Example:
 *
 * context.Users.AsNoTracking()
 *
 *
 * --------------------------------------------------------------------
 * MIGRATIONS
 * --------------------------------------------------------------------
 *
 * Database schema changes must be synchronized with the application
 * data model. EF Core migrations provide a structured way to manage
 * schema evolution.
 *
 * Migration workflow:
 *
 * 1. Modify entity classes
 * 2. Generate migration
 * 3. Apply migration to database
 *
 * Example commands:
 *
 * dotnet ef migrations add InitialCreate
 *
 * dotnet ef database update
 *
 * Migrations generate SQL scripts that modify the database schema
 * while preserving existing data when possible.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * EF Core relies on several internal systems:
 *
 * Query translation
 * LINQ expressions are translated into SQL queries.
 *
 * Change tracker
 * Tracks entity state transitions during a DbContext lifetime.
 *
 * Database providers
 * Provider libraries translate generic EF operations into
 * database-specific SQL dialects.
 *
 * Unit of Work pattern
 * DbContext acts as a unit of work that groups multiple operations
 * into a single transaction.
 *
 *
 * --------------------------------------------------------------------
 * BENEFITS
 *
 * Productivity
 * Developers interact with strongly typed objects rather than SQL.
 *
 * Maintainability
 * Schema changes are managed through migrations.
 *
 * Integration
 * Works naturally with LINQ and the .NET ecosystem.
 *
 * Database abstraction
 * Supports multiple database providers with the same API.
 *
 *
 * --------------------------------------------------------------------
 * TRADE-OFFS
 *
 * Abstraction overhead
 * Complex queries may generate inefficient SQL if not designed
 * carefully.
 *
 * Hidden behavior
 * Automatic tracking and lazy loading can cause unexpected queries.
 *
 * Performance considerations
 * Large object graphs may increase memory usage.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * ORM
 * Object–Relational Mapper that connects object-oriented code with
 * relational database structures.
 *
 * Entity
 * A class that represents a table in the database.
 *
 * DbContext
 * The central EF Core component responsible for managing database
 * connections, queries, and change tracking.
 *
 * Change Tracking
 * The mechanism used to detect modifications to entities.
 *
 * Migration
 * A versioned schema update used to evolve database structure over
 * time.
 *
 * LINQ
 * Language Integrated Query used to express queries in C# syntax.
 */

public static class Examples
{
    // Demonstrates entity modeling idea.
    public static void EntityModelExample()
    {
        var user = new EfUser { Id = 1, Name = "Ana" };
        Console.WriteLine(user.Name);
    }

    // Shows querying concept (simulated with LINQ to objects).
    public static void QueryExample()
    {
        List<EfUser> users = [new() { Id = 1, Name = "Ana" }, new() { Id = 2, Name = "Bob" }];
        var result = users.Where(u => u.Id > 1).Select(u => u.Name);
        Console.WriteLine(string.Join(",", result));
    }

    // Demonstrates add + save concept.
    public static void SaveChangesConceptExample()
    {
        Console.WriteLine("context.Add(entity); context.SaveChanges();");
    }

    // Shows update tracking concept.
    public static void TrackingExample()
    {
        var user = new EfUser { Id = 1, Name = "Ana" };
        user.Name = "Ana Maria";
        Console.WriteLine(user.Name);
    }

    // Demonstrates migration concept.
    public static void MigrationConceptExample()
    {
        Console.WriteLine("dotnet ef migrations add InitialCreate");
    }
}

public class EfUser
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}






