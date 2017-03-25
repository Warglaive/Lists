using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();
            numbers.Reverse();
            var result = new List<int>();
            var negativeResult = new List<int>();
            var counter = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0) 
                {
                    result.Add(numbers[i]);
                    counter++;
                    Console.Write($"{result[counter]}");
                    Console.Write(" ");
                }
                if (numbers[i] < 0)
                {
                    negativeResult.Add(numbers[i]);
                    if (negativeResult.Count == numbers.Count)
                    {
                        Console.Write("empty");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}