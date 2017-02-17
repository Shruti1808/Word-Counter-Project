using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        public string CountRepeats(string wordToFind, string sentenceToSearch)
            {
                //Converts the input to lowercase word to match
                wordToFind = wordToFind.ToLower();
                sentenceToSearch = sentenceToSearch.ToLower();
                //ignore the punctuation......
                char[] separators = new char[]{ ' ', ',', '.', ':' };
                string[] words = sentenceToSearch.Split(separators);
                List<string> matchedWords = new List<string>();

                foreach (string word in words)
                {
                    if (word == wordToFind){
                        matchedWords.Add(word);
                    }
                }

                int repeatCount = matchedWords.Count;
                string result = repeatCount.ToString();
                return result;
            }
        }
    }
