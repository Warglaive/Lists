using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstListSum = 0;
            var secondListSum = 0;
            var max = 0;
            var min = 0;
            var total = 0;
            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i])) 
                {
                    secondList.Remove(firstList[i]);
                }
                firstListSum += firstList[i];
            }
            foreach (var num in secondList)
            {
                secondListSum += num;
            }
            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {firstListSum}");
            }
            else
            {
                max = Math.Max(firstListSum, secondListSum);
                min = Math.Min(firstListSum, secondListSum);
                total = max - min;
                Console.WriteLine($"No. Diff: {total}");
            }
        }
    }
}
