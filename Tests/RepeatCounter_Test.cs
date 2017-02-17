using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounterTest
    {
        //if user enters word in capitals
        [Fact]
        public void RepeatCounter_userInput_Count1()
        {
            //arrange

            string expectedResult = "1"
            //act
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string result = testRepeatCounter.CountRepeats("world","Travel the world");
            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}
