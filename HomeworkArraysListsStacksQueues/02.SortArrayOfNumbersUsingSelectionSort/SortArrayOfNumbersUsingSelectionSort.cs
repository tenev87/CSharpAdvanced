using System;

class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int[] sortNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            sortNumbers[i] = int.Parse(numbers[i]);
        }

        for (int k = 0; k < sortNumbers.Length; k++)
        {
            for (int j = k + 1; j < sortNumbers.Length; j++)
            {
                if (sortNumbers[j] < sortNumbers[k])
                {
                    int var = sortNumbers[j];
                    sortNumbers[j] = sortNumbers[k];
                    sortNumbers[k] = var;
                }
            }
        }
        Console.WriteLine(string.Join(" ", sortNumbers));
    }
}

