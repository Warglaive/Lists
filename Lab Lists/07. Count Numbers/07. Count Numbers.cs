using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool didSwap = false;
            var counts = new int[numbers.Max() + 1];
            //sort numbers
            do
            {
                for (int i = 0; i < numbers.Count - 1; i++) 
                {
                    didSwap = false;
                    if (numbers[i] > numbers[i + 1]) 
                    {
                        var temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap);
            //Count numbers
            foreach (var num in numbers)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0 )
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}