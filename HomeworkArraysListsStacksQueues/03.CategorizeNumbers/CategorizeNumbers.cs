using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        float[] floatNums = new float[numbers.Length];

        List<float> floatingPointNums = new List<float>(); 
        List<int> roundNums = new List<int>(); 

        for (int i = 0; i < numbers.Length; i++)
        {
            floatNums[i] = float.Parse(numbers[i]); 
            int intNums = (int)floatNums[i]; 
            if (intNums != floatNums[i]) 
            {
                floatingPointNums.Add(floatNums[i]);
            }
            else
            {
                roundNums.Add(intNums);
            }
        }

        Console.Write("[");
        for (int k = 0; k < floatingPointNums.Count - 1; k++)
        {
            Console.Write("{0}, ", floatingPointNums[k]);
        }
        Console.Write(floatingPointNums[floatingPointNums.Count - 1]);
        Console.Write("] -> ");
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", floatingPointNums.Min(), floatingPointNums.Max(),
                        floatingPointNums.Sum(), floatingPointNums.Average());

        Console.Write("[");
        for (int k = 0; k < roundNums.Count - 1; k++)
        {
            Console.Write("{0}, ", roundNums[k]);
        }
        Console.Write(roundNums[roundNums.Count - 1]);
        Console.Write("] -> ");
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", roundNums.Min(), roundNums.Max(),
                        roundNums.Sum(), roundNums.Average());

        Console.ReadKey(true);
    }
}

