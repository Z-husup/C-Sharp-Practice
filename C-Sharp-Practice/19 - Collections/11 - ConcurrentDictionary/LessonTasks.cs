namespace C_Sharp_Practice.Collections.ConcurrentDictionary;

/*
 * LESSON TASKS
 * Topic: ConcurrentDictionary
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

    // Task 2: GetOrAddExample
    // Goal: Implement add/insert behavior and prove state change.
    // Implementation Steps:
    // 1) Start from setup.NumberList or setup.ScoreMap.
    // 2) Insert/add one new element.
    // 3) Print count before and after, then print content.
    // Input/Data to use: Use setup.NumberList = [1,2,3,4,5]
    // Expected Output/Checks: Expected: count increases by 1 and new element appears in output.
    public static void Task02_GetOrAddExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: AddOrUpdateExample
    // Goal: Implement add/insert behavior and prove state change.
    // Implementation Steps:
    // 1) Start from setup.NumberList or setup.ScoreMap.
    // 2) Insert/add one new element.
    // 3) Print count before and after, then print content.
    // Input/Data to use: Use setup.NumberList = [1,2,3,4,5]
    // Expected Output/Checks: Expected: count increases by 1 and new element appears in output.
    public static void Task03_AddOrUpdateExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: TryRemoveExample
    // Goal: Implement remove/clear logic and verify final state.
    // Implementation Steps:
    // 1) Initialize data from setup.
    // 2) Run removal operation.
    // 3) Print resulting count and remaining values.
    // Input/Data to use: Use setup.NumberList = [1,2,3,4,5]
    // Expected Output/Checks: Expected: removed values are absent and count is correct.
    public static void Task04_TryRemoveExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: TryGetValueExample
    // Goal: Implement query/read operation with deterministic output.
    // Implementation Steps:
    // 1) Query one present value and one missing value if applicable.
    // 2) Handle missing case safely.
    // 3) Print query result(s).
    // Input/Data to use: Use setup data with known present/missing values.
    // Expected Output/Checks: Expected: correct boolean/value/index outputs for tested cases.
    public static void Task05_TryGetValueExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

