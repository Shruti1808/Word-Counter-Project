using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounterTest
    {
        //If user enters a word with one instance.
        [Fact]
        public void RepeatCounter_userInputOneInstance_CountOne()
        {
            //Arrange
            string wordToFind = "world";
            string sentenceToSearch = "Travel the world";
            string expectedResult = "1";
            //Act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats(wordToFind,sentenceToSearch);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        //Test if the word word is repeated more than once in the input sentence by the user.
        [Fact]
        public void RepeatCounter_userInputMultipleInstances_CountFive()
        {
            //Arrange
            string wordToFind = "cats";
            string sentenceToSearch = "Red cats orange cats brown cats blue cats purple cats";
            string expectedResult = "5";
            //Act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats(wordToFind,sentenceToSearch);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        // Test if there is no match for the input word by the user.
        [Fact]
        public void RepeatCounter_userInputNoMatch_CountZero()
        {
            //Arrange
            string wordToFind = "universe";
            string sentenceToSearch = "Hello world";
            string expectedResult = "0";
            //Act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats(wordToFind,sentenceToSearch);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RepeatCounter_userInputFullMatch_CountOne()
        {
            //Arrange
            string wordToFind = "cat";
            string sentenceToSearch = "I walked my cat to the cathedral.";
            string expectedResult = "1";
            //Act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats(wordToFind,sentenceToSearch);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RepeatCounter_userInputIgnorePunctuation_CountTwo()
        {
            //Arrange
            string wordToFind = "cat";
            string sentenceToSearch = "Cats are so cute. I love cat, and I have a brown cat.";
            string expectedResult = "2";
            //Act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats(wordToFind,sentenceToSearch);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        



    }
}
