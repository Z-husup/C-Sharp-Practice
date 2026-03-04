namespace C_Sharp_Practice.Basic_Algorithm;

/*
 * LESSON TASKS
 * Topic: Basic Algorithm
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
    // Task 1: LinearSearch
    // Goal: Implement linear search with clear found/not-found behavior.
    // Implementation Steps:
    // 1) Search setup.Numbers for 7 and 8.
    // 2) Return/print index for each.
    // 3) Use -1 for missing value.
    // Input/Data to use: Input array: [5,1,9,2,7,3]
    // Expected Output/Checks: Expected indexes: 7 -> 4, 8 -> -1
    public static void Task01_LinearSearch(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: SumArray
    // Goal: Implement Sum Array as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task02_SumArray(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: MaxValue
    // Goal: Implement query/read operation with deterministic output.
    // Implementation Steps:
    // 1) Query one present value and one missing value if applicable.
    // 2) Handle missing case safely.
    // 3) Print query result(s).
    // Input/Data to use: Use setup data with known present/missing values.
    // Expected Output/Checks: Expected: correct boolean/value/index outputs for tested cases.
    public static void Task03_MaxValue(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: ContainsDuplicate
    // Goal: Implement query/read operation with deterministic output.
    // Implementation Steps:
    // 1) Query one present value and one missing value if applicable.
    // 2) Handle missing case safely.
    // 3) Print query result(s).
    // Input/Data to use: Use setup data with known present/missing values.
    // Expected Output/Checks: Expected: correct boolean/value/index outputs for tested cases.
    public static void Task04_ContainsDuplicate(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: PrefixSumExample
    // Goal: Implement Prefix Sum Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task05_PrefixSumExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

