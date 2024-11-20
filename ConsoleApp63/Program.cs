using System;

class QuickSort
{
    static int step = 0;

    static void Main()
    {
        int[] bestCase = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                           11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int[] worstCase = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11,
                            10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        Console.WriteLine("Лучший случай:");
        PrintArray(bestCase);
        QuickSortArray(bestCase, 0, bestCase.Length - 1);
        PrintArray(bestCase);
        Console.WriteLine($"Количество действий (лучший случай): {step}");

        step = 0;

        Console.WriteLine("Худший случай:");
        PrintArray(worstCase);
        QuickSortArray(worstCase, 0, worstCase.Length - 1);
        PrintArray(worstCase);
        Console.WriteLine($"Количество действий (худший случай): {step}");
    }

    static void QuickSortArray(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortArray(array, low, pivotIndex - 1);
            QuickSortArray(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            step++;
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, high);
        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}