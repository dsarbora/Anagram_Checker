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
        public void GoGetTheAnagrams()
        {
            this.SetOtherWords();
            this.SortOtherWords();
            this.ShowAnagrams();
        }
        public void SetOtherWords()
        {
            string newWord = Console.ReadLine();
            if(newWord!="q")
            {
                OtherWords.Add(newWord);
                this.SetOtherWords();
            }
            else
            {
                this.SortInput();
            }
        }
        public void SortInput()
        {
            char[] charArray = Input.ToCharArray();
            Array.Sort(charArray);
            SortedInput = string.Join("", charArray);
            
        }
        public void SortOtherWords()
        {
            foreach(string word in OtherWords)
            {
                string lowerWord = word.ToLower();
                char[] charArray = lowerWord.ToCharArray();
                Array.Sort(charArray);
                string sortedCompare = new string(charArray);
                if(sortedCompare == SortedInput)
                {
                     AnagramList.Add(word);
                }
            }
        }
        public void ShowAnagrams()
        {
            foreach (string anagram in AnagramList)
            {
                if (anagram != Input)
                {
                    Console.WriteLine(anagram + " is an anagram of " + Input);
                }
                else
                {
                    Console.WriteLine(anagram + " IS " + Input);
                }
            }
        }
    }
}