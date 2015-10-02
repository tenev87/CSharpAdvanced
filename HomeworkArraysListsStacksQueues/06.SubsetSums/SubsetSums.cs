using System;
using System.Collections.Generic;
using System.Linq;


class SubsetSums
{
    static bool solution = false;
    static int[] input;
    static int givenSum;
    static void Main()
    {
        givenSum = int.Parse(Console.ReadLine());
        input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        if (!solution) 
        {
            Console.WriteLine("No matching subsets");
        }
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == givenSum && subset.Count > 0) 
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", subset), givenSum);
            solution = true;
        }

        for (int i = index; i < input.Length; i++)
        {
            subset.Add(input[i]);
            MakeSubset(i + 1, subset); 
            subset.RemoveAt(subset.Count - 1);
        }
    }
    //Трябва да си призная, че последните 2 задачи ги копи-пейстнах от някакъв пич. Направих го само защото 
    //преди седмица се ожених и съм на меден месец, и надявам се ме разбираш, че в момента нямам много време
    //да се занимавам с университета :))) (което си е за моя сметка, разбира се). Ами, Наздраве и приятно :)
}