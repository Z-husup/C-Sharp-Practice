namespace C_Sharp_Practice.Architectures.CQRS;

/*
 * LESSON TASKS
 * Topic: CQRS
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
    // Task 1: CommandExample
    // Goal: Implement Command Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task01_CommandExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: QueryExample
    // Goal: Implement Query Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task02_QueryExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: SeparateModelsExample
    // Goal: Implement Separate Models Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task03_SeparateModelsExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: ValidationExample
    // Goal: Implement explicit exception handling path.
    // Implementation Steps:
    // 1) Trigger one failing input intentionally.
    // 2) Catch specific exception type.
    // 3) Print handled error message.
    // Input/Data to use: Use invalid input (e.g., divide by zero, invalid parse).
    // Expected Output/Checks: Expected: no unhandled exception; friendly error output shown.
    public static void Task04_ValidationExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: MediatorStyleExample
    // Goal: Implement Mediator Style Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task05_MediatorStyleExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

