namespace C_Sharp_Practice.Database_Basics;

/*
 * TOPIC: Database Basics
 *
 * TOPIC DEFINITION
 * Databases are systems designed to store, organize, retrieve, and
 * modify structured information efficiently. Most backend applications
 * rely on databases to persist application state such as users,
 * transactions, logs, and configuration data.
 *
 * Data inside databases is typically structured using tables composed
 * of rows and columns. Each row represents a record, and each column
 * represents a specific attribute of that record.
 *
 * Applications interact with databases through queries that retrieve
 * or modify data. In relational databases these queries are typically
 * written in SQL (Structured Query Language).
 *
 * This topic introduces several foundational concepts used when working
 * with databases inside applications:
 *
 * - representing tabular data in memory
 * - querying rows from tables
 * - constructing parameterized database commands
 * - understanding transactions
 * - mapping database rows into application objects
 *
 *
 * --------------------------------------------------------------------
 * CONCEPT EXPLANATIONS
 * --------------------------------------------------------------------
 *
 * IN-MEMORY TABLE MODELING
 *
 * Problem
 * Applications often need to represent database-like structures in
 * memory before interacting with an actual database.
 *
 * Solution
 * The DataTable class provides an in-memory representation of a
 * relational table. It allows defining columns, inserting rows, and
 * accessing records programmatically.
 *
 * Structure
 *
 * Table
 *   → Columns (schema definition)
 *   → Rows (stored records)
 *
 * Example
 *
 * Users
 * +----+------+
 * | Id | Name |
 * +----+------+
 * | 1  | Ana  |
 * +----+------+
 *
 * Benefit
 * Allows manipulation of structured data without needing a live
 * database connection.
 *
 * Trade-off
 * DataTable is memory-heavy and typically used for demonstrations or
 * small datasets rather than high-performance production systems.
 *
 *
 * --------------------------------------------------------------------
 *
 * QUERYING ROWS
 *
 * Problem
 * Applications frequently need to retrieve only specific records that
 * match certain conditions.
 *
 * Example requirement
 *
 * "Return all users where Id > 1"
 *
 * Solution
 * Queries can be performed using filtering logic. In .NET, LINQ
 * provides powerful querying capabilities that allow developers to
 * filter and transform collections.
 *
 * Workflow
 *
 * Table rows → LINQ filtering → projected results
 *
 * Benefit
 * LINQ provides a consistent query syntax for working with many data
 * sources including in-memory collections, databases, and XML.
 *
 * Trade-off
 * LINQ queries executed in memory may be slower than database-side
 * queries for very large datasets.
 *
 *
 * --------------------------------------------------------------------
 *
 * PARAMETERIZED COMMANDS
 *
 * Problem
 * Constructing SQL queries by concatenating user input directly into
 * query strings can introduce security vulnerabilities known as
 * SQL injection attacks.
 *
 * Example of unsafe query
 *
 * SELECT * FROM Users WHERE Name = '" + userInput + "'
 *
 * Solution
 * Parameterized queries separate the SQL command structure from the
 * data values that will be inserted into the query.
 *
 * Example
 *
 * SELECT * FROM Users WHERE Id = @id
 *
 * The @id parameter is replaced with a safe value at runtime.
 *
 * Benefit
 * - Prevents SQL injection attacks
 * - Improves query plan reuse in databases
 *
 * Trade-off
 * Requires explicit parameter binding when executing commands.
 *
 *
 * --------------------------------------------------------------------
 *
 * TRANSACTIONS
 *
 * Problem
 * Many database operations involve multiple steps that must either all
 * succeed or all fail together.
 *
 * Example
 *
 * Transfer money between two accounts:
 *
 * 1. Deduct amount from account A
 * 2. Add amount to account B
 *
 * If the second step fails but the first succeeds, the database would
 * enter an inconsistent state.
 *
 * Solution
 * Transactions group multiple operations into a single atomic unit.
 *
 * Transaction workflow
 *
 * Begin transaction
 * → Execute operations
 * → Commit if successful
 * → Rollback if failure occurs
 *
 * Benefit
 * Ensures database consistency and reliability.
 *
 * Trade-off
 * Long transactions can lock resources and reduce concurrency.
 *
 *
 * --------------------------------------------------------------------
 *
 * OBJECT MAPPING
 *
 * Problem
 * Database rows are typically returned as generic structures such as
 * tables or dictionaries. Applications, however, often work with
 * strongly typed objects.
 *
 * Solution
 * Mapping converts database rows into application objects.
 *
 * Example
 *
 * Database row
 *
 * { Id: 1, Name: "Ana" }
 *
 * Application object
 *
 * User { Id = 1, Name = "Ana" }
 *
 * This process is sometimes called:
 *
 * Object-Relational Mapping (ORM)
 *
 * Benefit
 * Strong typing improves readability and reduces runtime errors.
 *
 * Trade-off
 * Mapping introduces additional abstraction and processing overhead.
 *
 *
 * --------------------------------------------------------------------
 * INTERNAL MECHANICS
 *
 * Database systems internally manage several responsibilities:
 *
 * Data storage
 * Information is persisted on disk in structured formats.
 *
 * Query execution
 * Database engines parse SQL queries and generate execution plans.
 *
 * Indexing
 * Data structures such as B-trees are used to accelerate lookups.
 *
 * Transaction management
 * Databases guarantee consistency using mechanisms such as locking
 * and write-ahead logging.
 *
 * Concurrency control
 * Multiple users can read and write data simultaneously without
 * corrupting database state.
 *
 *
 * --------------------------------------------------------------------
 * TERMINOLOGY
 *
 * Table
 * A structured collection of rows organized into columns.
 *
 * Row
 * A single record in a table.
 *
 * Column
 * A field describing one attribute of a row.
 *
 * Query
 * A request to retrieve or modify data in a database.
 *
 * Parameterized Query
 * A query where user input is supplied as parameters instead of
 * directly embedded in the SQL string.
 *
 * Transaction
 * A sequence of operations executed as a single atomic unit that
 * either fully succeeds or fully fails.
 *
 * Mapping
 * The process of converting database records into application objects.
 */

