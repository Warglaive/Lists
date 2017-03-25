using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(' ').ToList();
            var result = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(text[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
