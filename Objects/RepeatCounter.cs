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
            char separators = { ' ', ',', '.', ':' };
            string[] words = sentenceToSearch.Split(separators);
        }
     }
 }
