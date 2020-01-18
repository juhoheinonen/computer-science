using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ComputerScience.Trees
{
    public class TrieTester
    {
        public static void Test(List<string> words, string[] guesses)
        {
            var trie = new Trie(words);

            //var trie = new Trie(new List<string> { "susi" });

            JsonConvert


            Console.Write("Kerro sana tai sanan alku");
            string guess = Console.ReadLine();

            while (!string.IsNullOrEmpty(guess))
            {
               ///var guesses = new List<string>() { "örkki", "peto", "susi", "lempi", "rakas", "norsu", "majava" };

                Console.WriteLine("guess: " + guess + ". Contains exact true : " + trie.Contains(guess, true) + ".");
                Console.WriteLine("guess: " + guess + ". Contains exact false: " + trie.Contains(guess) + ".");

                Console.Write("Kerro sana tai sanan alku");
                guess = Console.ReadLine();

            }
        }
    }
}
