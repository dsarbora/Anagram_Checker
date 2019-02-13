using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramFinder
    {
        private string Input;
        private string SortedInput;
        private List<string> OtherWords = new List<string>(){};
        private List<string> AnagramList = new List<string>(){};

        public AnagramFinder(string input)
        {
            Input = input;
        } 
        public string GetString()
        {
            return Input;
        }
        public void SetOtherWords()
        {
            string newWord = Console.ReadLine().ToLower();
            if(newWord!="q")
            {
                OtherWords.Add(newWord);
                this.SetOtherWords();
            }
            else
            {
                this.FindAnagrams();
            }
        }
        public void GetSortedWord()
        {
            char[] charArray = Input.ToCharArray();
            Array.Sort(charArray);
            SortedInput = string.Join("", charArray);
            this.FindAnagrams();
        }
        public void FindAnagrams()
        {
            foreach(string word in OtherWords)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedCompare = new string(charArray);
                if(sortedCompare == SortedInput)
                {
                     AnagramList.Add(word);
                }
            }
            this.ShowAnagrams();
        }
        public void ShowAnagrams()
        {
            foreach (string anagram in AnagramList)
            {
                Console.WriteLine(anagram + " is an anagram of " + Input);
            }
        }
    }
}