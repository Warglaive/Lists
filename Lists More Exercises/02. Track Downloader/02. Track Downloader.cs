using System;
using System.Collections.Generic;
using System.Linq;

namespace trackDownloader
{
    public class trackDownloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();
            var resultList = new List<string>();
            var fileNames = Console.ReadLine();
            while (fileNames != "end")
            {
                resultList.Add(fileNames);
                for (int i = 0; i < blacklist.Count; i++)
                {
                    if (fileNames.Contains(blacklist[i]))
                    {
                        resultList.Remove(fileNames);
                    }
                }
                fileNames = Console.ReadLine();
            }
            resultList.Sort();
            foreach (var song in resultList)
            {
                Console.WriteLine(song);
            }
        }
    }
}
