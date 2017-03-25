using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();
            bool isUpper = true;
            bool isLower = true;
            foreach (var word in text)
            {
                isUpper = true;
                isLower = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isLower = false;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        isUpper = false;
                    }
                    else
                    {
                        isLower = false;
                        isUpper = false;
                    }
                }
                if (isUpper)
                {
                    upperCase.Add(word);
                }
                else if (isLower)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
