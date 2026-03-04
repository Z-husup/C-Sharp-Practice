namespace C_Sharp_Practice.LeetCode;

/*
 * TOPIC: LeetCode Practice Problems
 *
 * TOPIC DEFINITION
 * LeetCode problems are programming exercises commonly used to practice
 * algorithmic thinking and prepare for technical interviews. These
 * problems usually involve arrays, strings, hash tables, and other
 * common data structures.
 *
 * Solving these problems helps developers learn how to:
 * - analyze a problem
 * - choose an efficient algorithm
 * - optimize from a simple solution to a faster one
 *
 * Many problems have both a simple "brute force" solution and a more
 * optimized approach using better data structures or algorithms.
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * TwoSumBruteForce
 * Demonstrates the basic solution to the Two Sum problem. The algorithm
 * checks every possible pair of numbers in the array until it finds two
 * values that add up to the target.
 *
 * Time Complexity: O(n²)
 *
 * TwoSumHashMap
 * Demonstrates an optimized solution to the Two Sum problem using a
 * hash map (dictionary). The algorithm stores previously seen numbers
 * and checks whether the required complement already exists.
 *
 * Time Complexity: O(n)
 *
 * IsPalindromeNumber
 * Determines whether a number reads the same forward and backward.
 * This example converts the number to a string and compares characters
 * from both ends moving toward the center.
 *
 * RomanToInt
 * Converts a Roman numeral string into its integer value. Roman numerals
 * normally add values from left to right, but a smaller numeral before a
 * larger one means subtraction (for example IV = 4).
 *
 * MaxProfit
 * Solves the classic "Best Time to Buy and Sell Stock" problem.
 * The algorithm tracks the lowest price seen so far and calculates
 * the maximum possible profit from a single buy and sell operation.
 *
 * INTERNAL MECHANICS
 * - Problems are solved using loops, condition checks, and data structures.
 * - Hash maps often improve performance for lookup-based problems.
 * - Efficient solutions typically reduce the number of passes over the data.
 *
 * TERMINOLOGY
 *
 * Brute Force
 * A straightforward solution that checks all possibilities.
 *
 * Hash Map
 * A data structure that allows fast key-based lookup.
 *
 * Optimization
 * Improving an algorithm so that it runs faster or uses less memory.
 *
 * Time Complexity
 * A measure of how the running time of an algorithm grows as input size increases.
 */

public static class Examples
{
    // Solves Two Sum with a quadratic pair scan approach.
    public static int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }
        return [];
    }

    // Solves Two Sum in linear time using hash map lookup.
    public static int[] TwoSumHashMap(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];

            if (map.TryGetValue(need, out int idx))
                return [idx, i];

            map[nums[i]] = i;
        }

        return [];
    }

    // Checks whether a number reads the same forward/backward.
    public static bool IsPalindromeNumber(int x)
    {
        if (x < 0) return false;

        string s = x.ToString();

        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            if (s[i] != s[j])
                return false;
        }

        return true;
    }

    // Converts Roman numeral text into integer value.
    public static int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>
        {
            ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50,
            ['C'] = 100, ['D'] = 500, ['M'] = 1000
        };

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int value = map[s[i]];

            if (i < s.Length - 1 && value < map[s[i + 1]])
                total -= value;
            else
                total += value;
        }

        return total;
    }

    // Finds best single buy/sell profit in one pass.
    public static int MaxProfit(int[] prices)
    {
        int min = int.MaxValue;
        int profit = 0;

        foreach (int p in prices)
        {
            if (p < min)
                min = p;

            if (p - min > profit)
                profit = p - min;
        }

        return profit;
    }
}






