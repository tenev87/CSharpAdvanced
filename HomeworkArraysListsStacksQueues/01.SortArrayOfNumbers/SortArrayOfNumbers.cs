using System;

class SortArrayOfNumbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int[] sortNumbers = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            sortNumbers[i] = int.Parse(numbers[i]);
        }
        Array.Sort(sortNumbers);
        Console.WriteLine(string.Join(" ", sortNumbers));
    }
}

