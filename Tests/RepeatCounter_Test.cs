using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounterTest
    {
        //if user enters a word with one instance.
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
    }
}
