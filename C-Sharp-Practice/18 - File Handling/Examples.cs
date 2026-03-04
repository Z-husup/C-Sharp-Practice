namespace C_Sharp_Practice.File_Handling;

/*
 * TOPIC: File Handling
 *
 * TOPIC DEFINITION
 * File handling in C# allows programs to read and write data to files
 * stored on the computer’s file system. This makes it possible to save
 * information permanently and retrieve it later.
 *
 * The .NET library provides classes such as File, Directory, Path, and
 * FileInfo to perform common file system operations such as creating files,
 * writing data, reading content, and checking file information.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * WriteReadExample
 * Demonstrates writing text to a file and then reading the content back
 * from the file.
 *
 * AppendExample
 * Shows how to add new content to an existing file without replacing the
 * existing data.
 *
 * ExistsExample
 * Demonstrates how to check whether a file exists before performing
 * operations on it.
 *
 * DirectoryExample
 * Shows how to create a directory and verify that it exists on the
 * file system.
 *
 * FileInfoExample
 * Demonstrates how to use the FileInfo class to retrieve information
 * about a file, such as its size.
 *
 * INTERNAL MECHANICS
 * - The File class provides static methods for common file operations.
 * - The Directory class provides methods for working with folders.
 * - The Path class helps construct safe file paths across operating systems.
 * - FileInfo provides detailed metadata about a file.
 *
 * TERMINOLOGY
 * File: A container for storing data on disk.
 * Directory: A folder used to organize files.
 * Path: The location of a file or directory in the file system.
 * Append: Adding new data to the end of an existing file.
 * Metadata: Information about a file, such as size or creation time.
 */

public static class Examples
{
    // Demonstrates writing data to disk and reading it back.
    public static void WriteReadExample()
    {
        string path = Path.Combine(Path.GetTempPath(), "practice.txt");
        File.WriteAllText(path, "Hello file handling");
        Console.WriteLine(File.ReadAllText(path));
    }

    // Shows appending additional content to existing files.
    public static void AppendExample()
    {
        string path = Path.Combine(Path.GetTempPath(), "practice_append.txt");
        File.WriteAllText(path, "Line1\n");
        File.AppendAllText(path, "Line2\n");
        Console.WriteLine(File.ReadAllText(path));
    }

    // Demonstrates existence checks before file operations.
    public static void ExistsExample()
    {
        string path = Path.Combine(Path.GetTempPath(), "practice_exists.txt");
        File.WriteAllText(path, "data");
        Console.WriteLine(File.Exists(path));
    }

    // Shows creating and validating directory paths.
    public static void DirectoryExample()
    {
        string dir = Path.Combine(Path.GetTempPath(), "practice_dir");
        Directory.CreateDirectory(dir);
        Console.WriteLine(Directory.Exists(dir));
    }

    // Demonstrates metadata inspection with FileInfo.
    public static void FileInfoExample()
    {
        string path = Path.Combine(Path.GetTempPath(), "practice_info.txt");
        File.WriteAllText(path, "abc");
        var info = new FileInfo(path);
        Console.WriteLine(info.Length);
    }
}
