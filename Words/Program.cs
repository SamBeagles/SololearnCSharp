using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
            string letter = Console.ReadLine();
            int count = 0;
            foreach(var word in words)
            {
                if(word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count += 1;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}