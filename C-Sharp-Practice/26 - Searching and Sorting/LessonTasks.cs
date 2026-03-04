namespace C_Sharp_Practice.Searching_and_Sorting;

/*
 * LESSON TASKS
 * Topic: Searching and Sorting
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
    // Task 1: BinarySearch
    // Goal: Implement linear search with clear found/not-found behavior.
    // Implementation Steps:
    // 1) Search setup.Numbers for 7 and 8.
    // 2) Return/print index for each.
    // 3) Use -1 for missing value.
    // Input/Data to use: Input array: [5,1,9,2,7,3]
    // Expected Output/Checks: Expected indexes: 7 -> 4, 8 -> -1
    public static void Task01_BinarySearch(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: BubbleSort
    // Goal: Implement Bubble Sort and verify ascending ordering.
    // Implementation Steps:
    // 1) Use setup.Numbers as input.
    // 2) Sort values in ascending order.
    // 3) Print result with string.Join(",", values).
    // Input/Data to use: Input: setup.Numbers = [5,1,9,2,7,3]
    // Expected Output/Checks: Expected output order: 1,2,3,5,7,9
    public static void Task02_BubbleSort(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: SelectionSort
    // Goal: Implement the LINQ pipeline exactly for the method scenario.
    // Implementation Steps:
    // 1) Start with setup collections.
    // 2) Apply named LINQ operators step-by-step.
    // 3) Print final values/count clearly.
    // Input/Data to use: Use setup.Numbers and setup.Words where possible.
    // Expected Output/Checks: Expected: output matches the query transformation rules.
    public static void Task03_SelectionSort(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: BuiltInSortExample
    // Goal: Implement Built In Sort Example and verify ascending ordering.
    // Implementation Steps:
    // 1) Use setup.Numbers as input.
    // 2) Sort values in ascending order.
    // 3) Print result with string.Join(",", values).
    // Input/Data to use: Input: setup.Numbers = [5,1,9,2,7,3]
    // Expected Output/Checks: Expected output order: 1,2,3,5,7,9
    public static void Task04_BuiltInSortExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: LinearSearchExample
    // Goal: Implement linear search with clear found/not-found behavior.
    // Implementation Steps:
    // 1) Search setup.Numbers for 7 and 8.
    // 2) Return/print index for each.
    // 3) Use -1 for missing value.
    // Input/Data to use: Input array: [5,1,9,2,7,3]
    // Expected Output/Checks: Expected indexes: 7 -> 4, 8 -> -1
    public static void Task05_LinearSearchExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

