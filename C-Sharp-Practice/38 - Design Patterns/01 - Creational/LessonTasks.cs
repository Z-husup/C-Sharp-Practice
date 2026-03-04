namespace C_Sharp_Practice.Design_Patterns.Creational;

/*
 * LESSON TASKS
 * Topic: Creational
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
    // Task 1: FactoryMethodExample
    // Goal: Implement Factory Method Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task01_FactoryMethodExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 2: AbstractFactoryExample
    // Goal: Implement Abstract Factory Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task02_AbstractFactoryExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 3: BuilderExample
    // Goal: Implement add/insert behavior and prove state change.
    // Implementation Steps:
    // 1) Start from setup.NumberList or setup.ScoreMap.
    // 2) Insert/add one new element.
    // 3) Print count before and after, then print content.
    // Input/Data to use: Use setup.NumberList = [1,2,3,4,5]
    // Expected Output/Checks: Expected: count increases by 1 and new element appears in output.
    public static void Task03_BuilderExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 4: PrototypeExample
    // Goal: Implement Prototype Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task04_PrototypeExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

    // Task 5: SingletonExample
    // Goal: Implement Singleton Example as a complete working method.
    // Implementation Steps:
    // 1) Use TaskSetup data.
    // 2) Write the full method body.
    // 3) Print final result clearly.
    // Input/Data to use: Use setup.Numbers / setup.Words / setup.NumberList / setup.ScoreMap as relevant.
    // Expected Output/Checks: Output must be deterministic and easy to verify.
    public static void Task05_SingletonExample(TaskSetup setup)
    {
        // TODO: Implement task.
        throw new NotImplementedException("Finish task using instructions above.");
    }

}

