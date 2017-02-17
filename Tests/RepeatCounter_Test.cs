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
            //arrange
            string wordToFind = "world";
            string sentenceToSearch = "Travel the world";
            string expectedResult = "1";
            //act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats("world","Travel the world");
            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}
