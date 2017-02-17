using System;
using System.Collections.Generic;

 namespace WordCounter.Objects
 {
     public class RepeatCounter
     {
        public static CountRepeats(string wordToFind, string sentenceToSearch)
        {
            //Converts the input to lowercase word to match
         wordToFind = wordToFind.ToLower();
         sentenceToSearch = sentenceToSearch.ToLower();
         //ignore the punctuation......
            char separators = { ' ', ',', '.', ':' };
            string[] words = sentenceToSearch.Split(separators);
            List<string> matchedWords = new List<string>();

            foreach (string word in words)
            {
            if (word == wordToFind){
                matchedWords.Add(word);
            }
            }
        }
     }
 }
