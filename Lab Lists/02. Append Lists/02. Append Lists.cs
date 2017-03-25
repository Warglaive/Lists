using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();
            var result = new List<string>();
            foreach (var token in input)
            {
                token.Split(' ');
                result.Add(token);
                Console.WriteLine(result[result.Count-1]);
            }
        }
    }
}