using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give me a word.");
            string newWord= Console.ReadLine().ToLower();
            Console.WriteLine("Now give me some other words to compare. Enter Q when you're done.");
            AnagramFinder finder = new AnagramFinder(newWord);
            finder.SetOtherWords();
            finder.GetSortedWord();

            // foreach(char character in myCharArray)
            // {
            //     Console.WriteLine(character);
            // }
            // Array.Sort(myCharArray);            
        }
    }
}