namespace C_Sharp_Practice.Searching_and_Sorting;

/*
 * TOPIC: Searching Algorithms
 *
 * TOPIC DEFINITION
 * Searching algorithms are procedures used to locate a specific element
 * within a collection of data. The goal of a search algorithm is to
 * determine whether a target value exists in the dataset and, if so,
 * return its position or reference.
 *
 * Searching is one of the most fundamental operations in computer science.
 * Many systems rely on efficient search operations, including databases,
 * search engines, and data processing systems.
 *
 * The efficiency of a search algorithm often depends on whether the data
 * is sorted or unsorted.
 *
 * For example:
 * - Linear search works on any collection but is relatively slow.
 * - Binary search is extremely efficient but requires sorted data.
 *
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * LinearSearch
 * Demonstrates the simplest searching algorithm. The algorithm scans
 * the collection from the beginning to the end until the target value
 * is found.
 *
 * Time Complexity:
 * Worst case: O(n)
 *
 *
 * BinarySearch
 * Demonstrates binary search, a divide-and-conquer algorithm that works
 * only on sorted arrays. The algorithm repeatedly divides the search
 * interval in half to quickly locate the target.
 *
 * Time Complexity:
 * O(log n)
 *
 *
 * BreadthFirstSearch
 * Demonstrates BFS traversal used for searching in graphs or trees.
 * BFS explores nodes level by level using a queue.
 *
 *
 * DepthFirstSearch
 * Demonstrates DFS traversal used for exploring graphs or trees.
 * DFS explores nodes by going as deep as possible before backtracking.
 *
 *
 * INTERNAL MECHANICS
 *
 * Searching algorithms typically rely on:
 *
 * Comparison
 * Checking whether the current element matches the target value.
 *
 * Traversal
 * Moving through the collection or data structure systematically.
 *
 * Partitioning
 * Reducing the search space by dividing the dataset.
 *
 * Auxiliary structures
 * Some algorithms use additional data structures such as stacks or queues.
 *
 *
 * TERMINOLOGY
 *
 * Search Space
 * The portion of data currently being examined.
 *
 * Target
 * The value being searched for.
 *
 * Traversal
 * The process of visiting elements or nodes in a data structure.
 *
 * Divide and Conquer
 * A technique where the problem is divided into smaller subproblems.
 *
 * Time Complexity
 * A measure of how algorithm runtime grows with input size.
 */

public static class SearchExamples
{
    // Performs linear search on an unsorted array.
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    // Performs binary search on a sorted array.
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    // Breadth-first search traversal of a graph.
    public static void BreadthFirstSearch(Dictionary<int, List<int>> graph, int start)
    {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();

        visited.Add(start);
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            Console.WriteLine(node);

            foreach (var neighbor in graph[node])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    // Depth-first search traversal of a graph.
    public static void DepthFirstSearch(Dictionary<int, List<int>> graph, int start)
    {
        var visited = new HashSet<int>();
        DFS(graph, start, visited);
    }

    private static void DFS(Dictionary<int, List<int>> graph, int node, HashSet<int> visited)
    {
        if (visited.Contains(node))
            return;

        visited.Add(node);
        Console.WriteLine(node);

        foreach (var neighbor in graph[node])
        {
            DFS(graph, neighbor, visited);
        }
    }
}