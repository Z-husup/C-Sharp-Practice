namespace C_Sharp_Practice.Basic;

/*
 * LESSON TASKS
 * Topic: Basic
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
    // Task 1: VariablesAndOutput
    // Goal: Implement Variables And Output as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task01_VariablesAndOutput(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: TypeConversion
    // Goal: Implement safe conversion from text to number.
    // Implementation Steps:
    // 1) Use valid text "42" and invalid text "abc".
    // 2) Handle invalid parse without crashing.
    // 3) Print success flag and resulting value.
    // Input/Data to use: Inputs: "42", "abc"
    // Expected Output/Checks: Expected: valid parse true with 42; invalid parse false with fallback value.
    public static void Task02_TypeConversion(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: ConstantsExample
    // Goal: Implement Constants Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task03_ConstantsExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: StringInterpolationExample
    // Goal: Implement String Interpolation Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task04_StringInterpolationExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: TryParseExample
    // Goal: Implement safe conversion from text to number.
    // Implementation Steps:
    // 1) Use valid text "42" and invalid text "abc".
    // 2) Handle invalid parse without crashing.
    // 3) Print success flag and resulting value.
    // Input/Data to use: Inputs: "42", "abc"
    // Expected Output/Checks: Expected: valid parse true with 42; invalid parse false with fallback value.
    public static void Task05_TryParseExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

