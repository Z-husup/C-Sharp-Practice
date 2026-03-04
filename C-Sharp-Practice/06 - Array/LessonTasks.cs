namespace C_Sharp_Practice.Array;

/*
 * LESSON TASKS
 * Topic: Array
 * Complete tasks in order and verify using Expected Output/Checks.
 */
public class TaskSetup
{
    public int[] Numbers { get; } = [5, 1, 9, 2, 7, 3];
    public string[] Words { get; } = ["Ana", "Bob", "Cem"];
    public List<int> NumberList { get; } = [1, 2, 3, 4, 5];
    public Dictionary<string, int> ScoreMap { get; } = new() { ["A"] = 10, ["B"] = 20, ["C"] = 30 };
}

public static class LessonTasks
{
    // Task 1: BasicExample
    // Goal: Implement Basic Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task01_BasicExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: TraverseExample
    // Goal: Implement Traverse Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task02_TraverseExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: ResizeWithCopyExample
    // Goal: Implement Resize With Copy Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task03_ResizeWithCopyExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: SortExample
    // Goal: Implement Sort Example and verify ascending ordering.
    // Implementation Steps:
    // 1) Use setup.Numbers as input.
    // 2) Sort values in ascending order.
    // 3) Print result with string.Join(",", values).
    // Input/Data to use: Input: setup.Numbers = [5,1,9,2,7,3]
    // Expected Output/Checks: Expected output order: 1,2,3,5,7,9
    public static void Task04_SortExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: SearchExample
    // Goal: Implement linear search with clear found/not-found behavior.
    // Implementation Steps:
    // 1) Search setup.Numbers for 7 and 8.
    // 2) Return/print index for each.
    // 3) Use -1 for missing value.
    // Input/Data to use: Input array: [5,1,9,2,7,3]
    // Expected Output/Checks: Expected indexes: 7 -> 4, 8 -> -1
    public static void Task05_SearchExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