public static class Examples
{
    // Demonstrates in-memory table modeling with DataTable.
    public static void DataTableExample()
    {
        var table = new System.Data.DataTable("Users");
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Rows.Add(1, "Ana");
        Console.WriteLine(table.Rows.Count);
    }

    // Shows filtering rows with LINQ over DataTable.
    public static void QueryRowsExample()
    {
        var table = CreateSampleTable();
        var names = table.Rows.Cast<System.Data.DataRow>()
            .Where(r => (int)r["Id"] > 1)
            .Select(r => (string)r["Name"]);
        Console.WriteLine(string.Join(",", names));
    }

    // Demonstrates parameterized SQL command construction.
    public static void ParameterizedCommandExample()
    {
        string sql = "SELECT * FROM Users WHERE Id = @id";
        var parameters = new Dictionary<string, object> { ["@id"] = 1 };
        Console.WriteLine($"{sql} | params={parameters.Count}");
    }

    // Shows transaction concept with pseudo workflow.
    public static void TransactionConceptExample()
    {
        Console.WriteLine("Begin transaction -> execute commands -> commit/rollback");
    }

    // Demonstrates mapping row data to object.
    public static void MappingExample()
    {
        var table = CreateSampleTable();
        var users = table.Rows.Cast<System.Data.DataRow>()
            .Select(r => new User((int)r["Id"], (string)r["Name"]));
        Console.WriteLine(users.First().Name);
    }

    private static System.Data.DataTable CreateSampleTable()
    {
        var table = new System.Data.DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Rows.Add(1, "Ana");
        table.Rows.Add(2, "Bob");
        return table;
    }
}

public record User(int Id, string Name);






