# Word Counter

#### _A web application to count how many times a word appears within a word or a string of words input by the user._

#### By _**Shruti Priya**_

## Description

This web application takes an input from the user: a word or string  of words, to find how frequently the word appears in that string. The application then provides the number of times the user's chosen word appears in their chosen sentence.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono.
* Clone repository to local machine.
* Use command "dnu restore" in Powershell to restore dependencies.
* Use command "dnx kestrel" to start server.
* View "http://localhost:5004" in your default web browser.

## Specifications

**If the user enters a word and a string then count the instances of word.**
* Example Input: "world", "Travel the world",
* Example Output: "world" appears 1 time .Count = 1;

**If the user enters a word or a string then count the multiple instances of word.**
* Example Input: "cats"; "Red cats orange cats brown cats blue cats purple cats"
* Example Output: "'cats' appears 5 times." Count = 5;

**If the user chooses a word that is no match in the string, return the count as 0.**
* Example Input: "universe", "Hello world"
* Example Output: Count = 0;

**Only return full word match, not if the string is contained within words.**
* Example Input: "cat"; "I walked my cat to the cathedral."
* Example Output: Count = 1;

**If the user enters a word or a string of words that has punctuation , then ignore it.**
* Example Input: "cat"; "Cats are so cute. I love cat, and I have a brown cat."
* Example Output: Count = 2;

**If the user enters a word or a string of words that is capitalized, then ignore the matching word in the string.**
* Example Input: "cat"; Cats are so cute. I love my cat."
* Example Output: Count = 1;

## Support and contact details

Please contact Shruti Priya at shrutipriya1808@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:

* HTML,CSS and Bootstrap framework
* Nancy framework
* Mono
* DNVM
* C#
* Razor
* Behaviour Driven Development Approach.

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_ Shruti Priya_**
<!-- // private string _wordToFind;
// private string _sentenceToSearch;
// private int _userCount;

// public RepeatCounter(string wordToFind, string sentenceToSearch)
// {
//     _wordToFind = wordToFind;
//     _sentenceToSearch = sentenceToSearch;
//     _userCount = 0;
// }
// public string GetWordToFind()
// {
//     return _wordToFind;
// }
// public void SetWordToFind()
// {
//     _wordToFind = wordToFind;
// }
// public string GetSentenceToSearch()
// {
//     return _sentenceToSearch;
// }
// public void SetSentenceToSearch()
// {
//     _sentenceToSearch = sentenceToSearch;
// } -->
