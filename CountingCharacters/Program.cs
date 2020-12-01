using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string input;

            Console.WriteLine("Enter a string:");
            input = Console.ReadLine().ToLower();
            char[] inputArray = input.ToCharArray();

            foreach (char thingie in inputArray)
            {
                if (letters.Contains(thingie))
                {
                    if (!charDict.ContainsKey(thingie))
                    {
                        charDict.Add(thingie, 1);
                    }
                    else
                    {
                        charDict[thingie]++;
                    }
                }
            }

            foreach (char thingie in charDict.Keys)
            {
                Console.WriteLine($"{thingie}: {charDict[thingie]}");
            }
        }
    }
}
