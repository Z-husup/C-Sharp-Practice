namespace C_Sharp_Practice.Basic_Algorithm;

/*
 * TOPIC: Basic Algorithms
 *
 * TOPIC DEFINITION
 * Basic algorithms are step-by-step procedures used to process data
 * stored in collections such as arrays or lists. These algorithms
 * provide fundamental patterns for searching, aggregating values,
 * finding extreme elements, and preparing data for efficient queries.
 *
 * Understanding these simple algorithms is important because they
 * form the foundation for more advanced algorithms and data structures.
 * Most basic algorithms rely on iterating through a collection and
 * performing a specific operation on each element.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * LinearSearch
 * Demonstrates linear search, one of the simplest searching algorithms.
 * The algorithm scans each element of the array from left to right
 * until the target value is found or the end of the array is reached.
 *
 * Time Complexity:
 * O(n) in the worst case because each element may need to be checked.
 *
 * SumArray
 * Demonstrates aggregation, where all elements in a collection are
 * combined into a single result. In this case, the algorithm computes
 * the total sum of all values in the array.
 *
 * Time Complexity:
 * O(n) because each element must be processed once.
 *
 * MaxValue
 * Demonstrates how to find the maximum value in an array. The algorithm
 * keeps track of the largest value encountered while traversing the
 * collection.
 *
 * Time Complexity:
 * O(n) because each element must be compared once.
 *
 * ContainsDuplicate
 * Demonstrates duplicate detection using a HashSet. As elements are
 * processed, they are stored in a set. If an element already exists
 * in the set, a duplicate has been found.
 *
 * Time Complexity:
 * O(n) on average because hash-based lookups are typically constant time.
 *
 * PrefixSumExample
 * Demonstrates prefix sums, a technique where each position stores
 * the cumulative sum of all elements up to that position. Prefix sums
 * are useful for quickly calculating the sum of subranges in an array.
 *
 * INTERNAL MECHANICS
 * - Most algorithms iterate through the collection using loops.
 * - Intermediate values are stored in variables or auxiliary structures.
 * - The algorithm terminates once the desired result is computed.
 *
 * TERMINOLOGY
 *
 * Algorithm
 * A step-by-step procedure used to solve a computational problem.
 *
 * Iteration
 * Repeatedly processing elements of a collection one by one.
 *
 * Aggregation
 * Combining multiple values into a single result such as a sum or product.
 *
 * Time Complexity
 * A measure of how the running time of an algorithm grows as the input size increases.
 */

public static class Examples
{
    // Implements linear search to find a target index in unsorted input.
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

    // Computes total sum using a single pass accumulation pattern.
    public static int SumArray(int[] arr)
    {
        int sum = 0;
        foreach (int value in arr)
        {
            sum += value;
        }

        return sum;
    }

    // Finds maximum element with one traversal.
    public static int MaxValue(int[] arr)
    {
        int max = arr[0];
        foreach (int n in arr)
        {
            if (n > max)
            {
                max = n;
            }
        }

        return max;
    }

    // Detects duplicates using hash-based membership checks.
    public static bool ContainsDuplicate(int[] arr)
    {
        var set = new HashSet<int>();
        foreach (int n in arr)
        {
            if (!set.Add(n))
            {
                return true;
            }
        }

        return false;
    }

    // Builds prefix sums for fast range-sum style queries.
    public static void PrefixSumExample()
    {
        int[] arr = { 1, 2, 3, 4 };
        int[] prefix = new int[arr.Length];

        prefix[0] = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            prefix[i] = prefix[i - 1] + arr[i];
        }

        Console.WriteLine(string.Join(",", prefix));
    }
}


