namespace C_Sharp_Practice.Searching_and_Sorting;
/*
 * TOPIC: Sorting Algorithms
 *
 * TOPIC DEFINITION
 * Sorting algorithms rearrange elements in a collection so that they
 * follow a specific order, typically ascending or descending.
 *
 * Sorting is one of the most fundamental operations in computer science
 * because many other algorithms become more efficient when data is sorted.
 *
 * For example:
 * - Searching algorithms often assume sorted data.
 * - Databases rely on sorting for indexing and query optimization.
 * - Data analysis frequently requires sorted datasets.
 *
 * Sorting algorithms differ in their:
 *
 * - Time complexity
 * - Memory usage
 * - Stability (whether equal elements preserve their order)
 * - Implementation complexity
 *
 * Some algorithms are simple but slow, while others are more complex
 * but highly efficient for large datasets.
 *
 *
 * INTERNAL TOPICS EXPLAINED IN THIS FILE
 *
 * BubbleSort
 * Demonstrates one of the simplest sorting algorithms. Bubble sort
 * repeatedly compares adjacent elements and swaps them if they are
 * in the wrong order.
 *
 * After each pass, the largest element "bubbles" to the end of the array.
 *
 * Time Complexity:
 * Worst case: O(n²)
 * Best case: O(n)
 *
 *
 * SelectionSort
 * Demonstrates selection sort, where the smallest remaining element
 * is repeatedly selected and placed in its correct position.
 *
 * Each iteration finds the minimum value in the unsorted portion
 * of the array.
 *
 * Time Complexity:
 * O(n²)
 *
 *
 * InsertionSort
 * Demonstrates insertion sort, which builds a sorted portion of
 * the array one element at a time by inserting each new element
 * into its correct position.
 *
 * Time Complexity:
 * Worst case: O(n²)
 * Best case: O(n)
 *
 *
 * QuickSort
 * Demonstrates quick sort, a divide-and-conquer algorithm that
 * selects a pivot element and partitions the array into elements
 * smaller and larger than the pivot.
 *
 * The algorithm then recursively sorts the partitions.
 *
 * Time Complexity:
 * Average: O(n log n)
 * Worst case: O(n²)
 *
 *
 * INTERNAL MECHANICS
 *
 * Sorting algorithms generally follow these patterns:
 *
 * Comparison
 * Elements are compared to determine their relative order.
 *
 * Swapping
 * Elements may be exchanged to place them in the correct position.
 *
 * Partitioning
 * Some algorithms divide the collection into smaller segments.
 *
 * Iteration or recursion
 * The algorithm repeats until the entire collection is sorted.
 *
 *
 * TERMINOLOGY
 *
 * Sorting
 * The process of arranging elements in a specified order.
 *
 * Stable Sort
 * A sorting algorithm that preserves the relative order of equal elements.
 *
 * Pivot
 * An element used to partition data in divide-and-conquer algorithms.
 *
 * Partition
 * Dividing data into smaller groups based on a pivot value.
 *
 * Time Complexity
 * A measure of how execution time grows relative to input size.
 */

public static class SortingExamples
{
    // Bubble Sort implementation.
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }

    // Selection Sort implementation.
    public static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }

    // Insertion Sort implementation.
    public static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    // Quick Sort entry point.
    public static void QuickSort(int[] arr)
    {
        QuickSortInternal(arr, 0, arr.Length - 1);
    }

    private static void QuickSortInternal(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSortInternal(arr, low, pivotIndex - 1);
            QuickSortInternal(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

        return i + 1;
    }
}